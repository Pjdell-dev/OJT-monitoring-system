using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MT
{
    public partial class QuestionsPanel : Form
    {
        bool manageCriteriaPanelExpand = false;
        private int currentCriteriaId = -1;
        private string currentCriteria = string.Empty;
        private MainForm mainForm;
        private DataTable userTable = new DataTable();

        public QuestionsPanel(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadQuestions();
            tbAddCriteria_CheckContent();
        }

        private async void LoadQuestions()
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = @"SELECT criteria_id AS Criteria_ID, criteria_name AS Criteria_Name FROM criteria";
                using var reader = await dbHelper.ExecuteReaderAsync(query);

                userTable = new DataTable();
                userTable.Load(reader);
                dataGridViewUsers.DataSource = userTable;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbFilter.Text.Trim();
            string selectedColumn = comboBoxFilter.SelectedItem?.ToString() ?? string.Empty;//Get yung value ng combobox para alam kung ano ffilter
            if (selectedColumn == "-- Select --" || string.IsNullOrEmpty(filterText))
            {
                userTable.DefaultView.RowFilter = string.Empty;
                return;
            }
            switch (selectedColumn)  //switch kung incase dadagdag pa tayo filter types
            {
                case "Criteria Name":
                    userTable.DefaultView.RowFilter = $"[Criteria_Name] LIKE '%{filterText}%'";
                    break;
                case "Criteria ID":
                    userTable.DefaultView.RowFilter = $"CONVERT([Criteria_ID], System.String) LIKE '{filterText}%'";
                    userTable.DefaultView.Sort = "[Criteria_ID] ASC";
                    break;
            }
        }

        private async void DataGridViewCriteria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                currentCriteriaId = Convert.ToInt32(selectedRow.Cells["Criteria_ID"].Value);
                currentCriteria = selectedRow.Cells["Criteria_Name"].Value?.ToString() ?? string.Empty;
                await LoadCriteriaInfo(currentCriteriaId, currentCriteria);
            }
            else
            {

            }
        }

        private async Task LoadCriteriaInfo(int criteriaID, string criteria)
        {
            using var dbHelper = new DatabaseHelper();

            try
            {
                string query = "SELECT * FROM criteria WHERE criteria_id = @criteriaID";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@criteriaID", criteriaID));

                if (reader.Read())
                {
                    tbCriteriaID.Text = reader["criteria_id"].ToString();
                    tbCriteria.Text = reader["criteria_name"].ToString();
                }

                else
                {
                    MessageBox.Show("Failure to Load Criteria Info.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }

        }

        private void manageCriteriaPanelTimer_Tick(object sender, EventArgs e)
        {
            if (manageCriteriaPanelExpand)
            {
                tableLayoutPanelManageCriteria.ColumnStyles[1].Width -= 50F;
                panelUpdateWindow.Width -= 50;
                if (tableLayoutPanelManageCriteria.ColumnStyles[1].Width <= 10F)
                {
                    manageCriteriaPanelExpand = false;
                    manageCriteriaPanelTimer.Stop();
                }
            }
            else
            {
                tableLayoutPanelManageCriteria.ColumnStyles[1].Width += 50F;
                if (tableLayoutPanelManageCriteria.ColumnStyles[1].Width >= 390F)
                {
                    manageCriteriaPanelExpand = true;
                    manageCriteriaPanelTimer.Stop();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ManageCriteriaVisible(true);
            updatePanel.Visible = true;
            addPanel.Visible = false;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ManageCriteriaVisible(false);
            labelSuccessMessage.Visible = false;
            updatePanel.Visible = false;
            addPanel.Visible = false;
        }

        private void ManageCriteriaVisible(bool visible)
        {
            if (visible)
            {
                tableLayoutPanelManageCriteria.ColumnStyles[1].Width = 390F;
            }
            else
            {
                tableLayoutPanelManageCriteria.ColumnStyles[1].Width = 10F;
            }
        }

        //Add Criteria
        private void btnAddCriteria_Click(object sender, EventArgs e)
        {
            ManageCriteriaVisible(true);
            updatePanel.Visible = false;
            addPanel.Visible = true;
        }


        //Update Criteria
        private async void btnSave_Click(object sender, EventArgs e)
        {
            using var dbHelper = new DatabaseHelper();

            try
            {
                string query = "UPDATE criteria SET criteria_name = @criteriaName WHERE criteria_id = @criteriaID";

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@criteriaName", tbCriteria.Text),
                    new MySqlParameter("@criteriaID", tbCriteriaID.Text)
                };

                await dbHelper.ExecuteNonQueryAsync(query, parameters);
                labelSuccessMessage.Visible = true;
                LoadQuestions();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }
        }

        //Remove Criteria
        private async void buttonRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Doing this will also delete related records, do you still want to continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            int criteriaCount = await GetCriteriaCount();

            // Check the result
            if (result == DialogResult.Yes)
            {
                try
                {
                    using var dbHelper = new DatabaseHelper();
                    string query1 = "DELETE FROM criteria WHERE criteria_id = @criteriaID";

                    int rowsAffected = await dbHelper.ExecuteNonQueryAsync(query1, new MySqlParameter("@criteriaID", currentCriteriaId));

                    for (int i = currentCriteriaId + 1; i <= criteriaCount; i++)
                    {
                        int newId = i - 1;
                        string query2 = "UPDATE criteria SET criteria_id = @newId WHERE criteria_id = @criteriaID";

                        var parameters = new MySqlParameter[]
                        {
                            new MySqlParameter("@newId", newId),
                            new MySqlParameter("@criteriaID", i)
                        };

                        await dbHelper.ExecuteNonQueryAsync(query2, parameters);
                    }

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Criteria Deleted Successfully.");
                        LoadQuestions();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred: " + ex.Message);
                }
            }
        }

        //Get Criteria Count From DB
        private async Task<int> GetCriteriaCount()
        {
            using var dbHelper = new DatabaseHelper();

            try
            {
                string query = "SELECT COUNT(criteria_id) AS Criteria_Count FROM criteria";

                using var reader = await dbHelper.ExecuteReaderAsync(query);

                if (reader.Read())
                {
                    return reader.GetInt32("Criteria_Count");
                }

                else
                {
                    return 0;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
                return 0;
            }
        }

        private async void btnAddSubmit_Click(object sender, EventArgs e)
        {
            int criteriaCount = await GetCriteriaCount();

            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = "INSERT INTO criteria (criteria_id, criteria_name) VALUES (@criteriaID, @criteriaName)";

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@criteriaID", criteriaCount + 1),
                    new MySqlParameter("@criteriaName", tbAddCriteria.Text)
                };

                await dbHelper.ExecuteNonQueryAsync(query, parameters);

                MessageBox.Show("Criteria Added Successfully.");
                addPanel.Visible = false;
                ManageCriteriaVisible(false);
                tbAddCriteria.Clear();
                LoadQuestions();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred: " + ex.Message);
            }


        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            ManageCriteriaVisible(false);
            addPanel.Visible = false;
            updatePanel.Visible = false;
        }

        private void tbAddCriteria_CheckContent()
        {
            if (tbAddCriteria.Text == "")
            {
                btnAddSubmit.Enabled = false;
                btnAddSubmit.BackColor = Color.Gray;
            }

            else
            {
                btnAddSubmit.Enabled = true;
                btnAddSubmit.BackColor = Color.FromArgb(21, 115, 74);
            }
        }


        //Enable Buttons for both Save and Submit Buttons (located in different panels)
        private void tbAddCriteria_TextChanged(object sender, EventArgs e)
        {
            tbAddCriteria_CheckContent();
        }

        private void tbCriteria_TextChanged(object sender, EventArgs e)
        {
            if (tbCriteria.Text == "")
            {
                btnSave.Enabled = false;
                btnSave.BackColor = Color.Gray;
            }

            else
            {
                btnSave.Enabled = true;
                btnSave.BackColor = Color.FromArgb(21, 115, 74);
            }
        }
    }
}

