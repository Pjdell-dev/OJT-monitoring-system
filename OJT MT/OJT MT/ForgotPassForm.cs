using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace OJT_MT
{
    public partial class ForgotPassForm : Form
    {
        MainForm _mainForm;

        public ForgotPassForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            checkUserEmailContent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            LoginPageForm login = new LoginPageForm(_mainForm);
            _mainForm.LoadForm(login);
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dbHelper = new DatabaseHelper();
                string query = "SELECT COUNT(user_email) AS EmailCount FROM users WHERE user_email = @userEmail";

                var parameters = new MySqlParameter[]
                {
                new MySqlParameter("@userEmail", userEmail.Text)
                };

                using var reader = await dbHelper.ExecuteReaderAsync(query, parameters);


                if (reader.Read())
                {

                    int emailCount = Convert.ToInt32(reader["EmailCount"]);

                    if (emailCount > 0)
                    {
                        string OTC = RandomNumString(6);
                        InsertOTC(OTC);
                        SendEmail(OTC);
                        ChangePassForm changePass = new ChangePassForm(_mainForm, userEmail.Text);
                        _mainForm.LoadForm(changePass);
                    }

                    else
                    {
                        MessageBox.Show("Account with this Email Does Not Exist.");
                    }

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private static Random random = new Random();

        private static string RandomNumString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private async void InsertOTC(string OTC)
        {
            try
            {
                var dbHelper = new DatabaseHelper();
                string query = "INSERT INTO one_time_code (email, otc) VALUES (@userEmail,@otc)";

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@userEmail", userEmail.Text),
                    new MySqlParameter("@otc", OTC)
                };

                await dbHelper.ExecuteNonQueryAsync(query, parameters);
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void SendEmail(string OTC)
        {
            //email inputs
            string to = userEmail.Text;
            string subject = "TUA OJT MONITORING - One Time Code Verification for Password Reset";
            string body = $@"
                            <p>Dear {userEmail.Text},</p>
                            <p>Thank you for accessing the OJT Monitoring System. <br>To ensure the security of your account, we have generated a One-Time Code (OTC) for verification purposes.</p>
                            <br>
                            <p><b>Your One-Time Code is</b>: {OTC}</p>
                            <br>
                            <p>Please enter this code in the verification prompt to proceed. Once verified, you will receive your temporary password for logging into the system.<br><br><b>***Do not share this code with anyone to protect your account.***</b></p>
                            <p>If you encounter any issues or need further assistance, feel free to contact our support team at bangusdevs@gmail.com or call us at 09173214567.</p>
                            <br>
                            <p>Thank you for your cooperation.</p>
                            <p>Best regards,</p>
                            <p><b>TUA OJT Monitoring Team</b></p>
                            ";
            try
            {
                //email set up smtp
                string email = "bangusdevs@gmail.com";
                string password = "phaw iiow kxfh nyku";
                string host = "smtp.gmail.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(email, to, subject, body))
                {
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient(host, port))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(email, password);
                        smtp.Send(mail);
                        MessageBox.Show("Email Verified. Please Check Your Email for your One Time Code.", "Success");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
            }


        }

        private void checkUserEmailContent()
        {
            if (userEmail.Text == "")
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

        private void userEmail_TextChanged(object sender, EventArgs e)
        {
            checkUserEmailContent();
        }


    }
}
