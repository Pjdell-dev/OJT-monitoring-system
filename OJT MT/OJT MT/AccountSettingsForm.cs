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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OJT_MT
{
    public partial class AccountSettingsForm : Form
    {
        MainForm mainForm;
        private string _userID;
        private string _accountType;
        public AccountSettingsForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            _userID = mainForm.accountID;
            _accountType = mainForm.accountType;
            LoadAccountDetails();

            //Create password eye for password textboxes
            OurCustomUtils.CreatePasswordEye(
                textBoxCurrentPassword, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
                );
            OurCustomUtils.CreatePasswordEye(
                textBoxNewPassword, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
                );
            OurCustomUtils.CreatePasswordEye(
                textBoxConfirmNewPassword, iconPwShown: Properties.Resources.eyesolid, iconPwHidden: Properties.Resources.eyesolid_crossed
                );

            ToggleButton(buttonSaveEmail, false);
            ToggleButton(buttonUpdatePassword, false);
            textBoxNewPassword.TextChanged += PasswordsTextChanged; //Register the password type texboxes' text changed event
            textBoxConfirmNewPassword.TextChanged += PasswordsTextChanged;
            textBoxCurrentPassword.TextChanged += PasswordsTextChanged;
        }

        private async void LoadAccountDetails()
        {
            UploadPicButton.BringToFront();

            var dbHelper = new DatabaseHelper();
            string? query = null;
            switch (_accountType)
            {
                case "student":
                    query = @"SELECT student_number AS idNumber, last_name, first_name, contact_number, company, pfPic FROM students WHERE user_id = @user_id";
                    break;
                case "supervisor":
                    query = @"
                            SELECT 
                                s.supervisor_id AS idNumber,
                                s.last_name, s.first_name,
                                s.contact_number,
                                s.company,
                                s.pfPic,
                                u.user_email
                            FROM 
                                supervisors s
                            JOIN 
                                users u ON s.user_id = u.user_id
                            WHERE
                                s.user_id = @user_id";
                    label6.Visible = true;
                    labelCompany.Visible = true;
                    break;
                case "admin":
                    query = @"
                            SELECT 
                                s.admin_id AS idNumber,
                                s.last_name, s.first_name,
                                s.contact_number,
                                s.pfPic,
                                u.user_email
                            FROM 
                                administrators s
                            JOIN 
                                users u ON s.user_id = u.user_id
                            WHERE
                                s.user_id = @user_id";
                    label6.Visible = false;
                    labelCompany.Visible = false;
                    break;
                default: return;
            }
            try
            {
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@user_id", _userID));
                if (reader.Read())
                {
                    labelAccountType.Text = char.ToUpper(_accountType[0]) + _accountType[1..];
                    labelIDNumber.Text = reader["idNumber"].ToString();
                    labelName.Text = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    labelContactNumber.Text = reader["contact_number"].ToString();

                    string picString = reader["pfPic"].ToString();
                    System.Drawing.Image pfp = Base64toImage(picString);
                    pictureBoxUserImage.Image = pfp;

                    if (_accountType == "supervisor")
                    {
                        labelCompany.Text = reader["company"].ToString();
                    }

                    textBoxEmail.PlaceholderText = OurCustomUtils.MaskEmail(reader["user_email"]?.ToString() ?? string.Empty);
                }
            }
            catch (Exception ex)
            {

            }

        }


        private async void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            TextBox? textBox = sender as TextBox;
            if (textBox == null) return;
            string text = textBox.Text;
            string errorMsg = "";
            bool enableSaveButton = true;

            try
            {
                //Check if the text is empty or whitespace
                if (string.IsNullOrWhiteSpace(text))
                {
                    errorMsg = "";
                    enableSaveButton = false;
                }
                else if (!OurCustomUtils.IsValidEmail(text))
                {
                    //Check if valid email
                    errorMsg = "Must be a valid Email";
                    enableSaveButton = false;
                }
                else
                {
                    //Check if the email already exists in the database
                    var dbHelper = new DatabaseHelper();
                    string query = "SELECT COUNT(*) FROM users WHERE user_email = @email";
                    var result = await dbHelper.ExecuteScalarAsync(query, new MySqlParameter("@email", text));
                    enableSaveButton = Convert.ToInt32(result) == 0;
                    errorMsg = enableSaveButton ? "" : "Email already exists";
                }
                //Update button and error label
                labelEmailError.Text = errorMsg;
                labelEmailError.Visible = !string.IsNullOrWhiteSpace(errorMsg);
                ToggleButton(buttonSaveEmail, enableSaveButton);
                labelEmailUpdatedSuccessMessage.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void PasswordsTextChanged(object? sender, EventArgs e)
        {
            if (sender == null) return;
            labelPasswordUpdatedMessage.Hide();
            bool enableSaveButton = false;
            if (string.IsNullOrWhiteSpace(textBoxNewPassword.Text) && string.IsNullOrWhiteSpace(textBoxConfirmNewPassword.Text))
            {
                labelNewPasswordError.Hide();
                enableSaveButton = false;
            }
            else if (textBoxNewPassword.Text == textBoxConfirmNewPassword.Text)
            {
                if (!string.IsNullOrWhiteSpace(textBoxCurrentPassword.Text))
                {
                    labelNewPasswordError.Hide();
                    enableSaveButton = true;
                }

            }
            else
            {
                labelNewPasswordError.Show();
            }
            ToggleButton(buttonUpdatePassword, enableSaveButton);
        }

        private void ToggleButton(Button button, bool enable)
        {
            button.BackColor = enable ? Color.FromArgb(21, 115, 74) : Color.Transparent;
            button.FlatAppearance.BorderSize = enable ? 0 : 1;
            button.ForeColor = enable ? Color.FromArgb(244, 244, 239) : Color.FromArgb(96, 94, 92);
            button.Enabled = enable;
        }

        private async void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = textBoxCurrentPassword.Text;
            var dbHelper = new DatabaseHelper();
            if (await dbHelper.IsPasswordCorrectAsync(_userID, currentPassword)) //Check if current password is correct
            {
                if (currentPassword == textBoxNewPassword.Text)//Check if current password is the same as new password
                {
                    labelCurrentPasswordError.Text = "New password must be different"; //Display error
                    labelCurrentPasswordError.Show();
                }
                else //Else update password 
                {
                    string newPassword = textBoxNewPassword.Text;
                    string query = @"UPDATE users SET user_password = @password WHERE user_id =@userID";
                    if (await dbHelper.ExecuteNonQueryAsync(query, new MySqlParameter("@password", newPassword), new MySqlParameter("@userID", _userID)) == 1)
                    {
                        labelCurrentPasswordError.Hide();
                        textBoxCurrentPassword.Text = "";
                        textBoxNewPassword.Text = "";
                        textBoxConfirmNewPassword.Text = "";
                        labelPasswordUpdatedMessage.Show();
                        this.ActiveControl = null;
                    }


                }
            }
            else //If not correct show invalid password
            {
                labelCurrentPasswordError.Text = "Current password incorrect";
                labelCurrentPasswordError.Show();
            }
        }

        private async void buttonSaveEmail_Click(object sender, EventArgs e)
        {
            string newEmail = textBoxEmail.Text;
            var dbHelper = new DatabaseHelper();
            string query = @"UPDATE users SET user_email = @email WHERE user_id =@userID";
            if (await dbHelper.ExecuteNonQueryAsync(query, new MySqlParameter("@email", newEmail), new MySqlParameter("@userID", _userID)) == 1)
            {
                labelEmailError.Hide();
                textBoxEmail.Text = "";
                textBoxEmail.PlaceholderText = OurCustomUtils.MaskEmail(newEmail.ToString());
                labelEmailUpdatedSuccessMessage.Show();
                this.ActiveControl = null;
            }
        }

        private void UploadPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png",
                Title = "Select an Image"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUserImage.Image = new Bitmap(openFileDialog1.FileName); // Preview the image
                SaveImage.BringToFront();
                UploadPicButton.SendToBack();
            }
        }

        private async void SaveImage_ClickAsync(object sender, EventArgs e)
        {
            var dbHelper = new DatabaseHelper();
            string queryPfp;
            string newPfp = pfPicBase64(pictureBoxUserImage.Image);

            switch (_accountType)
            {
                case "student":
                    queryPfp = @"UPDATE students SET pfPic = @newPfp WHERE  user_id = @userID";

                    if (await dbHelper.ExecuteNonQueryAsync(queryPfp, new MySqlParameter("@newPfp", newPfp), new MySqlParameter("@userID", _userID)) == 1)
                    {
                        MessageBox.Show("Profile Picture Updated Successfully");
                        this.LoadAccountDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update profile picture.");
                    }
                    break;

                case "supervisor":
                    queryPfp = @"UPDATE supervisors SET pfPic = @newPfp WHERE  user_id = @userID";

                    if (await dbHelper.ExecuteNonQueryAsync(queryPfp, new MySqlParameter("@newPfp", newPfp), new MySqlParameter("@userID", _userID)) == 1)
                    {
                        MessageBox.Show("Profile Picture Updated Successfully");
                        this.LoadAccountDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update profile picture.");
                    }
                    break;

                case "admin":
                    queryPfp = @"UPDATE administrators SET pfPic = @newPfp WHERE  user_id = @userID";

                    if (await dbHelper.ExecuteNonQueryAsync(queryPfp, new MySqlParameter("@newPfp", newPfp), new MySqlParameter("@userID", _userID)) == 1)
                    {
                        MessageBox.Show("Profile Picture Updated Successfully");
                        this.LoadAccountDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update profile picture.");
                    }
                    break;

                default:
                    MessageBox.Show("Invalid account type.");
                    return;
            }

        }

        private string pfPicBase64(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Use a consistent format
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
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
