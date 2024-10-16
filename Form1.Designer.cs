namespace OJT_Monitoring
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            logInUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            logInpassword = new TextBox();
            submit = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(175, 49);
            label1.Name = "label1";
            label1.Size = new Size(458, 39);
            label1.TabIndex = 0;
            label1.Text = "TUA OJT Monitoring System";
            // 
            // username
            // 
            logInUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInUsername.Location = new Point(239, 164);
            logInUsername.Name = "username";
            logInUsername.Size = new Size(328, 29);
            logInUsername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(239, 127);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 2;
            label2.Text = "USERNAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(239, 220);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD";
            // 
            // password
            // 
            logInpassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInpassword.Location = new Point(239, 248);
            logInpassword.Name = "password";
            logInpassword.PasswordChar = '*';
            logInpassword.Size = new Size(328, 29);
            logInpassword.TabIndex = 4;
            // 
            // button1
            // 
            submit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submit.Location = new Point(331, 326);
            submit.Name = "button1";
            submit.Size = new Size(154, 39);
            submit.TabIndex = 5;
            submit.Text = "SUBMIT";
            submit.UseVisualStyleBackColor = true;
            submit.Click += button1_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 93, 43);
            ClientSize = new Size(800, 438);
            Controls.Add(submit);
            Controls.Add(logInpassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add((Control)logInUsername);
            Controls.Add(label1);
            Name = "LogIn";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox logInpassword;
        private Button submit;
        private BindingSource bindingSource1;
        private TextBox logInUsername;
    }
}
