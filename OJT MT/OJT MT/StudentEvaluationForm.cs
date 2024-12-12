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
using System.Windows.Forms.VisualStyles;

namespace OJT_MT
{
    public partial class StudentEvaluationForm : Form
    {
        private MainForm mainForm;
        private int studentNum;
        private RadioButton radioButton;
        private RichTextBox tbComments;
        private Button submitButton;

        public StudentEvaluationForm(MainForm mainForm, int studentNum)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.studentNum = studentNum;
            LoadDetails();
            LoadQuestions();
        }

        private async void LoadDetails()
        {
            try
            {
                var dbHelper = new DatabaseHelper();
                string query = "SELECT first_name, last_name, contact_number FROM students WHERE student_id = " + studentNum + "";

                using var reader = await dbHelper.ExecuteReaderAsync(query);

                if (await reader.ReadAsync())
                {
                    labelName.Text = reader["first_name"].ToString() + " " +  reader["last_name"].ToString();
                    labelStudentID.Text = studentNum.ToString();
                    labelContactNumber.Text = reader["contact_number"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private async void LoadQuestions()
        {
            int yPosition = 10;

            //Instructions
            Label instructionsLabel = new Label
            {
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Text = "Evaluate the intern based on the given criteria (From Lowest - 1 to Highest - 5).",
                Location = new Point(35, yPosition),
                Size = new Size(800, 25)
            };

            panel1.Controls.Add(instructionsLabel);

            var dbHelper = new DatabaseHelper();
            string query = "SELECT criteria_name FROM criteria";
            using var reader = await dbHelper.ExecuteReaderAsync(query);

            while (reader.Read())
            {
                string question = reader.GetString(0);

                // Calculate GroupBox height dynamically
                int groupBoxHeight = 30 + (5 * 30); // Padding + Space for 5 radio buttons
                GroupBox groupBox = new GroupBox
                {
                    Text = question,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    Location = new Point(35, yPosition + 35),
                    Size = new Size(700, groupBoxHeight),
                    Padding = new Padding(20)
                };

                panel1.Controls.Add(groupBox);

                int radioYPosition = 20;
                for (int i = 1; i <= 5; i++)
                {
                     radioButton = new RadioButton
                    {
                        Text = i.ToString(),
                        Font = new Font("Arial", 12, FontStyle.Regular),
                        Tag = question + i,
                        AutoSize = true,
                        Location = new Point(20, radioYPosition)
                    };

                    radioButton.CheckedChanged += RadioButton_CheckedChanged;

                    groupBox.Controls.Add(radioButton);
                    radioYPosition += 30; // Space between radio buttons
                }

                yPosition += groupBox.Height + 10; // Adjust for next GroupBox
            }

            //COMMENTS
            Label commentLabel = new Label 
            {
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                Text = "Comments",
                Location = new Point(35, yPosition + 60)

            };

            tbComments = new RichTextBox
            {
                Font = new Font("Arial", 12, FontStyle.Regular),
                Size = new Size(700, 50),
                Location = new Point(150, yPosition + 45)
            };
 

            panel1.Controls.Add(commentLabel);
            panel1.Controls.Add(tbComments);


            //Submit Button
             submitButton = new Button
            {
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Text = "SUBMIT",
                Size = new Size(130, 40),
                Location = new Point(380, yPosition + 130),
                Enabled = false
             };

            submitButton.Click += SubmitButton_Click;

            panel1.Controls.Add(submitButton);


            Label spacerLabel = new Label
            {
                Text = string.Empty,
                Height = 30,         // Spacer height
                AutoSize = false,    // Fixed size spacer
                BackColor = Color.Transparent
            };

            // Set the location for the spacer
            spacerLabel.Location = new Point(0, panel1.Controls.Count > 0
                ? panel1.Controls[panel1.Controls.Count - 1].Bottom
                : 0); // Position it below the last control, or at the top if no controls exist

            panel1.Controls.Add(spacerLabel); //adding spacer to panel


            // Enable scrollbars for overflow
            panel1.AutoScroll = true;
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Check if all questions have been answered
            bool allAnswered = true;

            foreach (var control in panel1.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    bool anyChecked = groupBox.Controls.OfType<RadioButton>().Any(r => r.Checked);
                    if (!anyChecked)
                    {
                        allAnswered = false;
                        break;
                    }
                }
            }

            // Enable or disable the submit button based on allAnswered
            submitButton.Enabled = allAnswered;
            submitButton.BackColor = allAnswered ? Color.FromArgb(12, 64, 41) : Color.Gray;
        }

        private Dictionary<string, int> GetAnswers()
        {
            var answers = new Dictionary<string, int>();

            foreach (var control in panel1.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (var radioButton in groupBox.Controls.OfType<RadioButton>())
                    {
                        if (radioButton.Checked)
                        {
                            // Store the question and the selected answer
                            answers[groupBox.Text] = int.Parse(radioButton.Text);
                        }
                    }
                }
            }

            return answers; // Dictionary with question as key and answer as value
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            InsertEvaluation();
        }


        private async void InsertEvaluation()
        {
            //INSERTING Part 1 - Evaluation Details
            int supervisor_id = await LoadSupID();

            var dbHelper = new DatabaseHelper();

            string query1 = "INSERT INTO evaluations (student_id, supervisor_id, evaluation_date, comments, status)" +
                "VALUES (@student_id, @supervisor_id, @evalDate, @comments, @status)";


                MySqlParameter[] userParameters1 = new MySqlParameter[]
               {
                        new MySqlParameter("@student_id", studentNum),
                        new MySqlParameter("@supervisor_id", supervisor_id),
                        new MySqlParameter("@evalDate", DateTime.Now.Date),
                        new MySqlParameter("@comments", tbComments.Text),
                        new MySqlParameter("@status", "Submitted")
               };

             await dbHelper.ExecuteNonQueryAsync(query1, userParameters1);
           

            //INSERTING Part 2 - Evaluation Scores 
            int evalID = await GetEvalId();

            int quesNum = 1;
            foreach (var answer in GetAnswers())
            {
                int score = answer.Value;

                string query2 = "INSERT INTO evaluation_scores (evaluation_id, criteria_id, score)" +
                "VALUES (@evaluation_id, @criteria_id, @score)";

                MySqlParameter[] userParameters2 = new MySqlParameter[]
                {
                    new MySqlParameter("@evaluation_id", evalID),
                    new MySqlParameter("@criteria_id", quesNum),
                    new MySqlParameter("@score", score)
                };

               await dbHelper.ExecuteNonQueryAsync(query2, userParameters2);
               quesNum++;
            }

            MessageBox.Show("Evaluation Submitted Successfully");
            var listIntern = new InternListForm(mainForm);
            mainForm.LoadForm(listIntern);
        }


        //Fetching Supervisor ID
        private async Task<int> LoadSupID()
        {
            string accountID = mainForm.accountID;
            using var dbHelper = new DatabaseHelper();
            string idQuery = "SELECT supervisor_id FROM supervisors WHERE user_id = @accountID";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@accountID", accountID)
            };

            using var reader = await dbHelper.ExecuteReaderAsync(idQuery, parameters);

            if (await reader.ReadAsync())
            {
                return reader.GetInt32("supervisor_id");
            }

            throw new Exception("Supervisor ID not found.");

        }

        //Fetching newly created Evaluation ID
        private async Task<int> GetEvalId()
        {
            using var dbHelper = new DatabaseHelper();
            string idQuery = "SELECT evaluation_id FROM evaluations WHERE student_id = @studentNum AND evaluation_date = @evalDate";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentNum", studentNum),
                new MySqlParameter("@evalDate", DateTime.Now.Date)
            };

            using var reader = await dbHelper.ExecuteReaderAsync(idQuery, parameters);

            if (await reader.ReadAsync())
            {
                return reader.GetInt32("evaluation_id");
            }

            throw new Exception("Evaluation ID not found.");

        }
    }
}
