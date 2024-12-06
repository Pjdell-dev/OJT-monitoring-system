namespace OJT_MT
{
    partial class ChangePassForm
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
            label4 = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            label7 = new Label();
            enterOTC = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            confirmNewPass = new TextBox();
            label6 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            enterNewPass = new TextBox();
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
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(label8, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1200, 788);
            tableLayoutPanel1.TabIndex = 5;
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
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel2.Location = new Point(53, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.88889F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.333334F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.7777786F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 182F));
            tableLayoutPanel2.Size = new Size(977, 635);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(971, 121);
            label4.TabIndex = 1;
            label4.Text = "Reset Password";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 337F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel6.Controls.Add(label7, 0, 0);
            tableLayoutPanel6.Controls.Add(enterOTC, 1, 0);
            tableLayoutPanel6.Location = new Point(144, 327);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(689, 120);
            tableLayoutPanel6.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(331, 120);
            label7.TabIndex = 8;
            label7.Text = "Enter One Time Code:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // enterOTC
            // 
            enterOTC.Anchor = AnchorStyles.None;
            enterOTC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterOTC.Location = new Point(377, 47);
            enterOTC.MaxLength = 6;
            enterOTC.Name = "enterOTC";
            enterOTC.PlaceholderText = "Enter One Time Code";
            enterOTC.Size = new Size(272, 26);
            enterOTC.TabIndex = 14;
            enterOTC.TextChanged += enterOTC_TextChanged;
            enterOTC.KeyPress += enterOTC_KeyPress;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel5.Controls.Add(confirmNewPass, 1, 0);
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Location = new Point(145, 229);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(687, 92);
            tableLayoutPanel5.TabIndex = 14;
            // 
            // confirmNewPass
            // 
            confirmNewPass.Anchor = AnchorStyles.None;
            confirmNewPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmNewPass.Location = new Point(376, 33);
            confirmNewPass.Name = "confirmNewPass";
            confirmNewPass.PlaceholderText = "Confirm New Password";
            confirmNewPass.Size = new Size(271, 26);
            confirmNewPass.TabIndex = 14;
            confirmNewPass.TextChanged += confirmNewPass_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(330, 92);
            label6.TabIndex = 8;
            label6.Text = "Confirm New Password:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 336F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
            tableLayoutPanel4.Controls.Add(enterNewPass, 1, 0);
            tableLayoutPanel4.Controls.Add(label5, 0, 0);
            tableLayoutPanel4.Location = new Point(145, 124);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(687, 99);
            tableLayoutPanel4.TabIndex = 13;
            // 
            // enterNewPass
            // 
            enterNewPass.Anchor = AnchorStyles.None;
            enterNewPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enterNewPass.Location = new Point(376, 36);
            enterNewPass.Name = "enterNewPass";
            enterNewPass.PlaceholderText = "Enter New Password";
            enterNewPass.Size = new Size(271, 26);
            enterNewPass.TabIndex = 14;
            enterNewPass.TextChanged += enterNewPass_TextChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(330, 99);
            label5.TabIndex = 8;
            label5.Text = "Enter New Password:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tableLayoutPanel3.Controls.Add(SubmitButton, 0, 0);
            tableLayoutPanel3.Controls.Add(CancelButton, 1, 0);
            tableLayoutPanel3.Location = new Point(356, 453);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(264, 179);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.None;
            SubmitButton.BackColor = Color.FromArgb(12, 64, 41);
            SubmitButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = SystemColors.ButtonHighlight;
            SubmitButton.Location = new Point(13, 70);
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
            CancelButton.Location = new Point(149, 70);
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
            forgotPass.Location = new Point(1187, 1605);
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
            label3.Location = new Point(1187, 1529);
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
            label2.Location = new Point(1187, 1446);
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
            label1.Location = new Point(1128, 1383);
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
            buttonLogin.Location = new Point(1254, 1658);
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
            textBoxPassword.Location = new Point(1187, 1557);
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
            textBoxUser.Location = new Point(1187, 1474);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Enter Email";
            textBoxUser.Size = new Size(227, 26);
            textBoxUser.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(53, 0);
            label8.Name = "label8";
            label8.Size = new Size(1094, 80);
            label8.TabIndex = 2;
            label8.Text = "TUA OJT MONITORING";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 788);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassForm";
            Text = "ChangePassForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private Button SubmitButton;
        private Button CancelButton;
        private Label forgotPass;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxUser;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox enterOTC;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox confirmNewPass;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox enterNewPass;
        private Label label8;
    }
}