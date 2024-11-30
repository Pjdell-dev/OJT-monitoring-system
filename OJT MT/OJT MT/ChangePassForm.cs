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
    public partial class ChangePassForm : Form
    {
        MainForm mainForm;
        string userEmail;

        public ChangePassForm(MainForm mainForm, string userEmail)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.userEmail = userEmail;
            CheckContent();

            OurCustomUtils.CreatePasswordEye(
               enterNewPass, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
               );
            OurCustomUtils.CreatePasswordEye(
                confirmNewPass, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
                );
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginPageForm logIn = new LoginPageForm(mainForm);
            mainForm.LoadForm(logIn);
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            bool verifyOTC = await CheckOTC();
            if (verifyOTC == true)
            {
                if (enterNewPass.Text == confirmNewPass.Text)
                {
                    string password = enterNewPass.Text;
                    string hashedPass = OurCustomUtils.PassHash(password);

                    var dbHelper = new DatabaseHelper();
                    string query = "UPDATE users SET user_password= @password WHERE user_email = @email";

                    var parameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@password", hashedPass),
                        new MySqlParameter("@email", userEmail)
                    };

                    await dbHelper.ExecuteNonQueryAsync(query, parameters);
                    MessageBox.Show("Password Updated Successfully.");
                    DeleteOTC();
                    LoginPageForm loginPageForm = new LoginPageForm(mainForm);
                    mainForm.LoadForm(loginPageForm);
                }

                else
                {
                    MessageBox.Show("Passwords Don't Match.");
                }
            }
            else
            {
                MessageBox.Show("Invalid OTP.");
            }
        }

        private async Task<bool> CheckOTC()
        {
            var dbHelper = new DatabaseHelper();

            string query = "SELECT otc FROM one_time_code WHERE email = @userEmail";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@userEmail", userEmail)
            };

            using var reader = await dbHelper.ExecuteReaderAsync(query, parameters);

            if (reader.Read())
            {
                string otpDB = reader["otc"].ToString();

                if (otpDB == enterOTC.Text)
                {
                    return true; // OTC matches
                }
                else
                {
                    return false; // OTC does not match
                }
            }
            else
            {
                // Return false if no record is found
                return false;
            }
        }

        private async void DeleteOTC()
        {
            var dbHelper = new DatabaseHelper();
            string query = "DELETE FROM one_time_code WHERE email = @userEmail";

            var parameters = new MySqlParameter[]
           {
                new MySqlParameter("@userEmail", userEmail)
           };

            await dbHelper.ExecuteNonQueryAsync(query, parameters);
        }


        private void enterOTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered key is a digit, control key (like Backspace), or the decimal separator
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
            }
        }

        private void CheckContent()
        {
            if (enterNewPass.Text == "" || confirmNewPass.Text == "" || enterOTC.Text == "")
            {
                SubmitButton.Enabled = false;
                SubmitButton.BackColor = Color.Gray;
            }

            else
            {
                SubmitButton.Enabled = true;
                SubmitButton.BackColor = Color.FromArgb(21, 115, 74);
            }
        }

        private void enterNewPass_TextChanged(object sender, EventArgs e)
        {
            CheckContent();
        }

        private void confirmNewPass_TextChanged(object sender, EventArgs e)
        {
            CheckContent();
        }
        private void enterOTC_TextChanged(object sender, EventArgs e)
        {
            CheckContent();
        }

    }
}
