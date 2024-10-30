namespace OjtCoordinator
{
    partial class UpdateSupervisor
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
            lblUpdateSupervisor = new Label();
            tbSupID = new TextBox();
            tbSupFirstName = new TextBox();
            tbSupContactNo = new TextBox();
            tbSupCompany = new TextBox();
            tbSupLastName = new TextBox();
            btnUpdateSupervisor = new Button();
            SuspendLayout();
            // 
            // lblUpdateSupervisor
            // 
            lblUpdateSupervisor.AutoSize = true;
            lblUpdateSupervisor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateSupervisor.ForeColor = Color.White;
            lblUpdateSupervisor.Location = new Point(296, 21);
            lblUpdateSupervisor.Name = "lblUpdateSupervisor";
            lblUpdateSupervisor.Size = new Size(226, 32);
            lblUpdateSupervisor.TabIndex = 2;
            lblUpdateSupervisor.Text = "Update Supervisor";
            // 
            // tbSupID
            // 
            tbSupID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupID.Location = new Point(167, 117);
            tbSupID.Name = "tbSupID";
            tbSupID.PlaceholderText = "ID#";
            tbSupID.Size = new Size(157, 27);
            tbSupID.TabIndex = 3;
            // 
            // tbSupFirstName
            // 
            tbSupFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupFirstName.Location = new Point(167, 170);
            tbSupFirstName.Name = "tbSupFirstName";
            tbSupFirstName.PlaceholderText = "First Name";
            tbSupFirstName.Size = new Size(157, 27);
            tbSupFirstName.TabIndex = 4;
            // 
            // tbSupContactNo
            // 
            tbSupContactNo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupContactNo.Location = new Point(167, 223);
            tbSupContactNo.Name = "tbSupContactNo";
            tbSupContactNo.PlaceholderText = "Contact No#";
            tbSupContactNo.Size = new Size(157, 27);
            tbSupContactNo.TabIndex = 5;
            // 
            // tbSupCompany
            // 
            tbSupCompany.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupCompany.Location = new Point(167, 275);
            tbSupCompany.Name = "tbSupCompany";
            tbSupCompany.PlaceholderText = "Company";
            tbSupCompany.Size = new Size(157, 27);
            tbSupCompany.TabIndex = 6;
            // 
            // tbSupLastName
            // 
            tbSupLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSupLastName.Location = new Point(385, 170);
            tbSupLastName.Name = "tbSupLastName";
            tbSupLastName.PlaceholderText = "LastName";
            tbSupLastName.Size = new Size(157, 27);
            tbSupLastName.TabIndex = 7;
            // 
            // btnUpdateSupervisor
            // 
            btnUpdateSupervisor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSupervisor.ForeColor = Color.FromArgb(0, 64, 0);
            btnUpdateSupervisor.Location = new Point(318, 330);
            btnUpdateSupervisor.Name = "btnUpdateSupervisor";
            btnUpdateSupervisor.Size = new Size(138, 43);
            btnUpdateSupervisor.TabIndex = 8;
            btnUpdateSupervisor.Text = "Update ";
            btnUpdateSupervisor.UseVisualStyleBackColor = true;
            // 
            // UpdateSupervisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateSupervisor);
            Controls.Add(tbSupLastName);
            Controls.Add(tbSupCompany);
            Controls.Add(tbSupContactNo);
            Controls.Add(tbSupFirstName);
            Controls.Add(tbSupID);
            Controls.Add(lblUpdateSupervisor);
            Name = "UpdateSupervisor";
            Text = "UpdateSupervisor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateSupervisor;
        private Button btnUpdateSupervisor;
        public TextBox tbSupID;
        public TextBox tbSupFirstName;
        public TextBox tbSupContactNo;
        public TextBox tbSupCompany;
        public TextBox tbSupLastName;
    }
}