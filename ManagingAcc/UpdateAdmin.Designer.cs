namespace OjtCoordinator
{
    partial class UpdateAdmin
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
            tbAdminID = new TextBox();
            tbadmnFirstName = new TextBox();
            tbadmnContactNo = new TextBox();
            tbadmnLastName = new TextBox();
            btnUpdateAdmin = new Button();
            SuspendLayout();
            // 
            // lblUpdateSupervisor
            // 
            lblUpdateSupervisor.AutoSize = true;
            lblUpdateSupervisor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateSupervisor.ForeColor = Color.White;
            lblUpdateSupervisor.Location = new Point(264, 20);
            lblUpdateSupervisor.Name = "lblUpdateSupervisor";
            lblUpdateSupervisor.Size = new Size(179, 32);
            lblUpdateSupervisor.TabIndex = 3;
            lblUpdateSupervisor.Text = "Update Admin";
            // 
            // tbAdminID
            // 
            tbAdminID.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAdminID.Location = new Point(169, 109);
            tbAdminID.Name = "tbAdminID";
            tbAdminID.PlaceholderText = "ID#";
            tbAdminID.Size = new Size(157, 27);
            tbAdminID.TabIndex = 4;
            // 
            // tbadmnFirstName
            // 
            tbadmnFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbadmnFirstName.Location = new Point(169, 163);
            tbadmnFirstName.Name = "tbadmnFirstName";
            tbadmnFirstName.PlaceholderText = "First Name";
            tbadmnFirstName.Size = new Size(157, 27);
            tbadmnFirstName.TabIndex = 5;
            // 
            // tbadmnContactNo
            // 
            tbadmnContactNo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbadmnContactNo.Location = new Point(169, 219);
            tbadmnContactNo.Name = "tbadmnContactNo";
            tbadmnContactNo.PlaceholderText = "Contact No#";
            tbadmnContactNo.Size = new Size(157, 27);
            tbadmnContactNo.TabIndex = 6;
            // 
            // tbadmnLastName
            // 
            tbadmnLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbadmnLastName.Location = new Point(398, 163);
            tbadmnLastName.Name = "tbadmnLastName";
            tbadmnLastName.PlaceholderText = "LastName";
            tbadmnLastName.Size = new Size(157, 27);
            tbadmnLastName.TabIndex = 8;
            // 
            // btnUpdateAdmin
            // 
            btnUpdateAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAdmin.ForeColor = Color.FromArgb(0, 64, 0);
            btnUpdateAdmin.Location = new Point(316, 279);
            btnUpdateAdmin.Name = "btnUpdateAdmin";
            btnUpdateAdmin.Size = new Size(138, 43);
            btnUpdateAdmin.TabIndex = 9;
            btnUpdateAdmin.Text = "Update ";
            btnUpdateAdmin.UseVisualStyleBackColor = true;
            // 
            // UpdateAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 95, 52);
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateAdmin);
            Controls.Add(tbadmnLastName);
            Controls.Add(tbadmnContactNo);
            Controls.Add(tbadmnFirstName);
            Controls.Add(tbAdminID);
            Controls.Add(lblUpdateSupervisor);
            Name = "UpdateAdmin";
            Text = "UpdateAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUpdateSupervisor;
        private Button btnUpdateAdmin;
        public TextBox tbAdminID;
        public TextBox tbadmnLastName;
        public TextBox tbadmnFirstName;
        public TextBox tbadmnContactNo;
    }
}