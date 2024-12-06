namespace OJT_MT
{
    partial class qrGen
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
            pictureBox1 = new PictureBox();
            txtQR = new TextBox();
            btnGenerateTimeIN = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnGenerateTimeOut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(51, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtQR
            // 
            txtQR.Enabled = false;
            txtQR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQR.Location = new Point(51, 396);
            txtQR.Name = "txtQR";
            txtQR.Size = new Size(350, 29);
            txtQR.TabIndex = 1;
            txtQR.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerateTimeIN
            // 
            btnGenerateTimeIN.BackColor = Color.FromArgb(12, 64, 41);
            btnGenerateTimeIN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateTimeIN.ForeColor = Color.White;
            btnGenerateTimeIN.Location = new Point(786, 144);
            btnGenerateTimeIN.Name = "btnGenerateTimeIN";
            btnGenerateTimeIN.Size = new Size(126, 55);
            btnGenerateTimeIN.TabIndex = 2;
            btnGenerateTimeIN.Text = "TIME IN";
            btnGenerateTimeIN.UseVisualStyleBackColor = false;
            btnGenerateTimeIN.Click += btnGenerateTimeIn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(12, 64, 41);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Location = new Point(-1, -1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
            tableLayoutPanel1.Size = new Size(1311, 716);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(53, 0);
            label1.Name = "label1";
            label1.Size = new Size(1205, 114);
            label1.TabIndex = 0;
            label1.Text = "Intern Attendance Generate QR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 230, 228);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnGenerateTimeOut);
            panel1.Controls.Add(btnGenerateTimeIN);
            panel1.Location = new Point(53, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(1205, 531);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 64, 41);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(txtQR);
            panel2.Location = new Point(245, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 450);
            panel2.TabIndex = 4;
            // 
            // btnGenerateTimeOut
            // 
            btnGenerateTimeOut.BackColor = Color.FromArgb(12, 64, 41);
            btnGenerateTimeOut.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateTimeOut.ForeColor = Color.White;
            btnGenerateTimeOut.Location = new Point(786, 245);
            btnGenerateTimeOut.Name = "btnGenerateTimeOut";
            btnGenerateTimeOut.Size = new Size(126, 55);
            btnGenerateTimeOut.TabIndex = 3;
            btnGenerateTimeOut.Text = "TIME OUT";
            btnGenerateTimeOut.UseVisualStyleBackColor = false;
            btnGenerateTimeOut.Click += btnGenerateTimeOut_Click;
            // 
            // qrGen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 714);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "qrGen";
            Text = "qrGen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtQR;
        private Button btnGenerateTimeIN;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Button btnGenerateTimeOut;
        private Panel panel2;
    }
}