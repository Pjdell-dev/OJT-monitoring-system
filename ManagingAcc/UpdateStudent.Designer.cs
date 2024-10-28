namespace OjtCoordinator
{
    partial class UpdateStudent
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
            lblUpdateStudent = new Label();
            tbStudentID = new TextBox();
            tbFirstName = new TextBox();
            tbContactNo = new TextBox();
            tbSupervisorID = new TextBox();
            tbLastName = new TextBox();
            btnUpdateStudent = new Button();
            SuspendLayout();
            // 
            // lblUpdateStudent
            // 
            lblUpdateStudent.AutoSize = true;
            lblUpdateStudent.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateStudent.ForeColor = Color.White;
            lblUpdateStudent.Location = new Point(291, 25);
            lblUpdateStudent.Name = "lblUpdateStudent";
            lblUpdateStudent.Size = new Size(202, 32);
            lblUpdateStudent.TabIndex = 1;
            lblUpdateStudent.Text = "Update Students";
            // 
            // tbStudentID
            // 
            tbStudentID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbStudentID.Location = new Point(206, 117);
            tbStudentID.Name = "tbStudentID";
            tbStudentID.PlaceholderText = "ID#";
            tbStudentID.Size = new Size(157, 27);
            tbStudentID.TabIndex = 2;
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFirstName.Location = new Point(206, 175);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.PlaceholderText = "First Name";
            tbFirstName.Size = new Size(157, 27);
            tbFirstName.TabIndex = 3;
            // 
            // tbContactNo
            // 
            tbContactNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbContactNo.Location = new Point(206, 234);
            tbContactNo.Name = "tbContactNo";
            tbContactNo.PlaceholderText = "Contact No#";
            tbContactNo.Size = new Size(157, 27);
            tbContactNo.TabIndex = 4;
            // 
            // tbSupervisorID
            // 
            tbSupervisorID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupervisorID.Location = new Point(206, 290);
            tbSupervisorID.Name = "tbSupervisorID";
            tbSupervisorID.PlaceholderText = "Supervisor ID";
            tbSupervisorID.Size = new Size(157, 27);
            tbSupervisorID.TabIndex = 5;
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbLastName.Location = new Point(431, 175);
            tbLastName.Name = "tbLastName";
            tbLastName.PlaceholderText = "LastName";
            tbLastName.Size = new Size(157, 27);
            tbLastName.TabIndex = 6;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStudent.ForeColor = Color.FromArgb(0, 64, 0);
            btnUpdateStudent.Location = new Point(341, 335);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(138, 43);
            btnUpdateStudent.TabIndex = 7;
            btnUpdateStudent.Text = "Update ";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // UpdateStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateStudent);
            Controls.Add(tbLastName);
            Controls.Add(tbSupervisorID);
            Controls.Add(tbContactNo);
            Controls.Add(tbFirstName);
            Controls.Add(tbStudentID);
            Controls.Add(lblUpdateStudent);
            Name = "UpdateStudent";
            Text = "UpdateStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateStudent;
        private TextBox tbFirstName;
        private TextBox tbContactNo;
        private TextBox tbSupervisorID;
        private Button btnUpdateStudent;
        public TextBox tbStudentID;
        public TextBox tbLastName;
    }
}