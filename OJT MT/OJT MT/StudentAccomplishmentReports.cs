using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // await LoadStudentAccomplishmentReports();
            LoadStudentInfo();
            initializeEvalButton();
        }
        /* private async Task LoadStudentAccomplishmentReports()
         {
             try
             {
                 //Load Intern List into Datagridview
                 using var dbHelper = new DatabaseHelper();

                 string query = @"
                 SELECT
                     report_id,
                     submission_date AS Date,
                     submission_status AS Status
                 FROM
                     accomplishment_reports
                 WHERE
                     student_id = @studentId
                 ORDER BY 
                     submission_date
                 DESC;";
                 using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@studentId", _studentId));

                 var dataTable = new DataTable();
                 dataTable.Load(reader);
                 dataGridView1.DataSource = dataTable;

                 //Add Button To datagridview (View)
                 var viewReportButtonColumn = new DataGridViewButtonColumn
                 {
                     HeaderText = "Details",
                     Text = "View", // Button text
                     UseColumnTextForButtonValue = true
                 };
                 dataGridView1.Columns.Add(viewReportButtonColumn); //Add column (button) to datagrid
                 viewReportButtonColumn.Width = 100;
                 await LoadStudentInfo();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
         } */

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
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                cell.Style.Padding = new Padding(20, 10, 20, 10);

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

        private void initializeEvalButton()
        {
            if (_mainForm.accountType == "admin")
            {
                EvalButton.Visible = false;
            }

            CheckIfSubmittedEval();
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
    }
}
