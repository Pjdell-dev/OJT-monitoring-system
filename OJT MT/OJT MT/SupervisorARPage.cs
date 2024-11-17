using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OJT_MT
{
    public partial class SupervisorARPage : Form
    {
        private MainForm mainForm;
        public SupervisorARPage(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            //on form load get user_id from mainForm
            LoadAccomplishmentReports(Int32.Parse(mainForm.accountID));
        }
        public async void LoadAccomplishmentReports(int userID)
        {
            //Load Intern List into Datagridview using supervisor's user_id to get manageable interns
            var dbHelper = new DatabaseHelper();
            string query = @"WITH LatestReports AS (
            SELECT 
                student_number, 
                MAX(report_date) AS latest_report_date
            FROM 
                accomplishment_reports
            GROUP BY 
                student_number
            )
            SELECT 
                s.student_number,
                s.last_name AS 'Last Name',
                s.first_name AS 'First Name',
                s.supervisor_id,
                ar.submission_status AS 'Status'
            FROM 
                students s
            LEFT JOIN 
                LatestReports lr ON s.student_number = lr.student_number
            LEFT JOIN 
                accomplishment_reports ar ON lr.student_number = ar.student_number AND lr.latest_report_date = ar.report_date
            WHERE s.supervisor_id = (
                SELECT supervisor_id FROM Supervisors WHERE user_id = @UserID
            );";
            using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@UserID", userID));

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["student_number"].Visible = false; //Hide Student ID
            dataGridView1.Columns["supervisor_id"].Visible = false; //Hide Supervisor ID
            //Add Button To datagridview (View accomplishment report)
            DataGridViewButtonColumn arColumn = new DataGridViewButtonColumn();
            arColumn.HeaderText = "Accomplishment Report";
            arColumn.Text = "View"; // Button text
            arColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(2, arColumn);
            //Add button to datagridview (evaluate)
            DataGridViewButtonColumn feedbackColumn = new DataGridViewButtonColumn();
            feedbackColumn.HeaderText = "Feedback";
            feedbackColumn.Text = "Evaluate"; // Button text
            feedbackColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(feedbackColumn);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String columnName = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            // Check if button column
            if (columnName == "Accomplishment Report")
            {
                MessageBox.Show("AR");
            }
            else if (columnName == "Feedback")
            {
                int studentID = 0;
                int supervisorID = 0;

                //Get student number and supervisor id by going through each columns and checking headertext to know if its the student number or supervisor id           
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    if (column.HeaderText == "student_number")
                    {
                        studentID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[column.Index].Value); //Store student number
                    }
                    else if (column.HeaderText == "supervisor_id")
                    {
                        supervisorID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[column.Index].Value);
                    }
                }
                if (studentID == 0 || supervisorID == 0)
                {
                    return;
                }
                StudentEvalForm studentEvaluationForm = new StudentEvalForm(mainForm, studentID, supervisorID);
                mainForm.LoadForm(studentEvaluationForm);
            }
        }


    }
}
