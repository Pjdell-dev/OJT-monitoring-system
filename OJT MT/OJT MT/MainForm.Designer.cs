namespace OJT_MT
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            menuButton = new PictureBox();
            buttonHome = new Button();
            buttonInternList = new Button();
            buttonAccomplishmentReports = new Button();
            buttonAttendance = new Button();
            flowLayoutPanelManageUsers = new FlowLayoutPanel();
            buttonManageUsers = new Button();
            buttonUpdateUsers = new Button();
            buttonAddUser = new Button();
            genQR = new Button();
            buttonSettings = new Button();
            buttonQuestionList = new Button();
            buttonLogOut = new Button();
            mainPanel = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            manageUsersButtonTimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            flowLayoutPanelManageUsers.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(32, 31, 30);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(buttonHome);
            sidebar.Controls.Add(buttonInternList);
            sidebar.Controls.Add(buttonAccomplishmentReports);
            sidebar.Controls.Add(buttonAttendance);
            sidebar.Controls.Add(flowLayoutPanelManageUsers);
            sidebar.Controls.Add(genQR);
            sidebar.Controls.Add(buttonSettings);
            sidebar.Controls.Add(buttonQuestionList);
            sidebar.Controls.Add(buttonLogOut);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(255, 1080);
            sidebar.MinimumSize = new Size(60, 200);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(64, 749);
            sidebar.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(menuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 45);
            panel2.TabIndex = 1;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.Transparent;
            menuButton.Image = Properties.Resources.menu_burger1;
            menuButton.Location = new Point(19, 9);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(24, 24);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // buttonHome
            // 
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Microsoft Sans Serif", 12F);
            buttonHome.ForeColor = SystemColors.ButtonHighlight;
            buttonHome.Image = Properties.Resources.home1;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(0, 51);
            buttonHome.Margin = new Padding(0);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(15, 0, 0, 0);
            buttonHome.Size = new Size(253, 41);
            buttonHome.TabIndex = 4;
            buttonHome.Text = "            Home";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonInternList
            // 
            buttonInternList.FlatAppearance.BorderSize = 0;
            buttonInternList.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonInternList.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonInternList.FlatStyle = FlatStyle.Flat;
            buttonInternList.Font = new Font("Microsoft Sans Serif", 12F);
            buttonInternList.ForeColor = SystemColors.ButtonHighlight;
            buttonInternList.Image = Properties.Resources.member_list;
            buttonInternList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInternList.Location = new Point(0, 92);
            buttonInternList.Margin = new Padding(0);
            buttonInternList.Name = "buttonInternList";
            buttonInternList.Padding = new Padding(15, 0, 0, 0);
            buttonInternList.Size = new Size(252, 41);
            buttonInternList.TabIndex = 4;
            buttonInternList.Text = "            List of Interns";
            buttonInternList.TextAlign = ContentAlignment.MiddleLeft;
            buttonInternList.UseVisualStyleBackColor = true;
            buttonInternList.Click += buttonInternList_Click;
            // 
            // buttonAccomplishmentReports
            // 
            buttonAccomplishmentReports.FlatAppearance.BorderSize = 0;
            buttonAccomplishmentReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonAccomplishmentReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonAccomplishmentReports.FlatStyle = FlatStyle.Flat;
            buttonAccomplishmentReports.Font = new Font("Microsoft Sans Serif", 8F);
            buttonAccomplishmentReports.ForeColor = SystemColors.ButtonHighlight;
            buttonAccomplishmentReports.Location = new Point(0, 133);
            buttonAccomplishmentReports.Margin = new Padding(0);
            buttonAccomplishmentReports.Name = "buttonAccomplishmentReports";
            buttonAccomplishmentReports.Padding = new Padding(15, 0, 0, 0);
            buttonAccomplishmentReports.Size = new Size(252, 41);
            buttonAccomplishmentReports.TabIndex = 4;
            buttonAccomplishmentReports.Text = "                 Accomplishment Reports";
            buttonAccomplishmentReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonAccomplishmentReports.UseVisualStyleBackColor = true;
            buttonAccomplishmentReports.Click += buttonAccomplishmentReports_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.Font = new Font("Microsoft Sans Serif", 12F);
            buttonAttendance.ForeColor = SystemColors.ButtonHighlight;
            buttonAttendance.Location = new Point(0, 174);
            buttonAttendance.Margin = new Padding(0);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Padding = new Padding(15, 0, 0, 0);
            buttonAttendance.Size = new Size(252, 41);
            buttonAttendance.TabIndex = 4;
            buttonAttendance.Text = "            Attendance";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelManageUsers
            // 
            flowLayoutPanelManageUsers.Controls.Add(buttonManageUsers);
            flowLayoutPanelManageUsers.Controls.Add(buttonUpdateUsers);
            flowLayoutPanelManageUsers.Controls.Add(buttonAddUser);
            flowLayoutPanelManageUsers.Location = new Point(0, 215);
            flowLayoutPanelManageUsers.Margin = new Padding(0);
            flowLayoutPanelManageUsers.MaximumSize = new Size(0, 120);
            flowLayoutPanelManageUsers.MinimumSize = new Size(0, 40);
            flowLayoutPanelManageUsers.Name = "flowLayoutPanelManageUsers";
            flowLayoutPanelManageUsers.Size = new Size(301, 40);
            flowLayoutPanelManageUsers.TabIndex = 0;
            // 
            // buttonManageUsers
            // 
            buttonManageUsers.FlatAppearance.BorderSize = 0;
            buttonManageUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonManageUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonManageUsers.FlatStyle = FlatStyle.Flat;
            buttonManageUsers.Font = new Font("Microsoft Sans Serif", 12F);
            buttonManageUsers.ForeColor = SystemColors.ButtonHighlight;
            buttonManageUsers.Image = Properties.Resources.manage_accounts_icon;
            buttonManageUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonManageUsers.Location = new Point(0, 0);
            buttonManageUsers.Margin = new Padding(0);
            buttonManageUsers.Name = "buttonManageUsers";
            buttonManageUsers.Padding = new Padding(15, 0, 0, 0);
            buttonManageUsers.Size = new Size(252, 40);
            buttonManageUsers.TabIndex = 5;
            buttonManageUsers.Text = "            Manage Users";
            buttonManageUsers.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageUsers.UseVisualStyleBackColor = true;
            buttonManageUsers.Visible = false;
            buttonManageUsers.Click += buttonManageUsers_Click;
            // 
            // buttonUpdateUsers
            // 
            buttonUpdateUsers.FlatAppearance.BorderSize = 0;
            buttonUpdateUsers.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonUpdateUsers.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonUpdateUsers.FlatStyle = FlatStyle.Flat;
            buttonUpdateUsers.Font = new Font("Microsoft Sans Serif", 9.75F);
            buttonUpdateUsers.ForeColor = SystemColors.ButtonHighlight;
            buttonUpdateUsers.Image = Properties.Resources.user_pen;
            buttonUpdateUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUpdateUsers.Location = new Point(0, 40);
            buttonUpdateUsers.Margin = new Padding(0);
            buttonUpdateUsers.Name = "buttonUpdateUsers";
            buttonUpdateUsers.Padding = new Padding(58, 0, 0, 0);
            buttonUpdateUsers.Size = new Size(252, 40);
            buttonUpdateUsers.TabIndex = 6;
            buttonUpdateUsers.Text = "               Update Users";
            buttonUpdateUsers.TextAlign = ContentAlignment.MiddleLeft;
            buttonUpdateUsers.UseVisualStyleBackColor = true;
            buttonUpdateUsers.Click += buttonUpdateUsers_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.FlatAppearance.BorderSize = 0;
            buttonAddUser.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonAddUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonAddUser.FlatStyle = FlatStyle.Flat;
            buttonAddUser.Font = new Font("Microsoft Sans Serif", 9.75F);
            buttonAddUser.ForeColor = SystemColors.ButtonHighlight;
            buttonAddUser.Image = Properties.Resources.user_add_2;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(0, 80);
            buttonAddUser.Margin = new Padding(0);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Padding = new Padding(58, 0, 0, 0);
            buttonAddUser.Size = new Size(252, 40);
            buttonAddUser.TabIndex = 7;
            buttonAddUser.Text = "               Add User";
            buttonAddUser.TextAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // genQR
            // 
            genQR.FlatAppearance.BorderSize = 0;
            genQR.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            genQR.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            genQR.FlatStyle = FlatStyle.Flat;
            genQR.Font = new Font("Microsoft Sans Serif", 12F);
            genQR.ForeColor = SystemColors.ButtonHighlight;
            genQR.Image = Properties.Resources.qr_code_xxl__1_;
            genQR.ImageAlign = ContentAlignment.MiddleLeft;
            genQR.Location = new Point(0, 255);
            genQR.Margin = new Padding(0);
            genQR.Name = "genQR";
            genQR.Padding = new Padding(15, 0, 0, 0);
            genQR.Size = new Size(252, 41);
            genQR.TabIndex = 5;
            genQR.Text = "            Attendance QR";
            genQR.TextAlign = ContentAlignment.MiddleLeft;
            genQR.UseVisualStyleBackColor = true;
            genQR.Click += genQR_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Microsoft Sans Serif", 12F);
            buttonSettings.ForeColor = SystemColors.ButtonHighlight;
            buttonSettings.Image = Properties.Resources.user_gear;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(0, 296);
            buttonSettings.Margin = new Padding(0);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(15, 0, 0, 0);
            buttonSettings.Size = new Size(252, 41);
            buttonSettings.TabIndex = 4;
            buttonSettings.Text = "            Settings";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonQuestionList
            // 
            buttonQuestionList.FlatAppearance.BorderSize = 0;
            buttonQuestionList.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonQuestionList.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonQuestionList.FlatStyle = FlatStyle.Flat;
            buttonQuestionList.Font = new Font("Microsoft Sans Serif", 12F);
            buttonQuestionList.ForeColor = SystemColors.ButtonHighlight;
            buttonQuestionList.Image = Properties.Resources.questionList;
            buttonQuestionList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQuestionList.Location = new Point(0, 337);
            buttonQuestionList.Margin = new Padding(0);
            buttonQuestionList.Name = "buttonQuestionList";
            buttonQuestionList.Padding = new Padding(15, 0, 0, 0);
            buttonQuestionList.Size = new Size(252, 41);
            buttonQuestionList.TabIndex = 5;
            buttonQuestionList.Text = "            Manage Criteria Panel";
            buttonQuestionList.TextAlign = ContentAlignment.MiddleLeft;
            buttonQuestionList.UseVisualStyleBackColor = true;
            buttonQuestionList.Click += buttonQuestionList_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            buttonLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Microsoft Sans Serif", 12F);
            buttonLogOut.ForeColor = SystemColors.ButtonHighlight;
            buttonLogOut.Image = Properties.Resources.sign_out_alt1;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(0, 378);
            buttonLogOut.Margin = new Padding(0);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Padding = new Padding(15, 0, 0, 0);
            buttonLogOut.Size = new Size(252, 41);
            buttonLogOut.TabIndex = 4;
            buttonLogOut.Text = "            Logout";
            buttonLogOut.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(11, 11, 11);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(64, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1306, 749);
            mainPanel.TabIndex = 5;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // manageUsersButtonTimer
            // 
            manageUsersButtonTimer.Interval = 10;
            manageUsersButtonTimer.Tick += manageUsersButtonTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(mainPanel);
            Controls.Add(sidebar);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1280, 718);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OJT Management System";
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            flowLayoutPanelManageUsers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Panel panel2;
        private PictureBox menuButton;
        private Button buttonHome;
        private Button buttonInternList;
        private Button buttonAttendance;
        private Button buttonSettings;
        private Button buttonLogOut;
        private Panel mainPanel;
        private System.Windows.Forms.Timer sidebarTimer;
        private Button buttonAccomplishmentReports;
        private Button buttonManageUsers;
        private FlowLayoutPanel flowLayoutPanelManageUsers;
        private Button buttonUpdateUsers;
        private Button buttonAddUser;
        private System.Windows.Forms.Timer manageUsersButtonTimer;
        private Button genQR;
        private Button buttonQuestionList;
    }
}