using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OJT_MT
{
    public partial class InternListForm : Form
    {
        private MainForm _mainForm;
        private string _accountId;
        private string _accountType;
        private PrintDocument printEvalDocument;
        private PrintPreviewDialog printPreviewDialog1;

        //labels for printForm
        string labelStudentID;
        string labelContactNumber;
        string labelName;
        string labelCriteriaName;
        int labelEvalScores;
        string labelEvalComments;
        byte[] baseString;

        private List<string> criteriaNames = new List<string>(); //storing criteria names
        private List<int> EvalScores = new List<int>();
        private List<string> EvalComments = new List<string>();

        public InternListForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _accountId = mainForm.accountID;
            _accountType = mainForm.accountType;

            printEvalDocument = new PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog
            {
                Document = printEvalDocument,
                Width = 800,
                Height = 600
            };

            // Attach PrintPage event
            printEvalDocument.PrintPage += printEvalDocument_PrintPage;
           // printEvalDocument.EndPrint += printEvalDocument_EndPrint;
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
                //Load Intern List into Datagridview 11037
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
                    printEvalButton_Click(studentNumber);
                    break;

            }
        }

        private async Task LoadStudentInfo(int studentNumber)
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = "SELECT first_name, last_name, student_id, contact_number, pfPic FROM students WHERE student_id = @student_id;";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", studentNumber));
                if (await reader.ReadAsync())
                {
                    labelStudentID = reader["student_id"].ToString();
                    labelContactNumber = reader["contact_number"]?.ToString() ?? string.Empty;
                    labelName = $"{reader["first_name"]} {reader["last_name"]}";
                    baseString = reader["pfPic"] as byte[];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadEvalInfo(int studentNumber)
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = "SELECT criteria_name FROM criteria";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", studentNumber));

                while (await reader.ReadAsync())
                {
                    labelCriteriaName = reader["criteria_name"].ToString();
                    criteriaNames.Add(labelCriteriaName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadEvalScores(int studentNumber) //loading eval scores
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = "SELECT es.score AS EvalScores, e.evaluation_id AS EvalId, e.evaluation_date AS EvalDate, e.comments AS EvalComments FROM evaluations e JOIN evaluation_scores es ON e.evaluation_id = es.evaluation_id WHERE e.student_id =  @student_id";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", studentNumber));

                while (await reader.ReadAsync())
                {
                    labelEvalScores = Convert.ToInt32(reader["EvalScores"]);
                    labelEvalComments = reader["EvalComments"].ToString();
                    EvalComments.Add(labelEvalComments);
                    EvalScores.Add(labelEvalScores);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task ClearItems()
        {
            criteriaNames.Clear();
            EvalScores.Clear();
            EvalComments.Clear();
        }

        private void printEvalDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                Font fontTitle = new Font("Times New Roman", 14, FontStyle.Bold);
                Font fontSubTitle = new Font("Times New Roman", 14, FontStyle.Bold);
                Font fontRegular = new Font("Times New Roman", 14, FontStyle.Bold);
                Font fontRegular2 = new Font("Times New Roman", 10, FontStyle.Italic);
                int y = 20;

                Image ojt_logo = Properties.Resources.CEIS;
                e.Graphics.DrawImage(ojt_logo, 645, y, 130, 130);


                Image tua_logo = Properties.Resources.TUA;
                e.Graphics.DrawImage(tua_logo, 80, y + 3, 130, 130);


                e.Graphics.DrawString("TRINITY UNIVERSITY OF ASIA", fontTitle, Brushes.Black, 280, y += 40);
                e.Graphics.DrawString("OJT MONITORING", fontSubTitle, Brushes.Black, 340, y += 40);
                e.Graphics.DrawString("EVALUATION REPORT", fontTitle, Brushes.Black, 320, y += 80);

                Image pfPic = OurCustomUtils.LongBlobToImage(baseString);
                e.Graphics.DrawImage(pfPic, 175, y + 35, 120, 120);
                e.Graphics.DrawString("Name: " + labelName, fontTitle, Brushes.Black, 320, y += 60);
                e.Graphics.DrawString("Student ID: " + labelStudentID, fontRegular, Brushes.Black, 320, y += 25);
                e.Graphics.DrawString("Contact #: " + labelContactNumber, fontRegular, Brushes.Black, 320, y += 25);

               
                y += 75;
                int tableX = 100;
                int tableWidth = 600;
                int rowHeight = 30;
                int[] columnWidths = { 0, 400, 0, 350};

                e.Graphics.DrawRectangle(Pens.Black, tableX, y, tableWidth, rowHeight);
                e.Graphics.DrawString("Criteria", fontRegular, Brushes.Black, tableX + columnWidths[0] + 5, y + 5);
                e.Graphics.DrawString("Evaluation Scores", fontRegular, Brushes.Black, tableX + columnWidths[1] + 5, y + 5);
                //e.Graphics.DrawString("Evaluation Comments", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2] + 5, y + 5);
            //e.Graphics.DrawString("Time In", fontRegular, Brushes.Black, tableX + columnWidths[0] + 5, y + 5);
            //e.Graphics.DrawString("Time Out", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + 5, y + 5);
            //e.Graphics.DrawString("Remarks", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2] + 5, y + 5);

            y += rowHeight;

            if (criteriaNames.Count == EvalScores.Count) // Ensure both collections have the same count
            {
                for (int i = 0; i < criteriaNames.Count; i++)
                {

                    e.Graphics.DrawRectangle(Pens.Black, tableX, y, tableWidth, rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, tableX, y, columnWidths[0], rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, tableX, y, columnWidths[1], rowHeight);
                    Console.WriteLine("tablex " + tableX + "y " + y);


                    // Draw criteria name
                    e.Graphics.DrawString(criteriaNames[i], fontRegular, Brushes.Black, tableX + columnWidths[2] + 5 , y + 5);
                    

                    // Draw evaluation score
                    e.Graphics.DrawString(EvalScores[i].ToString(), fontRegular, Brushes.Black, tableX + columnWidths[3] + 100 , y + 5);
                    Console.WriteLine("tablex " + tableX + "y " + y);
                    // Increment the Y position for the next row
                    y += rowHeight; // Advance by two rows (one for each type of data)
 
                }

                double totalScores = 0;
                double average = 0;
                for (int x = 0; x < EvalScores.Count; x++)
                {
                   totalScores += EvalScores[x];
                }

                average = totalScores / criteriaNames.Count;
                e.Graphics.DrawString("Average Score:", fontRegular, Brushes.Black, tableX, y + 120);
                e.Graphics.DrawString(average.ToString(), fontRegular, Brushes.Black, tableX + 135, y + 120);

                e.Graphics.DrawString("Verbal Interpretation:", fontRegular, Brushes.Black, tableX + 275, y + 120);

                if (average == 5)
                {
                    e.Graphics.DrawString("Very Good", fontRegular, Brushes.Black, tableX + 475, y + 120);
                }
                else if (average >= 4)
                {
                    e.Graphics.DrawString("Good", fontRegular, Brushes.Black, tableX + 475, y + 120);
                }
                else if (average >= 3)
                {
                    e.Graphics.DrawString("Fair", fontRegular, Brushes.Black, tableX + 475, y + 120);
                }
                else if (average >= 2)
                {
                    e.Graphics.DrawString("Poor", fontRegular, Brushes.Black, tableX + 475, y + 120);
                }
                else if (average >= 1)
                {
                    e.Graphics.DrawString("Very Poor", fontRegular, Brushes.Black, tableX + 475, y + 120);
                }

            }
            else
            {
                // Handle mismatched counts (optional)
                throw new InvalidOperationException("The criteria names and evaluation scores do not have the same number of elements.");
            }

            //Legend
            e.Graphics.DrawString("Legend:", fontRegular, Brushes.Black, tableX, y + 35);
            e.Graphics.DrawString("Very Good - 5", fontRegular, Brushes.Black, tableX, y + 35 + rowHeight);
            e.Graphics.DrawString("Good - 4", fontRegular, Brushes.Black, tableX + 150, y + 35 + rowHeight);
            e.Graphics.DrawString("Fair - 3", fontRegular, Brushes.Black, tableX + 250, y + 35 + rowHeight);
            e.Graphics.DrawString("Poor - 2", fontRegular, Brushes.Black, tableX + 350, y + 35 + rowHeight);
            e.Graphics.DrawString("Very Poor - 1", fontRegular, Brushes.Black, tableX + 450, y + 35 + rowHeight);


            //e.Graphics.DrawRectangle(Pens.Black, tableX, y + 100, tableWidth, rowHeight);
            e.Graphics.DrawString("Comments:", fontRegular, Brushes.Black, tableX, y + 180);
            e.Graphics.DrawString(labelEvalComments.ToString(), fontRegular, Brushes.Black, tableX, y + 180 + rowHeight);

            using (Pen blackPen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawLine(blackPen, tableX, y + 300, tableX + 250, y + 300);
                e.Graphics.DrawLine(blackPen, tableX + 400, y + 300, tableX + 650, y + 300);
            }

            e.Graphics.DrawString("Supervisor", fontRegular, Brushes.Black, tableX + 70, y + 275 + rowHeight);
            e.Graphics.DrawString("(Signature Over Printed Name)", fontRegular2, Brushes.Black, tableX + 30, y + 300 + rowHeight);
            e.Graphics.DrawString("Coordinator", fontRegular, Brushes.Black, tableX + 475, y + 275 + rowHeight);
            e.Graphics.DrawString("(Signature Over Printed Name)", fontRegular2, Brushes.Black, tableX + 440, y + 300 + rowHeight);




            ClearItems();


        }

        private async void printEvalButton_Click(int studentNumber)
        {
            using var dbHelper = new DatabaseHelper();
            string idQuery = "SELECT COUNT(*) AS Student_Count FROM evaluations WHERE student_id = @studentNum";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentNum", studentNumber)
            };

            using var reader = await dbHelper.ExecuteReaderAsync(idQuery, parameters);

            if (await reader.ReadAsync())
            {
                int studCount = Convert.ToInt32(reader["Student_Count"]);

                if (studCount > 0)
                {
                    await LoadEvalInfo(studentNumber);
                    await LoadEvalScores(studentNumber);
                    await LoadStudentInfo(studentNumber);
                    printPreviewDialog1.Document = printEvalDocument;
                    printPreviewDialog1.ShowDialog();
                }

                else
                {
                    MessageBox.Show("No Evaluation Submitted For This Student.");
                }
            }    
        }

    }
}
