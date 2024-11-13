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

namespace OJT_MT
{ 

    public partial class OJT_Home : Form
    {
        MainForm _mainform;

        public OJT_Home(MainForm mainform)
        {
            this._mainform = mainform;
            InitializeComponent();
            loadHomeAsync();
            
        }

        public async Task loadHomeAsync()
        {
            string accountType = _mainform.accountType; //syntax to call session data
            string accountID = _mainform.accountID;     //syntax to call session data
            using var dbHelper = new DatabaseHelper();

            if (accountType == "admin")
            {
                String dbQuery = "SELECT first_name FROM administrators WHERE user_id = " + accountID;

                using var reader = await dbHelper.ExecuteReaderAsync(dbQuery);

                if (reader.Read())
                {
                    String firstName = reader.GetString("first_name");

                    welcomeLabel.Text = "Welcome " + firstName + "!";
                }
            }

            else if (accountType == "supervisor")
            {
                String dbQuery = "SELECT first_name FROM supervisors WHERE user_id = " + accountID;

                using var reader = await dbHelper.ExecuteReaderAsync(dbQuery);

                if (reader.Read())
                {
                    String firstName = reader.GetString("first_name");

                    welcomeLabel.Text = "Welcome " + firstName + "!";
                }
            }
        }
    }
}
