namespace OJT_Monitoring
{
    partial class Register
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
            label1 = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            btnRegister = new Button();
            label2 = new Label();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            cmbAccountType = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbID = new TextBox();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(327, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 45);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(446, 250);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(212, 23);
            tbEmail.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(446, 297);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(212, 23);
            tbPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(539, 396);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(119, 32);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 116);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(446, 161);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(212, 23);
            tbFirstName.TabIndex = 6;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(446, 208);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(212, 23);
            tbLastName.TabIndex = 7;
            // 
            // cmbAccountType
            // 
            cmbAccountType.FormattingEnabled = true;
            cmbAccountType.Items.AddRange(new object[] { "Student", "Supervisor", "Coordinator" });
            cmbAccountType.Location = new Point(484, 116);
            cmbAccountType.Name = "cmbAccountType";
            cmbAccountType.Size = new Size(121, 23);
            cmbAccountType.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(327, 161);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 9;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(330, 208);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 10;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(365, 250);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(327, 297);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 12;
            label6.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(321, 116);
            label7.Name = "label7";
            label7.Size = new Size(113, 21);
            label7.TabIndex = 13;
            label7.Text = "Account Type";
            // 
            // tbID
            // 
            tbID.Location = new Point(446, 339);
            tbID.Name = "tbID";
            tbID.PasswordChar = '*';
            tbID.Size = new Size(212, 23);
            tbID.TabIndex = 14;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(337, 339);
            label9.Name = "label9";
            label9.Size = new Size(32, 25);
            label9.TabIndex = 15;
            label9.Text = "ID";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 93, 43);
            ClientSize = new Size(804, 513);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(tbID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbAccountType);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button btnRegister;
        private Label label2;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private ComboBox cmbAccountType;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbID;
        private Label label8;
        private Label label9;
    }
}