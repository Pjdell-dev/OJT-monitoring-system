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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OJT_MT
{
    public partial class AdminManageUsersForm : Form
    {
        bool manageUsersPanelExpand = false;
        private MainForm _mainForm;
        private int currentUserId = -1;
        private int systemUserId = -1;
        private string currentUserAccountType = string.Empty;
        private DataTable userTable = new DataTable();
        public AdminManageUsersForm(MainForm mainForm)
        {
            DoubleBuffered = true;
            this._mainForm = mainForm;
            InitializeComponent();
            comboBoxFilter.SelectedIndex = 0; //Para default value na yung --select--
            pictureBoxAddNewUser.Image = OurCustomUtils.RecolorImage(Properties.Resources.user_add, "#fefffa");
            pictureBoxAddNewUser.Click += AddUsersClick;
            labelAddNewUser.Click += AddUsersClick;
            comboBoxSupervisorID.KeyPress += textBoxID_KeyPress;
        }

        private async void AdminManageUsersForm_Load(object sender, EventArgs e)
        {
            await LoadUsers();
            await LoadUserInfo(currentUserId, currentUserAccountType);

        }

        private async Task LoadUsers()
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = @"SELECT 
                                user_id as 'User ID', student_id AS 'ID Number', 
                                CONCAT(first_name, ' ', last_name) AS 'Full Name', 
                                'Student' AS 'Account Type'
                            FROM 
                                students

                            UNION ALL

                            SELECT 
                                 user_id as 'User ID', supervisor_id AS 'ID Number', 
                                CONCAT(first_name, ' ', last_name) AS 'Full Name', 
                                'Supervisor' AS 'Account Type'
                            FROM 
                                supervisors
                            ORDER BY 
                                'Full Name';";
                using var reader = await dbHelper.ExecuteReaderAsync(query);
                if (reader.Read())
                {
                    userTable = new DataTable();
                    userTable.Load(reader);
                    dataGridViewUsers.DataSource = userTable;
                }


                //Load combobox supervisor id
                comboBoxSupervisorID.SelectedIndex = -1;
                comboBoxSupervisorID.Items.Clear(); //Clear items
                query = @"SELECT supervisor_id, first_name, last_name FROM supervisors";
                using var reader2 = await dbHelper.ExecuteReaderAsync(query);
                var supervisorItems = new List<string>();
                while (reader2.Read())
                {
                    string item = $"{reader2["supervisor_id"]} - {reader2["first_name"]} {reader2["last_name"]}";
                    supervisorItems.Add(item);
                }
                comboBoxSupervisorID.Items.AddRange(supervisorItems.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        //filtering by, hinahiglight yung intended item
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
                case "Name":
                    userTable.DefaultView.RowFilter = $"[Full Name] LIKE '%{filterText}%'";
                    break;
                case "ID Number":
                    userTable.DefaultView.RowFilter = $"CONVERT([ID Number], System.String) LIKE '{filterText}%'";
                    userTable.DefaultView.Sort = "[ID Number] ASC";
                    break;
            }
        }

        private async void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];
                currentUserId = Convert.ToInt32(selectedRow.Cells["ID Number"].Value);
                systemUserId = Convert.ToInt32(selectedRow.Cells["User ID"].Value);
                currentUserAccountType = selectedRow.Cells["Account Type"].Value?.ToString() ?? string.Empty;
                Debug.WriteLine("User ID:" + currentUserId);
                Debug.WriteLine("Account Type: " + currentUserAccountType);
                await LoadUserInfo(currentUserId, currentUserAccountType);
            }
            else
            {

            }
        }

        private async Task LoadUserInfo(int userID, string accountType)
        {
            using var dbHelper = new DatabaseHelper();
            Debug.WriteLine(accountType);
            try
            {
                if (accountType == "Student")
                {
                    string query = @"SELECT student_id, first_name, last_name, contact_number, supervisor_id, user_id FROM students WHERE student_id = @user_id;";

                    using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@user_id", userID));
                    if (reader.Read())
                    {
                        textBoxID.Text = reader["student_id"]?.ToString() ?? string.Empty;
                        textBoxFirstName.Text = reader["first_name"]?.ToString() ?? string.Empty;
                        textBoxLastName.Text = reader["last_name"]?.ToString() ?? string.Empty;
                        textBoxContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                        //comboBoxSupervisorID.Text = reader["supervisor_id"]?.ToString() ?? string.Empty;
                        foreach (var item in comboBoxSupervisorID.Items)
                        {
                            // Split the item by the hyphen and trim to get the digit part
                            string itemText = item.ToString() ?? string.Empty;
                            int hyphenIndex = itemText.IndexOf('-');

                            if (hyphenIndex != -1)
                            {
                                // Extract the part before the hyphen and trim any whitespace
                                string digitBeforeHyphen = itemText.Substring(0, hyphenIndex).Trim();

                                // Check if it matches the given digit
                                if (digitBeforeHyphen == reader["supervisor_id"]?.ToString())
                                {
                                    comboBoxSupervisorID.SelectedItem = item; // Select the matching item
                                    break; // Exit loop once found
                                }
                            }
                        }

                            panelSupervisorID.Show();
                    }
                    else
                    {
                        Debug.WriteLine("No student found with the given user ID.");
                    }
                }
                else if (accountType == "Supervisor")
                {
                    string query = @"SELECT supervisor_id, first_name, last_name, contact_number FROM supervisors WHERE supervisor_id = @user_id;";

                    using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@user_id", userID));
                    if (reader.Read())
                    {
                        textBoxID.Text = reader["supervisor_id"]?.ToString() ?? string.Empty;
                        textBoxFirstName.Text = reader["first_name"]?.ToString() ?? string.Empty;
                        textBoxLastName.Text = reader["last_name"]?.ToString() ?? string.Empty;
                        textBoxContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                        panelSupervisorID.Hide();
                    }
                    else
                    {
                        Debug.WriteLine("No supervisor found with the given user ID.");
                    }
                }
                else
                {
                    Debug.WriteLine("Invalid account type");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"error: {ex.Message}");
            }
        }

        private void manageUsersPanelTimer_Tick(object sender, EventArgs e)
        {
            if (manageUsersPanelExpand)
            {
                tableLayoutPanelManageAccounts.ColumnStyles[1].Width -= 50F;
                panelUpdateWindow.Width -= 50;
                if (tableLayoutPanelManageAccounts.ColumnStyles[1].Width <= 10F)
                {
                    manageUsersPanelExpand = false;
                    manageUsersPanelTimer.Stop();
                }
            }
            else
            {
                tableLayoutPanelManageAccounts.ColumnStyles[1].Width += 50F;
                if (tableLayoutPanelManageAccounts.ColumnStyles[1].Width >= 390F)
                {
                    manageUsersPanelExpand = true;
                    manageUsersPanelTimer.Stop();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ManageUsersVisible(true);
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            int newId = Convert.ToInt32(textBoxID.Text);
            string newFirstName = textBoxFirstName.Text;
            string newLastName = textBoxLastName.Text;
            string newContactNumber = textBoxContactNumber.Text;

            



            try
            {
                using var dbHelper = new DatabaseHelper();
                string query;
                var parameters = new List<MySqlParameter>();
                if (currentUserAccountType == "Student")
                {

                    query = @"UPDATE 
                                        students 
                                    SET 
                                        student_id = @newStudentId,
                                        first_name = @newFirstName,
                                        last_name = @newLastName,
                                        contact_number = @newContactNumber,
                                        supervisor_id = @newSupervisorId
                                    WHERE
                                        student_id = @oldId;";


                    var selectedItem = comboBoxSupervisorID.SelectedItem;
                    int newSupervisorId = 1;
                    if (selectedItem != null)
                    {
                        string selectedValue = selectedItem.ToString() ?? string.Empty;

                        //Kunin yung number before hyphen, or take the whole string if no hyphen exists

                        int hyphenIndex = selectedValue.IndexOf('-');
                        if (hyphenIndex != -1)
                        {
                            //Extract the part before the hyphen
                            newSupervisorId = Convert.ToInt32(selectedValue.Substring(0, hyphenIndex).Trim());
                        }
                        else
                        {
                            //If no hyphen, take the whole string
                            newSupervisorId = Convert.ToInt32(selectedValue.Trim());
                        }
                    }
                    else return;



                    parameters.AddRange(new[]
                    {
                        new MySqlParameter("@newStudentId", newId),
                        new MySqlParameter("@newFirstName", newFirstName),
                        new MySqlParameter("@newLastName", newLastName),
                        new MySqlParameter("@newContactNumber", newContactNumber),
                        new MySqlParameter("@newSupervisorId", newSupervisorId),
                        new MySqlParameter("@oldId", currentUserId)
                    });

                }
                else if (currentUserAccountType == "Supervisor")
                {
                    query = @"UPDATE 
                                        supervisors 
                                    SET 
                                        supervisor_id = @newSupervisorId,
                                        first_name = @newFirstName,
                                        last_name = @newLastName,
                                        contact_number = @newContactNumber
                                    WHERE
                                        supervisor_id = @oldId;";

                    parameters.AddRange(new[]
                    {
                        new MySqlParameter("@newSupervisorId", newId),
                        new MySqlParameter("@newFirstName", newFirstName),
                        new MySqlParameter("@newLastName", newLastName),
                        new MySqlParameter("@newContactNumber", newContactNumber),
                        new MySqlParameter("@oldId", currentUserId)
                    });
                }
                else
                {
                    return;
                }

                int rowsAffected = await dbHelper.ExecuteNonQueryAsync(query, parameters.ToArray());

                if (rowsAffected > 0)
                {
                    labelSuccessMessage.Text = "User information updated successfully";
                    labelSuccessMessage.Show();
                    labelErrorMessage.Hide();
                    Console.WriteLine("User information updated successfully");
                    await LoadUsers();
                    

                    //await LoadUserInfo(currentUserId, currentUserAccountType);
                }
                else
                {
                    labelErrorMessage.Text = "Update failed";
                    labelSuccessMessage.Hide();
                    labelErrorMessage.Show();
                    Console.WriteLine("Update failed");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"error: {ex.Message}");
                labelErrorMessage.Text = "Update failed, make sure all information are valid";
                labelSuccessMessage.Hide();
                labelErrorMessage.Show();
                Console.WriteLine("Update failed");
            }



        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ManageUsersVisible(false);
            labelSuccessMessage.Visible = false;
        }

        private void ManageUsersVisible(bool visible)
        {
            if (visible)
            {
                tableLayoutPanelManageAccounts.ColumnStyles[1].Width = 390F;
            }
            else
            {
                tableLayoutPanelManageAccounts.ColumnStyles[1].Width = 10F;
            }
        }

        private void textBoxID_KeyPress(object? sender, KeyPressEventArgs e) //keypress event for the ID textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //pigilan if di control type or numbers
            }
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Doing this will also delete related records, do you still want to continue?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            // Check the result
            if (result == DialogResult.Yes)
            {
                try
                {
                    using var dbHelper = new DatabaseHelper();
                    string query;
                    if (currentUserAccountType == "Student")
                    {
                        query = @"DELETE FROM users WHERE user_id = @systemUserId";
                        
                    }
                    else if (currentUserAccountType == "Supervisor")
                    {
                        query = @"DELETE FROM users WHERE user_id = @systemUserId";
                    }
                    else
                    {
                        return;
                    }
                    int rowsAffected = await dbHelper.ExecuteNonQueryAsync(query, new MySqlParameter("@systemUserId", systemUserId));
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        await LoadUsers();
                    }
                    else
                    {

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void AddUsersClick(object? sender, EventArgs e)
        {
            _mainForm.LoadForm(new Register(_mainForm));
        }

        

        private void comboBoxSupervisorID_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            var selectedItem = comboBoxSupervisorID.SelectedItem;

            if (selectedItem != null)
            {
                string selectedValue = selectedItem.ToString() ?? string.Empty;
                int hyphenIndex = selectedValue.IndexOf('-');
                if (hyphenIndex != -1)
                {
                    comboBoxSupervisorID.Text = selectedValue.Substring(0, hyphenIndex).Trim();
                }
            }
        }
    }
}
