using Microsoft.VisualBasic.ApplicationServices;
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

namespace OJT_MT
{
    public partial class TimeLogsForm : Form
    {
        private MainForm _mainForm;
        private int _studentId;
        public TimeLogsForm(MainForm mainForm, int studentId)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _studentId = studentId;

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

    }
}
