﻿using Microsoft.VisualBasic.ApplicationServices;
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

                string query = @"
                    SELECT 
                        time_in.date AS 'Date', 
                        time_in.time_in AS 'Time In', 
                        COALESCE(time_out.time_out, '00:00:00') AS 'Time Out', 
                        IF(time_out.time_out IS NOT NULL, 
                           TIMEDIFF(time_out.time_out, time_in.time_in), 
                           '00:00:00') AS 'Total Hours'
                    FROM 
                        time_in 
                    LEFT JOIN 
                        time_out 
                    ON 
                        time_in.date = time_out.date 
                        AND time_in.student_id = time_out.student_id
                    WHERE 
                        time_in.student_id = @student_id
                    ORDER BY time_in.date ASC;";

                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", _studentId));
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;

                // Get contact number and student number
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
                string query = "SELECT first_name, last_name, student_id, contact_number, pfPic FROM students WHERE student_id = @student_id;";
                using var reader = await dbHelper.ExecuteReaderAsync(query, new MySqlParameter("@student_id", _studentId));
                if (await reader.ReadAsync())
                {
                    labelStudentID.Text = reader["student_id"].ToString();
                    labelContactNumber.Text = reader["contact_number"]?.ToString() ?? string.Empty;
                    labelName.Text = $"{reader["first_name"]} {reader["last_name"]}";
                    byte[] picString = reader["pfPic"] as byte[];

                    System.Drawing.Image pfp = OurCustomUtils.LongBlobToImage(picString);
                    pictureBox1.Image = pfp;


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

            Image ojt_logo = Properties.Resources.CEIS;
            e.Graphics.DrawImage(ojt_logo, 645, y, 130, 130);


            Image tua_logo = Properties.Resources.TUA;
            e.Graphics.DrawImage(tua_logo, 80, y + 3, 130, 130);

            e.Graphics.DrawString("TRINITY UNIVERSITY OF ASIA", fontTitle, Brushes.Black, 280, y += 40);
            e.Graphics.DrawString("OJT MONITORING", fontSubTitle, Brushes.Black, 340, y += 40);
            e.Graphics.DrawString("TIME LOG REPORT", fontTitle, Brushes.Black, 320, y += 80);

            Image pfPic = pictureBox1.Image;
            e.Graphics.DrawImage(pfPic, 175, y + 35, 120, 120);
            e.Graphics.DrawString("Name: " + labelName.Text, fontTitle, Brushes.Black, 320, y += 60);
            e.Graphics.DrawString("Student ID: " + labelStudentID.Text, fontRegular, Brushes.Black, 320, y += 25);
            e.Graphics.DrawString("Contact #: " + labelContactNumber.Text, fontRegular, Brushes.Black, 320, y += 25);

            y += 75;
            int tableX = 100;
            int tableWidth = 600;
            int rowHeight = 30;
            int[] columnWidths = { 150, 150, 150, 150 };

            e.Graphics.DrawRectangle(Pens.Black, tableX, y, tableWidth, rowHeight);
            e.Graphics.DrawString("Date", fontRegular, Brushes.Black, tableX + 5, y + 5);
            e.Graphics.DrawString("Time In", fontRegular, Brushes.Black, tableX + columnWidths[0] + 5, y + 5);
            e.Graphics.DrawString("Time Out", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + 5, y + 5);
            e.Graphics.DrawString("Total Hours", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2] + 5, y + 5);

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
                e.Graphics.DrawString(row.Cells["Total Hours"].Value?.ToString() ?? "", fontRegular, Brushes.Black, tableX + columnWidths[0] + columnWidths[1] + columnWidths[2] + 5, y + 5);

                y += rowHeight;
            }


            // Initialize totalTime as TimeSpan
            TimeSpan totalTime = TimeSpan.Zero;

            // Display the label for total hours
            e.Graphics.DrawString("Total Hours Accumulated: ", fontRegular, Brushes.Black, tableX, y + 50 + rowHeight);

            // Loop through DataGridView rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Skip the new row placeholder
                if (row.IsNewRow) continue;

                // Check and log the value of the "Total Hours" cell
                var cellValue = row.Cells["Total Hours"].Value?.ToString();
                Console.WriteLine($"Row {row.Index} - Cell Value: {cellValue}");

                // Parse and accumulate hours if valid
                if (TimeSpan.TryParse(cellValue, out TimeSpan time))
                {
                    totalTime = totalTime.Add(time); // Accumulate time
                    Console.WriteLine($"Accumulated Time: {totalTime}");
                }
                else
                {
                    Console.WriteLine($"Failed to parse value for row {row.Index}");
                }
            }

            // Draw the total accumulated time as hours
            string totalTimeText = $"{totalTime.TotalHours:F2}";
            e.Graphics.DrawString(totalTimeText + "  Hours", fontRegular, Brushes.Black, tableX + 250, y + 50 + rowHeight);
        }

        private void printTimeButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printTimeDocument;
            printPreviewDialog1.ShowDialog();
        }

    }
}