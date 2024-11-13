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
    public partial class StudentEvaluationForm : Form
    {
        private MainForm mainForm;
        public StudentEvaluationForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            LoadQuestions();
        }
        private async void LoadQuestions()
        {
            var dbHelper = new DatabaseHelper(/*"localhost", "root", "", "ojt"*/);
            string query = "SELECT criteria_name FROM criteria";
            using var reader = await dbHelper.ExecuteReaderAsync(query);
            int yPosition = 10;
            while (reader.Read())
            {
                string question = reader.GetString(0);

                // Create a GroupBox for the question
                GroupBox groupBox = new GroupBox
                {
                    Text = question,
                    Location = new Point(10, yPosition),
                    Size = new Size(200, 100) // Adjust size as needed
                };
                panel1.Controls.Add(groupBox);

                int radioYPosition = 20; // Position for radio buttons inside the GroupBox

                // Create radio buttons inside the GroupBox
                for (int i = 1; i <= 5; i++)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = i.ToString(),
                        Tag = question + i,
                        AutoSize = true,
                        Location = new Point(10, radioYPosition) // Position radio buttons
                    };
                    groupBox.Controls.Add(radioButton);
                    if (i == 1)
                        radioButton.Select();
                    radioYPosition += 20; // Adjust for spacing between radio buttons
                }

                yPosition += groupBox.Height + 10; // Move down for next GroupBox
            }

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

        private void TestAns()
        {
            var result = new StringBuilder("Your Answers:\n\n");

            foreach (var answer in GetAnswers())
            {
                result.AppendLine($"{answer.Key}: {answer.Value}");
            }

            MessageBox.Show(result.ToString());
        }
    }

}
