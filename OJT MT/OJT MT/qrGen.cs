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

        private void btnGenerateTimeIn_Click(object sender, EventArgs e)
        {
            int length = 15;
            String textGen = RandomString(length);
            txtQR.Text = textGen;

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtQR.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }

        private void btnGenerateTimeOut_Click(object sender, EventArgs e)
        {
            int length = 15;
            String textGen = RandomString(length);
            txtQR.Text = textGen;

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(txtQR.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox1.Image = code.GetGraphic(50);
        }
    }
}
