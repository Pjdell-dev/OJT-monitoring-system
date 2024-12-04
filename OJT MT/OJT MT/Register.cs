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
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace OJT_MT
{
    public partial class Register : Form
    {
        MainForm _mainForm;
        private string _accountType;
        private int? _selectedSupervisorId = null;
        private bool _isEmailValid = false;
        private bool _isPasswordValid = false;
        private string password;
        public Register(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            tableLayoutPanelRegister.RowStyles[1].Height = 0F;
            tableLayoutPanelRegister.RowStyles[2].Height = 0F;


            //Subscribing to events para sa passwords -> passwordstextchanged and sa information textboxes -> information textboxes textchanged
            textBoxPassword.TextChanged += PasswordsText_TextChanged;
            textBoxConfirmPassword.TextChanged += PasswordsText_TextChanged;

            textBoxIdNumber.TextChanged += InformationTextboxes_TextChanged;
            textBoxFirstName.TextChanged += InformationTextboxes_TextChanged;
            textBoxLastName.TextChanged += InformationTextboxes_TextChanged;
            textBoxContactNumber.TextChanged += InformationTextboxes_TextChanged;
            textBoxCompany.TextChanged += InformationTextboxes_TextChanged;

            ToggleButton(buttonSubmit, false);

            //Create password eye for password textboxes
            OurCustomUtils.CreatePasswordEye(
                textBoxPassword, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
                );
            OurCustomUtils.CreatePasswordEye(
                textBoxConfirmPassword, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
                );
        }

        private async void comboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e) //Change selected item event sa account type
        {

            if (comboBoxAccountType.SelectedIndex == -1)
            {
                tableLayoutPanelRegister.RowStyles[1].Height = 50F;
                tableLayoutPanelRegister.RowStyles[2].Height = 50F;
                return;
            }
            ClearInformation();
            _accountType = comboBoxAccountType.SelectedItem?.ToString() ?? string.Empty; //Put account type into variable
            switch (_accountType)
            {
                case "Student":
                    await LoadSupervisorsToCombobox();
                    tableLayoutPanelRegister.RowStyles[1].Height = 300F;
                    panelSupervisor.Show();
                    panelCompany.Hide();
                    panelSupervisor.Location = new Point(54, 146);
                    break;
                case "Supervisor":
                    tableLayoutPanelRegister.RowStyles[1].Height = 300F;
                    panelSupervisor.Hide();
                    panelCompany.Show();
                    break;
                case "Administrator":
                    tableLayoutPanelRegister.RowStyles[1].Height = 300F;
                    panelSupervisor.Hide();
                    panelCompany.Hide();
                    break;
                default: return;
            }
            tableLayoutPanelRegister.RowStyles[2].Height = 305F;
        }

        private void ClearInformation()
        {
            textBoxIdNumber.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNumber.Text = "";
            textBoxCompany.Text = "";

            comboBoxSupervisor.Items.Clear();
            comboBoxSupervisor.SelectedIndex = -1;

            textBoxEmail.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
        }

        private async Task LoadSupervisorsToCombobox() //Function lang to load supervisors into combobox (for students para di na ttype yung ID pipili nalang)
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = @"SELECT supervisor_id, first_name, last_name FROM supervisors";
                using var reader = await dbHelper.ExecuteReaderAsync(query);
                var supervisorItems = new List<string>();
                while (reader.Read())
                {
                    string item = $"{reader["supervisor_id"]} - {reader["first_name"]} {reader["last_name"]}";
                    supervisorItems.Add(item);
                }

                comboBoxSupervisor.Items.AddRange(supervisorItems.ToArray());
                comboBoxSupervisor.SelectedIndex = -1; //Default to no selection
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonSubmit_Click(object sender, EventArgs e) //Submit button event - click -
        {
            using var dbHelper = new DatabaseHelper();


            //Start a transaction para marevert natin if mag fail yung isang query            
            if (!int.TryParse(textBoxIdNumber.Text, out int idNumber))
            {
                MessageBox.Show("Please enter a valid ID number");
                return;
            }

            string pfPic; //profile pic

            string userQuery;
            MySqlParameter[] userParameters;
            string accountQuery = null;
            MySqlParameter[] accountParameters = null;


            string accountType;
            switch (_accountType)
            {
                case "Student":
                    pfPic = pfPicBase64(pictureBoxUserImage.Image);
                    accountType = "student";
                    accountQuery = @"INSERT INTO Students (student_id,first_name,last_name,contact_number,supervisor_id,user_id, pfPic) VALUES (@IDNumber, @FirstName, @LastName, @ContactNumber, @SupervisorId, @UserId, @pfPic)";
                    accountParameters = new MySqlParameter[]
                    {
                                new MySqlParameter("@IDNumber",  idNumber),
                                new MySqlParameter("@FirstName", textBoxFirstName.Text),
                                new MySqlParameter("@LastName", textBoxLastName.Text),
                                new MySqlParameter("@ContactNumber", textBoxContactNumber.Text),
                                new MySqlParameter("@SupervisorId", _selectedSupervisorId),
                                new MySqlParameter("@pfPic", pfPic), //profile pic insertion
                                new MySqlParameter("@UserId", 0), // Placeholder for user ID 
                    };
                    break;
                case "Supervisor":
                    pfPic = pfPicBase64(pictureBoxUserImage.Image);
                    accountType = "supervisor";
                    accountQuery = @"INSERT INTO supervisors (supervisor_id,first_name,last_name,contact_number,company,user_id, pfPic) VALUES (@IDNumber, @FirstName, @LastName, @ContactNumber,@Company, @UserId, @pfPic)";
                    accountParameters = new MySqlParameter[]
                    {
                                new MySqlParameter("@IDNumber",  idNumber),
                                new MySqlParameter("@FirstName", textBoxFirstName.Text),
                                new MySqlParameter("@LastName", textBoxLastName.Text),
                                new MySqlParameter("@ContactNumber", textBoxContactNumber.Text),
                                new MySqlParameter("@Company", textBoxCompany.Text),
                                new MySqlParameter("@pfPic", pfPic), //profile pic insertion
                                new MySqlParameter("@UserId", 0), // Placeholder for user ID
                    };
                    break;
                case "Administrator":
                    pfPic = pfPicBase64(pictureBoxUserImage.Image);
                    accountType = "admin";
                    accountQuery = @"INSERT INTO administrators (admin_id,first_name,last_name,contact_number,user_id, pfPic) VALUES (@IDNumber, @FirstName, @LastName, @ContactNumber, @UserId, @pfPic)";
                    accountParameters = new MySqlParameter[]
                    {
                                new MySqlParameter("@IDNumber",  idNumber),
                                new MySqlParameter("@FirstName", textBoxFirstName.Text),
                                new MySqlParameter("@LastName", textBoxLastName.Text),
                                new MySqlParameter("@ContactNumber", textBoxContactNumber.Text),
                                new MySqlParameter("@pfPic", pfPic), //profile pic insertion
                                new MySqlParameter("@UserId", 0), // Placeholder for user ID
                    };
                    break;
                default: return;
            }

            string passHash = OurCustomUtils.PassHash(textBoxPassword.Text);
            userQuery = @"INSERT INTO users (user_email, account_type, user_password) VALUES (@Email, @AccountType, @Password)";
            userParameters = new MySqlParameter[]
            {
                        new MySqlParameter("@Email", textBoxEmail.Text),
                        new MySqlParameter("@AccountType", accountType),
                        new MySqlParameter("@Password", passHash)
            };

            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to add new user with the following information?",
                "Confirm Add User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (dialogResult == DialogResult.No) return;
            using var connection = await dbHelper.GetConnectionAsync();
            using var transaction = await connection.BeginTransactionAsync();
            try
            {
                using var userCommand = new MySqlCommand(userQuery, connection, transaction);
                userCommand.Parameters.AddRange(userParameters);
                //Insert new user
                await userCommand.ExecuteNonQueryAsync();

                //Get user id of new user
                string lastIdQuery = "SELECT LAST_INSERT_ID()";
                using var lastIdCommand = new MySqlCommand(lastIdQuery, connection, transaction);
                var lastId = await lastIdCommand.ExecuteScalarAsync();
                int userId = Convert.ToInt32(lastId);

                accountParameters[^1] = new MySqlParameter("@UserId", userId); //Set user ID in student parameters
                using var accountCommand = new MySqlCommand(accountQuery, connection, transaction);
                accountCommand.Parameters.AddRange(accountParameters);
                await accountCommand.ExecuteNonQueryAsync();

                //Commit the transaction if all inserts are successful
                await transaction.CommitAsync();

                MessageBox.Show("New user registered successfully");
                SendEmail();
                this.Close();
                _mainForm.LoginUser(_mainForm.accountType, _mainForm.accountID);
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxSupervisor_SelectedIndexChanged(object sender, EventArgs e) //Event for combobox supervisor -index changed- save into variable lang yung selected supervisor ID
        {
            CheckDetails();
            if (comboBoxSupervisor.SelectedIndex == -1)
            {
                _selectedSupervisorId = null;
                return;
            }

            var selectedItem = comboBoxSupervisor.SelectedItem;
            if (selectedItem != null)
            {
                string selectedValue = selectedItem.ToString() ?? string.Empty;

                //Kunin yung number before hyphen, or take the whole string if no hyphen exists

                int hyphenIndex = selectedValue.IndexOf('-');
                if (hyphenIndex != -1)
                {
                    //Extract the part before the hyphen
                    _selectedSupervisorId = Convert.ToInt32(selectedValue.Substring(0, hyphenIndex).Trim());
                }
                else
                {
                    //If no hyphen, take the whole string
                    _selectedSupervisorId = Convert.ToInt32(selectedValue.Trim());
                }
            }

        }
        private void PasswordsText_TextChanged(object? sender, EventArgs e)  //event for textchanged sa passwords - checking lang if valid na yung passwords (currently as long as matching yung 2)
        {
            if (sender == null) return;
            labelPasswordUpdatedMessage.Hide();
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                labelPasswordError.Hide();
                _isPasswordValid = false;

            }
            else if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                labelPasswordError.Hide();
                _isPasswordValid = true;
            }
            else
            {
                labelPasswordError.Show();
                _isPasswordValid = false;
            }
            CheckDetails();
        }

        private void InformationTextboxes_TextChanged(object? sender, EventArgs e)
        {
            CheckDetails();
        }

        private void ToggleButton(Button button, bool enable)
        {
            button.BackColor = enable ? Color.FromArgb(21, 115, 74) : Color.Transparent;
            button.FlatAppearance.BorderSize = enable ? 0 : 1;
            button.ForeColor = enable ? Color.FromArgb(244, 244, 239) : Color.FromArgb(96, 94, 92);
            button.Enabled = enable;
        }

        private async void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox == null) return;
            string text = textBox.Text;
            string errorMsg = "";
            bool isEmailValid = true;

            try
            {
                //Check if the text is empty or whitespace
                if (string.IsNullOrWhiteSpace(text))
                {
                    errorMsg = "";
                    isEmailValid = false;
                }
                else if (!OurCustomUtils.IsValidEmail(text))
                {
                    //Check if valid email
                    errorMsg = "Must be a valid Email";
                    isEmailValid = false;
                }
                else
                {
                    //Check if the email already exists in the database
                    var dbHelper = new DatabaseHelper();
                    string query = "SELECT COUNT(*) FROM users WHERE user_email = @email";
                    var result = await dbHelper.ExecuteScalarAsync(query, new MySqlParameter("@email", text));
                    isEmailValid = Convert.ToInt32(result) == 0;
                    errorMsg = isEmailValid ? "" : "Email already exists";
                }
                _isEmailValid = isEmailValid;
                labelEmailError.Text = errorMsg;
                labelEmailError.Visible = !string.IsNullOrWhiteSpace(errorMsg);
                CheckDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckDetails() //Code to run para check if may valid na yung details sa lahat if yes, enable button, otherwise disable
        {
            bool enableButton = true;


            //Check if email and password are valid
            if (!_isEmailValid || !_isPasswordValid)
            {
                enableButton = false;
                ToggleButton(buttonSubmit, enableButton);
                return; //Return na agad if hindi valid either
            }

            //Info into variables
            string idNumber = textBoxIdNumber.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string contactNo = textBoxContactNumber.Text;
            string company = textBoxCompany.Text;


            //Check if may info na lahat ng textboxes
            if (string.IsNullOrWhiteSpace(idNumber) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(contactNo))
            {
                enableButton = false;
                ToggleButton(buttonSubmit, enableButton);
                return;
            }

            if (_accountType == "Student")
            {
                if (comboBoxSupervisor.SelectedIndex == -1) //No selection in comboBox
                {
                    enableButton = false;
                }
            }

            if (_accountType == "Supervisor")
            {
                if (string.IsNullOrWhiteSpace(company))
                {
                    enableButton = false;
                }
            }
            ToggleButton(buttonSubmit, enableButton); //Enable or Disable button depende sa results
        }

        private void textBoxIdNumber_KeyPress(object sender, KeyPressEventArgs e) //keypress event for the ID textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //pigilan if di control type or numbers
            }
        }

        private void SendEmail()
        {
            //email inputs
            string to = textBoxEmail.Text;
            string subject = "Successful Registration to TUA OJT MONITORING";
            string body = $@"
                            <p>Dear {textBoxFirstName.Text} {textBoxLastName.Text},</p>
                            <p>Welcome to the <b>TUA OJT Monitoring System</b>!</p>
                            <p>Here are your login credentials:</p>
                            <ul>
                                <li><b>Username:</b> {textBoxEmail.Text}</li>
                                <li><b>Password:</b> {textBoxPassword.Text}</li>
                            </ul>
                            <p>We’re excited to have you on board. Please log in to explore the platform and ensure your information is up to date. If you have any questions or need assistance, feel free to reach out to us.</p>
                            <br>
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
                        MessageBox.Show("Email sent successfully.", "Success");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error");
            }


        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog{
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Select an Image"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUserImage.Image = new Bitmap(openFileDialog1.FileName); // Preview the image
            }
        }

        private string pfPicBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
        
    }


}
