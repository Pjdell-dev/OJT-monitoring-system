﻿namespace OJT_MT
{
    partial class StudentEvaluationForm
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            labelContactNumber = new Label();
            labelStudentID = new Label();
            labelContactNumber_Label = new Label();
            labelStudentID_Label = new Label();
            labelName = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(123, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 331);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(12, 64, 41);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(panel3, 2, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(123, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(554, 84);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(334, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(217, 78);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(labelContactNumber);
            panel2.Controls.Add(labelStudentID);
            panel2.Controls.Add(labelContactNumber_Label);
            panel2.Controls.Add(labelStudentID_Label);
            panel2.Controls.Add(labelName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(113, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 78);
            panel2.TabIndex = 0;
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactNumber.ForeColor = SystemColors.ButtonHighlight;
            labelContactNumber.Location = new Point(100, 45);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(79, 16);
            labelContactNumber.TabIndex = 4;
            labelContactNumber.Text = "placeholder";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentID.ForeColor = SystemColors.ButtonHighlight;
            labelStudentID.Location = new Point(100, 26);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(79, 16);
            labelStudentID.TabIndex = 3;
            labelStudentID.Text = "placeholder";
            // 
            // labelContactNumber_Label
            // 
            labelContactNumber_Label.AutoSize = true;
            labelContactNumber_Label.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContactNumber_Label.ForeColor = SystemColors.ButtonHighlight;
            labelContactNumber_Label.Location = new Point(3, 45);
            labelContactNumber_Label.Name = "labelContactNumber_Label";
            labelContactNumber_Label.Size = new Size(91, 16);
            labelContactNumber_Label.TabIndex = 2;
            labelContactNumber_Label.Text = "Contact No.:";
            // 
            // labelStudentID_Label
            // 
            labelStudentID_Label.AutoSize = true;
            labelStudentID_Label.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentID_Label.ForeColor = SystemColors.ButtonHighlight;
            labelStudentID_Label.Location = new Point(3, 26);
            labelStudentID_Label.Name = "labelStudentID_Label";
            labelStudentID_Label.Size = new Size(82, 16);
            labelStudentID_Label.TabIndex = 1;
            labelStudentID_Label.Text = "Student ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(3, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(106, 24);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.icon_default;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // StudentEvaluationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentEvaluationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentEvaluationForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Label labelName;
        private Label labelStudentID_Label;
        private Label labelContactNumber_Label;
        private PictureBox pictureBox1;
        private Label labelContactNumber;
        private Label labelStudentID;
    }
}