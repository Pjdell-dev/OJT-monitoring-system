using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OJT_MT
{
    public partial class qrGen : Form
    {
        MainForm _mainForm;
        private string _accountType;
        private int? _selectedSupervisorId = null;
        private bool _isEmailValid = false;
        private bool _isPasswordValid = false;

        public qrGen(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }


        private static Random random = new Random();

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private async void btnGenerateTimeIn_Click(object sender, EventArgs e)
        {
            int supervisor_id = await LoadSupID();
            int length = 15;

            string textGen = RandomString(length);
            string accountID = _mainForm.accountID;//ginamit na dito ang session
            txtQR.Text = textGen;

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtQR.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);

            string insertQuery = "INSERT INTO time_in (supervisor_id, qr_string) VALUES (@supervisor_id, @textGen)";
            using (var dbHelper = new DatabaseHelper())
            {

                var parameters = new MySqlParameter[]
                {
                   new MySqlParameter("@supervisor_id", supervisor_id),
                   new MySqlParameter("@textGen",textGen)
                };
                await dbHelper.ExecuteNonQueryAsync(insertQuery, parameters);
                MessageBox.Show("QR Code Generated!");

           
            }
        }

        private async void btnGenerateTimeOut_Click(object sender, EventArgs e)
        {
            string accountID = _mainForm.accountID;
            int supervisor_id = await LoadSupID();
            int length = 15;
            string textGen = RandomString(length);
            //ginamit na dito ang session
            txtQR.Text = textGen;

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtQR.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);

            string insertQuery = "INSERT INTO time_out (supervisor_id, qr_string) VALUES (@supervisor_id, @textGen )";
            using (var dbHelper = new DatabaseHelper())
            {

                var parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@supervisor_id", supervisor_id),
                   new MySqlParameter("@textGen",textGen),
    
                };


                await dbHelper.ExecuteNonQueryAsync(insertQuery, parameters);
                MessageBox.Show("QR Code Generated!"); 

               
             
               
            }
        }

        private async Task<int> LoadSupID()
        {
            string accountID = _mainForm.accountID;
            using var dbHelper = new DatabaseHelper();
            string idQuery = "SELECT supervisor_id FROM supervisors WHERE user_id = @accountID";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@accountID", accountID)
            };

            using var reader = await dbHelper.ExecuteReaderAsync(idQuery, parameters);

            if (await reader.ReadAsync())
            {
                return reader.GetInt32("supervisor_id");
            }

            throw new Exception("Supervisor ID not found.");

        }
    }
}
