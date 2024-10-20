using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OJT_Monitoring
{
    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data;
    using System.Data.Common;

    public partial class Register : Form
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

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dbConn.Open();
            string AccountType = "";

            if (cmbAccountType.SelectedItem.ToString() == "Student")
            {
                AccountType = "Student";
            }
            else if (cmbAccountType.SelectedItem.ToString() == "Supervisor")
            {
                AccountType = "Student";
            }
            else if (cmbAccountType.SelectedItem.ToString() == "Coordinator")
            {
                AccountType = "Student";
            }


            string dbQuery = "INSERT INTO `admin` " +
             "(`firstname`, `lastname`, `username`, `password`, `account_type`, `id`) VALUES " +
             "('" + tbFirstName.Text + "', '" + tbLastName.Text + "', '" + tbEmail.Text + "', '" + tbPassword.Text + "' ,'" + cmbAccountType.Text + "'  , '" + tbID.Text + "')";
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn); // commands from c# to MySQL




            dbCmd.Parameters.AddWithValue("@username", tbFirstName.Text);
            dbCmd.Parameters.AddWithValue("@lastname", tbLastName.Text);
            dbCmd.Parameters.AddWithValue("@Email", tbEmail.Text);
            dbCmd.Parameters.AddWithValue("@password", tbPassword.Text);
            dbCmd.Parameters.AddWithValue("@accounttype", cmbAccountType.Text);
            dbCmd.Parameters.AddWithValue("@id", tbID.Text);
            
                dbCmd.ExecuteNonQuery();

                MessageBox.Show("Registered!");

            

            
                dbConn.Close();
            



        }
       

     
    }
}
