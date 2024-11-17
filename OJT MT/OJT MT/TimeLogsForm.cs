using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT_MT
{
    public partial class TimeLogsForm : Form
    {
        private MainForm _mainForm;
        private int _studentId;
        private PrintDocument printTimeDocument;
        private PrintPreviewDialog printPreviewDialog1;
        public TimeLogsForm(MainForm mainForm, int studentId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _studentId = studentId;


            printTimeDocument = new PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog
            {
                Document = printTimeDocument,
                Width = 800,
                Height = 600
            };

            // Attach PrintPage event
            printTimeDocument.PrintPage += printTimeDocument_PrintPage;

        }
        private async void TimeLogsForm_Load(object sender, EventArgs e)
        {
            await LoadStudentTimeLogs(); //Display logs for selected student on form load
        }
        public async Task LoadStudentTimeLogs()
        {
            try
            {
                using var dbHelper = new DatabaseHelper();

                string query = "SELECT date AS 'Date', time_in AS 'Time In', time_out AS 'Time Out', status AS 'Remarks' FROM time_logs WHERE student_id = @student_id;";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", _studentId));
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;

                //Get contact number and student number
                await LoadStudentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async Task LoadStudentInfo()
        {
            try
            {
                using var dbHelper = new DatabaseHelper();
                string query = "SELECT first_name, last_name, student_id, contact_number FROM students WHERE student_id = @student_id;";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", _studentId));
                if (await reader.ReadAsync())
                {
                    labelStudentID.Text = reader["student_id"].ToString();
                    labelContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                    labelName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void printTimeDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fontTitle = new Font("Times New Roman", 14, FontStyle.Bold);
            Font fontSubTitle = new Font("Times New Roman", 14, FontStyle.Bold);
            Font fontRegular = new Font("Times New Roman", 14, FontStyle.Bold);
            int y = 20;

            Image ojt_logo = Properties.Resources.ojt_2_logo;
            e.Graphics.DrawImage(ojt_logo, 645, y, 150, 150);


            Image tua_logo = Properties.Resources.TUA;
            e.Graphics.DrawImage(tua_logo, 80, y + 3, 130, 130);


            e.Graphics.DrawString("TRINITY UNIVERSITY OF ASIA", fontTitle, Brushes.Black, 280, y += 40);
            e.Graphics.DrawString("OJT MONITORING", fontSubTitle, Brushes.Black, 340, y += 40);
            e.Graphics.DrawString("TIME LOG REPORT", fontTitle, Brushes.Black, 320, y += 100);

            e.Graphics.DrawString("Name: " + labelName.Text, fontTitle, Brushes.Black, 300, y += 60);
            e.Graphics.DrawString("Student ID: " + labelStudentID.Text, fontRegular, Brushes.Black, 300, y += 45);
            e.Graphics.DrawString("Contact #: " + labelContactNumber.Text, fontRegular, Brushes.Black, 300, y += 45);

            y += 75;
            int tableX = 100;
            int tableWidth = 600;
            int rowHeight = 30;
            int[] columnWidths = { 150, 150, 150, 150 };

            e.Graphics.DrawRectangle(Pens.Black, tableX, y, tableWidth, rowHeight);
            e.Graphics.DrawString("Date", fontRegular, Brushes.Black, tableX + 5, y + 5);
            e.Graphics.DrawString("Time In", fontRegular, Brushes.Black, tableX + columnWidths[0] + 5, y + 5);
            e.Graphics.DrawString("Time Out", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + 5, y + 5);
            e.Graphics.DrawString("Remarks", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2] + 5, y + 5);

            y += rowHeight;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawRectangle(Pens.Black, tableX, y, tableWidth, rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, tableX, y, columnWidths[0], rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, tableX + columnWidths[0], y, columnWidths[1], rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, tableX + columnWidths[0] + columnWidths[1], y, columnWidths[2], rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2], y, columnWidths[3], rowHeight);

                e.Graphics.DrawString(Convert.ToDateTime(row.Cells["Date"].Value).ToString("yyyy-MM-dd"), fontRegular, Brushes.Black, tableX + 5, y + 5);
                e.Graphics.DrawString(row.Cells["Time In"].Value?.ToString() ?? "", fontRegular, Brushes.Black, tableX + columnWidths[0] + 5, y + 5);
                e.Graphics.DrawString(row.Cells["Time Out"].Value?.ToString() ?? "", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + 5, y + 5);
                e.Graphics.DrawString(row.Cells["Remarks"].Value?.ToString() ?? "", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2] + 5, y + 5);

                y += rowHeight;
            }


        }

        private void printTimeButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printTimeDocument;
            printPreviewDialog1.ShowDialog();
        }


    }
}