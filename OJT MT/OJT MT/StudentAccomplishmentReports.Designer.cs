namespace OJT_MT
{
    partial class StudentAccomplishmentReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel2 = new Panel();
            labelContactNumber = new Label();
            labelStudentID = new Label();
            labelContactNumberIndicator = new Label();
            labelStudentIDIndicator = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.FromArgb(12, 64, 41);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.Size = new Size(1222, 664);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(217, 218, 214);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 255, 250);
            dataGridViewCellStyle1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(50, 49, 48);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(161, 213, 190);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(50, 49, 48);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(103, 123);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1016, 470);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.375F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.625F));
            tableLayoutPanel3.Controls.Add(panel2, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(100, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(1022, 120);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelContactNumber);
            panel2.Controls.Add(labelStudentID);
            panel2.Controls.Add(labelContactNumberIndicator);
            panel2.Controls.Add(labelStudentIDIndicator);
            panel2.Controls.Add(labelName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(130, 10);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 108);
            panel2.TabIndex = 0;
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Poppins", 9F);
            labelContactNumber.ForeColor = SystemColors.ButtonFace;
            labelContactNumber.Location = new Point(110, 64);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(81, 22);
            labelContactNumber.TabIndex = 4;
            labelContactNumber.Text = "placeholder";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Poppins", 9F);
            labelStudentID.ForeColor = SystemColors.ButtonFace;
            labelStudentID.Location = new Point(110, 45);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(81, 22);
            labelStudentID.TabIndex = 3;
            labelStudentID.Text = "placeholder";
            // 
            // labelContactNumberIndicator
            // 
            labelContactNumberIndicator.AutoSize = true;
            labelContactNumberIndicator.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            labelContactNumberIndicator.ForeColor = SystemColors.ButtonHighlight;
            labelContactNumberIndicator.Location = new Point(3, 63);
            labelContactNumberIndicator.Name = "labelContactNumberIndicator";
            labelContactNumberIndicator.Size = new Size(101, 23);
            labelContactNumberIndicator.TabIndex = 2;
            labelContactNumberIndicator.Text = "Contact No.:";
            // 
            // labelStudentIDIndicator
            // 
            labelStudentIDIndicator.AutoSize = true;
            labelStudentIDIndicator.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            labelStudentIDIndicator.ForeColor = SystemColors.ButtonHighlight;
            labelStudentIDIndicator.Location = new Point(9, 44);
            labelStudentIDIndicator.Name = "labelStudentIDIndicator";
            labelStudentIDIndicator.Size = new Size(90, 23);
            labelStudentIDIndicator.TabIndex = 1;
            labelStudentIDIndicator.Text = "Student ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Poppins SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(3, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(112, 34);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_default;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // StudentAccomplishmentReports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 664);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentAccomplishmentReports";
            Text = "StudentAccomplishmentReports";
            Load += StudentAccomplishmentReports_Load;
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private Label labelContactNumber;
        private Label labelStudentID;
        private Label labelContactNumberIndicator;
        private Label labelStudentIDIndicator;
        private Label labelName;
        private PictureBox pictureBox1;
    }
}