﻿using MySqlConnector;
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
    public partial class StudentAccomplishmentReports : Form
    {
        private MainForm _mainForm;
        private string _userId;
        private int _studentId;
        private string baseString;

        public StudentAccomplishmentReports(MainForm mainForm, int studentId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _studentId = studentId;
            _userId = mainForm.accountID;
        }

        private async void StudentAccomplishmentReports_Load(object sender, EventArgs e)
        {
            await LoadStudentAccomplishmentReports();
            LoadStudentInfo();
            initializeEvalButton();
        }

        private async Task LoadStudentAccomplishmentReports()
        {
            try
            {

                //Load Intern List into Datagridview
                using var dbHelper = new DatabaseHelper();

                string query = @"
                 SELECT
                     report_id,
                     report_date AS Date
                 FROM
                     accomplishment_reports
                 WHERE
                     student_id = @studentId
                 ORDER BY 
                     report_date
                 DESC;";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@studentId", _studentId));

                //submission_status AS Status

                var dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;

                dataGridView1.Columns["report_id"].Visible = false; //hide yung ID sa datagridview 

                //Add Button To datagridview (View)
                var viewReportButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Details",
                    Text = "View", // Button text
                    UseColumnTextForButtonValue = true
                };
                dataGridView1.Columns.Add(viewReportButtonColumn); //Add column (button) to datagrid
                viewReportButtonColumn.Width = 300;
                await LoadStudentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task LoadStudentInfo()
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = "SELECT first_name, last_name, student_id, contact_number, pfPic FROM students WHERE student_id = @student_id;";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", _studentId));
                if (await reader.ReadAsync())
                {
                    labelStudentID.Text = reader["student_id"].ToString();
                    labelContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                    labelName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                    string picString = reader["pfPic"].ToString();

                    System.Drawing.Image pfp = Base64toImage(picString);
                    pictureBox1.Image = pfp;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                // Ensure the button corresponds to the "View" action
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Details")
                {
                    var reportId = dataGridView1.Rows[e.RowIndex].Cells["report_id"].Value; //get ID
                    btnViewFile_Click(reportId);
                }
            }
        }


        //Add padding to buttons
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                cell.Style.Padding = new Padding(20, 10, 20, 10);
            }
        }

        private void EvalButton_Click(object sender, EventArgs e)
        {
            StudentEvaluationForm studEval = new StudentEvaluationForm(_mainForm, _studentId);
            _mainForm.LoadForm(studEval);
        }

        private async void initializeEvalButton()
        {
            if (_mainForm.accountType == "admin")
            {
                EvalButton.Visible = false;
            }

            await CheckIfSubmittedEval();
        }


        //Checking if there is already submitted Eval Form for Specific Student
        private async Task CheckIfSubmittedEval()
        {
            using var dbHelper = new DatabaseHelper();
            string idQuery = "SELECT status FROM evaluations WHERE student_id = @studentNum";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentNum", _studentId),
            };

            using var reader = await dbHelper.ExecuteReaderAsync(idQuery, parameters);

            if (await reader.ReadAsync())
            {
                string status = reader["status"].ToString();

                if (status == "Submitted")
                {
                    EvalButton.Enabled = false;
                    EvalButton.BackColor = Color.Gray;
                }
            }

        }

        private System.Drawing.Image Base64toImage(string baseString)
        {
            try
            {
                byte[] imageBytes = Convert.FromBase64String(baseString);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return System.Drawing.Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error loading image: {ex.Message}");
                return Properties.Resources.icon_default; // Fallback to default image
            }
        }



        private async void btnViewFile_Click(object report_id)
        {
            try
            {
                string baseDirectory = "C:\\xampp\\htdocs\\tua_ojt_monitoring"; // Base directory for files
                string filePath = string.Empty;

                // Query to retrieve the file path
                string idQuery = "SELECT content FROM accomplishment_reports WHERE report_id = @report_id";

                using var dbHelper = new DatabaseHelper();
                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@report_id", report_id)
                };

                using var reader = await dbHelper.ExecuteReaderAsync(idQuery, parameters);

                if (await reader.ReadAsync())
                {
                    // Construct the full file path using Path.Combine
                    filePath = System.IO.Path.Combine(baseDirectory, reader["content"].ToString());

                    // Normalize the file path and check its existence
                    string normalizedPath = System.IO.Path.GetFullPath(filePath);
                    checkFile(normalizedPath);
                }
                else
                {
                    MessageBox.Show("File path not found in the database. Please verify the record.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving the file: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkFile(string filePath)
        {
            // Check if file exists
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    // Open the file using the default associated application
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not open the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The file does not exist at the specified path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
