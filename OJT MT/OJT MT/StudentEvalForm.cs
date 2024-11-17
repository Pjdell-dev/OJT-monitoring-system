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
    public partial class StudentEvalForm : Form
    {
        private int _studentID;
        private int _supervisorID;
        private MainForm mainForm;
        private Dictionary<int, FlowLayoutPanel> questionPanels = new Dictionary<int, FlowLayoutPanel>();
        public StudentEvalForm(MainForm mainForm, int studentID, int supervisorID)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _studentID = studentID;
            _supervisorID = supervisorID;
            LoadQuestions();
            LoadStudentDetails();
        }

        public StudentEvalForm()
        {
            InitializeComponent();
        }

        private async void LoadStudentDetails()
        {
            var dbHelper = new DatabaseHelper();
            string query = @"SELECT student_number, last_name, first_name, contact_number FROM students WHERE student_number = @studentID";
            using var reader2 = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@studentID", _studentID));
            if (await reader2.ReadAsync())
            {
                labelStudentID.Text = reader2["student_number"].ToString();
                labelContactNumber.Text = reader2["contact_number"].ToString();
                labelName.Text = reader2["first_name"].ToString() + " " + reader2["last_name"].ToString();
            }
        }

        private async void LoadQuestions()
        {
            var dbHelper = new DatabaseHelper();
            string query = "SELECT criteria_id, criteria_name FROM criteria";
            using var reader = await dbHelper.ExecuteReaderAsync(query);
            while (reader.Read())
            {
                string question = reader.GetString(1);
                int questionID = reader.GetInt32(0);
                tableLayoutPanelQuestions.RowCount++;

                Label labelQuestion = new Label
                {
                    Text = question,
                    AutoSize = true,
                    TextAlign = ContentAlignment.TopLeft,
                    Padding = new Padding(10),              
                    Tag = questionID
                };

                FlowLayoutPanel flowLayoutPanelQuestions = new FlowLayoutPanel();
                flowLayoutPanelQuestions.Dock = DockStyle.Fill;
                tableLayoutPanelQuestions.Controls.Add(labelQuestion, 0, tableLayoutPanelQuestions.RowCount - 1);
                tableLayoutPanelQuestions.Controls.Add(flowLayoutPanelQuestions, 1, tableLayoutPanelQuestions.RowCount - 1);

                //Store FlowLayoutPanel in the dictionary (questionPanels)
                questionPanels[questionID] = flowLayoutPanelQuestions;

                // Create radio buttons inside the flowlayoutpanelquestions
                for (int i = 1; i <= 5; i++)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = i.ToString(),
                        Tag = question + i,
                        AutoSize = true,
                    };
                    flowLayoutPanelQuestions.Controls.Add(radioButton);
                    if (i == 1)
                        radioButton.Select(); //Select 1 as Default
                }
            }
        }

        private async void EvaluateStudent(int supervisorID, int studentID)
        {
            var dbHelper = new DatabaseHelper();
            var result = new StringBuilder("Your Answers:\n\n");
            int evaluationID;
            //Generate Evaluation
            string insertNewEvaluationQuery = "INSERT INTO evaluations (student_number, supervisor_id, evaluation_date) VALUES (@studentID, @supervisorID, @date); SELECT LAST_INSERT_ID();";

            var evaluationParameters = new[]
            {
                        new MySqlParameter("@supervisorID", supervisorID),
                        new MySqlParameter("@studentID", studentID),
                        new MySqlParameter("@date", DateTime.UtcNow.Date)
            };
            object newEvaluationQuery = await dbHelper.ExecuteScalarAsync(insertNewEvaluationQuery, evaluationParameters);
            evaluationID = Convert.ToInt32(newEvaluationQuery);
            MessageBox.Show(evaluationID.ToString());

            //Save Scores -> Load from the dictionary to load saved flowlayoutpanel and get answer from selected radiobutton inside the flowlayoutpanel
            foreach (var entry in questionPanels)
            {
                int questionID = entry.Key;
                FlowLayoutPanel panel = entry.Value;

                // Find the selected radio button
                var selectedRadioButton = panel.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
                if (selectedRadioButton != null)
                {
                    int selectedValue = int.Parse(selectedRadioButton.Text);//Store selected radiobutton text as int (Score value)
                    string insertScoresQuery = "INSERT INTO evaluation_scores (evaluation_id, criteria_id, score) VALUES (@evaluationID, @criteriaID, @score)";

                    var scoresParameters = new[]
                    {
                        new MySqlParameter("@evaluationID", evaluationID),
                        new MySqlParameter("@criteriaID", questionID),
                        new MySqlParameter("@score", selectedValue)
                    };
                    await dbHelper.ExecuteNonQueryAsync(insertScoresQuery, scoresParameters);

                    // Execute the query
                    result.AppendLine($"{entry.Key}: {selectedValue}");
                }
            }

            MessageBox.Show(result.ToString());
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            EvaluateStudent(_supervisorID, _studentID);
        }
    }
}
