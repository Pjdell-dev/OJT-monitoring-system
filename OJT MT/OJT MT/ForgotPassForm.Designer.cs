namespace OJT_MT
{
    partial class ForgotPassForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            userEmail = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            SubmitButton = new Button();
            CancelButton = new Button();
            forgotPass = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxUser = new TextBox();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(12, 64, 41);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1200, 788);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(228, 230, 228);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(forgotPass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxUser);
            panel1.Location = new Point(60, 90);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 638);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(userEmail, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 74.23424F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7657642F));
            tableLayoutPanel2.Size = new Size(1077, 638);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // userEmail
            // 
            userEmail.Anchor = AnchorStyles.None;
            userEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userEmail.Location = new Point(321, 457);
            userEmail.Name = "userEmail";
            userEmail.PlaceholderText = "Enter Email";
            userEmail.Size = new Size(435, 33);
            userEmail.TabIndex = 9;
            userEmail.TextChanged += userEmail_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.ojt_2_logo;
            pictureBox1.Location = new Point(344, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 399);
            label5.Name = "label5";
            label5.Size = new Size(1071, 50);
            label5.TabIndex = 8;
            label5.Text = "Please Enter Your Email:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 136F));
            tableLayoutPanel3.Controls.Add(SubmitButton, 0, 0);
            tableLayoutPanel3.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel3.Location = new Point(406, 502);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(264, 133);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.None;
            SubmitButton.BackColor = Color.FromArgb(12, 64, 41);
            SubmitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(15, 47);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(106, 39);
            SubmitButton.TabIndex = 10;
            SubmitButton.Text = "SUBMIT";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.None;
            CancelButton.BackColor = Color.Red;
            CancelButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = SystemColors.ButtonHighlight;
            CancelButton.Location = new Point(151, 47);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(106, 39);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "CANCEL";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // forgotPass
            // 
            forgotPass.Anchor = AnchorStyles.Bottom;
            forgotPass.AutoSize = true;
            forgotPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            forgotPass.Location = new Point(747, 1067);
            forgotPass.Name = "forgotPass";
            forgotPass.Size = new Size(117, 17);
            forgotPass.TabIndex = 7;
            forgotPass.Text = "Forgot Password?";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(747, 991);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(747, 908);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(688, 845);
            label1.Name = "label1";
            label1.Size = new Size(358, 36);
            label1.TabIndex = 4;
            label1.Text = "TUA OJT MONITORING";
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.Bottom;
            buttonLogin.BackColor = Color.FromArgb(21, 115, 74);
            buttonLogin.FlatAppearance.BorderColor = Color.Black;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.FromArgb(244, 244, 239);
            buttonLogin.Location = new Point(814, 1120);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(90, 38);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "LOG IN";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Bottom;
            textBoxPassword.BackColor = Color.FromArgb(254, 255, 250);
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(747, 1019);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Enter Password";
            textBoxPassword.Size = new Size(227, 26);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Bottom;
            textBoxUser.BackColor = Color.FromArgb(254, 255, 250);
            textBoxUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUser.Location = new Point(747, 936);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Enter Email";
            textBoxUser.Size = new Size(227, 26);
            textBoxUser.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(53, 0);
            label4.Name = "label4";
            label4.Size = new Size(1094, 80);
            label4.TabIndex = 1;
            label4.Text = "Forgot Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ForgotPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 64, 41);
            ClientSize = new Size(1200, 788);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ForgotPassForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label forgotPass;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private Label label4;
        private Label label5;
        private Button SubmitButton;
        private TextBox userEmail;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CancelButton;
    }
}