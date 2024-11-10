using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections;
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
    public partial class InternListForm : Form
    {
        private MainForm _mainForm;
        private string _accountId;
        private string _accountType;
        public InternListForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _accountId = mainForm.accountID;
            _accountType = mainForm.accountType;
        }

        private async void InternListForm_Load(object sender, EventArgs e)
        {
            await LoadInternList(_accountId); //On Form load, load yung internlist for the signed user, supervisor/admin
        }

        private async Task LoadInternList(string userID)
        {
            string query = GetInternsQuery(); //Query string whether supervisor ba siya (get interns handled by this supervisor) or Admin (All interns)           

            try
            {
                //Load Intern List into Datagridview
                using var dbHelper = new DatabaseHelper();

                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@UserID", userID));

                var dataTable = new DataTable(); //New data table para ilagay sa datagridview
                dataTable.Load(reader); //Lagay contents ng query sa data table
                dataGridView1.DataSource = dataTable; //Gawing source ng data for datagridview yung ginawang datatable

                AddDataGridViewButtons(); //Insert view timelogs, view accomplishment reports, and (if admin, Evaluation Reports button)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddDataGridViewButtons()
        {
            //Add Button To datagridview (View time log)
            DataGridViewButtonColumn timeLogButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Time Logs",
                Text = "View", // Button text
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(timeLogButtonColumn); //Add column (button) to datagrid

            //Add Button To datagridview (View Accomplishment Reports)
            DataGridViewButtonColumn accRepButtonColumn = new DataGridViewButtonColumn
            {
                HeaderText = "Accomplishment Reports",
                Text = "View", //Button text
                UseColumnTextForButtonValue = true //Make text as button text
            };
            dataGridView1.Columns.Add(accRepButtonColumn); //Add column (button) to datagrid

            //if admin add view evaluation reports button
            if (_accountType == "admin")
            {
                DataGridViewButtonColumn evalButtonColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Evaluation Reports",
                    Text = "View", //Button text
                    UseColumnTextForButtonValue = true //Make text as button text
                };
                dataGridView1.Columns.Add(evalButtonColumn); //Add column (button) to datagrid
            }
        }

        private string GetInternsQuery()
        {
            if (_accountType == "supervisor") //Supervisor
            {
                return @"
                SELECT 
                    s.student_id AS 'Student Number',
                    s.last_name AS 'Last Name',
                    s.first_name AS 'First Name'
                FROM 
                    students s
                WHERE 
                    s.supervisor_id = (
                        SELECT supervisor_id 
                        FROM supervisors 
                        WHERE user_id = @UserID
                    );";
            }
            else //Admin
            {
                return @"
                SELECT 
                    s.student_id AS 'Student Number',
                    s.last_name AS 'Last Name',
                    s.first_name AS 'First Name',
                    sv.supervisor_id AS 'Supervisor ID',
                    CONCAT(sv.first_name, ' ', sv.last_name) AS 'Supervisor Name',
                    sv.company AS 'Company'
                FROM 
                    students s
                JOIN
                    supervisors sv ON s.supervisor_id = sv.supervisor_id
                ORDER BY
                    s.last_name;";
            }
        }

        //Add margin to buttons
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var cell = dataGridView1[e.ColumnIndex, e.RowIndex];
                cell.Style.Padding = new Padding(20, 10, 20, 10);

            }
        }


        //datagridview "button" click 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var columnName = this.dataGridView1.Columns[e.ColumnIndex].HeaderText;
            var studentNumber = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Student Number"].Value);

            switch (columnName)
            {
                case "Time Logs": //Time Log button function
                    var timeLogs = new TimeLogsForm(_mainForm, studentNumber);
                    _mainForm.LoadForm(timeLogs);
                    break;

                case "Accomplishment Reports": //accomplishment reports button function
                    var studentAccomplishmentReports = new StudentAccomplishmentReports(_mainForm, studentNumber);
                    _mainForm.LoadForm(studentAccomplishmentReports);
                    break;

                case "Evaluation Reports": //Eval reports
                    break;
            }
        }


    }
}
