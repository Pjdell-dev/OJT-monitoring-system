namespace OJT_Monitoring
{
    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data;
    using System.Data.Common;

    public partial class LogIn : Form
    {
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "ojt";

        MySqlConnection dbConn = new MySqlConnection(
            "server=" + server + ";" +
            "port=" + port + ";" +
            "username=" + username + ";" +
            "password=" + password + ";" +
            "database=" + database + ";");

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbConn.Open();

                string dbQuery = "SELECT * FROM admin WHERE username = @username AND password = @password"; // actual SQL
                MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL

                dbCmd.Parameters.AddWithValue("@username", logInUsername.Text);
                dbCmd.Parameters.AddWithValue("@password", logInpassword.Text);
                MySqlDataReader dbReader = dbCmd.ExecuteReader(); // to fetch the data from database

                if (dbReader.Read())
                {
                    String userName = dbReader.GetString("username");
                    String password = dbReader.GetString("password");
                    String accountType = dbReader.GetString("account_type");

                    if (accountType == "Admin")
                    {
                        MessageBox.Show("Login Succcessfully");
                        this.Hide();
                        string LoggedUsername = logInUsername.Text;

                        Form2 form2 = new Form2();
                        form2.Show();
                    }

                    if (accountType == "Supervisor")
                    {
                        MessageBox.Show("Login Succcessfully");
                        this.Hide();
                        string LoggedUsername = logInUsername.Text;

                        Form3 form3 = new Form3();
                        form3.Show();
                    }

                    if (accountType == "Coordinator")
                    {
                        MessageBox.Show("Login Succcessfully");
                        this.Hide();
                        string LoggedUsername = logInUsername.Text;

                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                }

                else
                {
                    MessageBox.Show("Invalid.");
                    clearItems();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            
            dbConn.Close();
        }

        private void clearItems()
        {
            logInUsername.Clear();
            logInpassword.Clear();
        }
    }
}