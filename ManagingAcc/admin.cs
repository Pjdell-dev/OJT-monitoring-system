using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OjtCoordinator
{
    using Microsoft.VisualBasic.ApplicationServices;
    using MySql.Data.MySqlClient; // Do not forget this part
    using Org.BouncyCastle.Crypto.Engines;
    using System.Data.Common;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class admin : Form
    {
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "tua_ojt_monitoring(1)";

        MySqlConnection dbConn = new MySqlConnection(
            "server=" + server + ";" +
            "port=" + port + ";" +
            "username=" + username + ";" +
            "password=" + password + ";" +
            "database=" + database + ";");
        private object lvRows;

        public admin()
        {
            InitializeComponent();

        }
        private List<ListViewItem> originalItems = new List<ListViewItem>(); //pangtemporary placeholder ng items for filtering
        private void Form1_Load(object sender, EventArgs e)
        {
            dbConn.Open();
            string dbQuery = "SELECT users.user_id, students.last_name AS students_lastname, supervisors.last_name AS supervisors_lastname, users.account_type  FROM users LEFT JOIN students ON users.user_id = students.user_id  LEFT JOIN supervisors ON users.user_id = supervisors.user_id ";
            // string dbQuery = "SELECT user_id, last_name, account_type FROM `users` ";
            MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn);

            MySqlDataReader dbReader = dbCmd.ExecuteReader();

            while (dbReader.Read())
            {
                ;

                ListViewItem lvRows = new ListViewItem(dbReader.GetInt32("user_id").ToString(), 0);
                // lvRows.SubItems.Add(dbReader.GetString("last_name"));
                string combinedLastNames = $"{dbReader["students_lastname"].ToString()}  {dbReader["supervisors_lastname"].ToString()}";//syntax combine ang 2 subitems (ALIAS in query) in 1 line
                lvRows.SubItems.Add(combinedLastNames);
                lvRows.SubItems.Add(dbReader.GetString("account_type"));

                lvUsers.Items.Add(lvRows);
                originalItems.Add((ListViewItem)lvRows.Clone());//lagay yung lvRows sa originalItems
            }
            dbReader.Close();
            dbConn.Close();

        }

        //filtering by, hinahiglight yung intended item
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = tbFilter.Text.ToLower();
            lvUsers.Items.Clear();

            foreach (ListViewItem item in originalItems)
            {
                if (item.Text.ToLower().Contains(filterText) || item.SubItems[1].Text.ToLower().Contains(filterText) || item.SubItems[2].Text.ToLower().Contains(filterText))
                {
                    item.BackColor = SystemColors.GrayText;
                    item.ForeColor = SystemColors.Window;
                    lvUsers.Items.Add((ListViewItem)item.Clone());//need para mashow yung filtered item sa listview
                }
                else
                {
                    item.BackColor = SystemColors.Control;
                }
            }
        }

        private void lvUsers_MouseClick(object sender, MouseEventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                string getID = lvUsers.SelectedItems[0].SubItems[0].Text;
                string getAccountType = lvUsers.SelectedItems[0].SubItems[2].Text;
                string getLastName = lvUsers.SelectedItems[0].SubItems[1].Text;
              

                tbID.Text = getID;
                tbLastName.Text = getLastName;
                tbAccountType.Text = getAccountType;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)//check if nageexist yung selected items
            {
                ListViewItem selectedItem = lvUsers.SelectedItems[0];

                string AccountType = lvUsers.SelectedItems[0].SubItems[2].Text;//fetch mo yung acctype sa listview

                //For panel use
                if (AccountType == "student")
                {
                    UpdateStudent updatestudent = new UpdateStudent() { TopLevel = false, TopMost = true };
                    updatestudent.FormBorderStyle = FormBorderStyle.None;
                    updatestudent.tbStudentID.Text = tbID.Text;
                    updatestudent.tbLastName.Text = tbLastName.Text;
                    pnlUpdate.Controls.Add(updatestudent);
                    updatestudent.Show();
               
              
                    pnlUpdate.Visible = true;

                  
                    
                }
                else if (AccountType == "supervisor")
                {
                    UpdateSupervisor updatesupervisor = new UpdateSupervisor() { TopLevel = false, TopMost = true };
                    updatesupervisor.FormBorderStyle = FormBorderStyle.None;
                    updatesupervisor.tbSupID.Text = tbID.Text;
                    updatesupervisor.tbSupLastName.Text = tbLastName.Text;
                    pnlUpdate.Controls.Add(updatesupervisor);
                    updatesupervisor.Show();
                    pnlUpdate.Visible = true;

                }
                else if (AccountType == "admin")
                {
                    UpdateAdmin updateadmin = new UpdateAdmin() { TopLevel = false, TopMost = true };
                    updateadmin.FormBorderStyle = FormBorderStyle.None;
                    updateadmin.tbAdminID.Text = tbID.Text;
                    updateadmin.tbadmnLastName.Text = tbLastName.Text;
                    pnlUpdate.Controls.Add(updateadmin);
                    updateadmin.Show();
                    pnlUpdate.Visible = true;

                }
                else
                {
                    MessageBox.Show("Invalid type", "Re-enter", MessageBoxButtons.YesNo);
                }

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)//DI PA MAAYOS DELETE
        {
            DialogResult result = MessageBox.Show("Are you sure you want to DELETE this student?", "Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                dbConn.Open();

                string dbQuery = "DELETE  FROM  users  WHERE user_id = '" + tbID.Text + "' ";
           
                MySqlCommand dbCmd = new MySqlCommand(dbQuery, dbConn);

                int queryStatus = dbCmd.ExecuteNonQuery();

                if (queryStatus > 0)
                {
                    MessageBox.Show("Removed Successfully");
                }else
                {
                    MessageBox.Show("Not Successful");
                }
                dbConn.Close();
            }
        }
    }
}
