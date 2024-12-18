using MySqlConnector;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Cryptography;
namespace OJT_MT
{

    public partial class LoginPageForm : Form
    {
        private MainForm _mainForm;
        public LoginPageForm(MainForm mainForm)
        {
            InitializeComponent();
            this._mainForm = mainForm;
            OurCustomUtils.CreatePasswordEye(textBoxPassword);
        }


        //Login Button Click

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text; //Get username (email)
            string password = textBoxPassword.Text; //Get password
            try
            {

                var userInfo = await ValidateUserAsync(username, password); //Retrieve userid and account type if login details match
                if (userInfo.HasValue)
                {
                    string accountType = userInfo.Value.Item1; // Get account type
                    string userId = userInfo.Value.Item2; // Get user ID

                    _mainForm.LoginUser(accountType, userId);
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch
            {

            }
        }
        //hash login validation
        private async Task<(string, string)?> ValidateUserAsync(string username, string password)
        {
            try
            {
                string passHash = OurCustomUtils.PassHash(password);
                using var dbHelper = new DatabaseHelper();
                string query = "SELECT user_id, account_type FROM users WHERE user_email=@username AND user_password=@password";

                var parameters = new[]
                {
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", passHash)
            };
                using var reader = await dbHelper.ExecuteReaderAsync(query, parameters);


                if (reader.Read())
                {
                    string accountType = reader["account_type"].ToString() ?? string.Empty;
                    string userId = reader["user_id"]?.ToString() ?? string.Empty;


                    return (accountType, userId);

                }

                else
                    return null; //Return null if no valid result is found
            }
            catch
            {

            }
            return null; //Return null if no valid result is found
        }

        private void forgotPass_MouseHover(object sender, EventArgs e)
        {
            forgotPass.ForeColor = Color.Blue;
        }

        private void forgotPass_MouseLeave(object sender, EventArgs e)
        {
            forgotPass.ForeColor = Color.Black;
        }

        private void forgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassForm forgotPass = new ForgotPassForm(_mainForm);
            _mainForm.LoadForm(forgotPass);
        }
    }
}
