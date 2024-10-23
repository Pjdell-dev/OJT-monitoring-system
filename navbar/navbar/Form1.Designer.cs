namespace navbar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            btnHam = new PictureBox();
            sidebar = new FlowLayoutPanel();
            btnAR = new Button();
            btnInterns = new Button();
            btnAttendance = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            btnHome = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHam);
            panel1.Location = new Point(3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 55);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 10);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 1;
            label1.Text = "Supervisor";
            // 
            // btnHam
            // 
            btnHam.Image = (Image)resources.GetObject("btnHam.Image");
            btnHam.Location = new Point(3, 3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(40, 49);
            btnHam.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(btnAR);
            sidebar.Controls.Add(btnInterns);
            sidebar.Controls.Add(btnAttendance);
            sidebar.Controls.Add(btnSettings);
            sidebar.Controls.Add(btnLogout);
            sidebar.Location = new Point(3, 53);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(308, 521);
            sidebar.TabIndex = 1;
            // 
            // btnAR
            // 
            btnAR.BackColor = Color.FromArgb(23, 24, 29);
            btnAR.FlatAppearance.BorderColor = Color.Black;
            btnAR.FlatAppearance.BorderSize = 0;
            btnAR.FlatStyle = FlatStyle.Flat;
            btnAR.Font = new Font("Segoe UI", 10F);
            btnAR.ForeColor = SystemColors.ButtonHighlight;
            btnAR.Image = (Image)resources.GetObject("btnAR.Image");
            btnAR.ImageAlign = ContentAlignment.MiddleLeft;
            btnAR.Location = new Point(3, 53);
            btnAR.Name = "btnAR";
            btnAR.Padding = new Padding(20, 0, 0, 0);
            btnAR.Size = new Size(319, 44);
            btnAR.TabIndex = 2;
            btnAR.Text = "Accomplishment Reports";
            btnAR.UseVisualStyleBackColor = false;
            // 
            // btnInterns
            // 
            btnInterns.BackColor = Color.FromArgb(23, 24, 29);
            btnInterns.FlatAppearance.BorderColor = Color.Black;
            btnInterns.FlatAppearance.BorderSize = 0;
            btnInterns.FlatStyle = FlatStyle.Flat;
            btnInterns.Font = new Font("Segoe UI", 10F);
            btnInterns.ForeColor = SystemColors.ButtonHighlight;
            btnInterns.Image = (Image)resources.GetObject("btnInterns.Image");
            btnInterns.ImageAlign = ContentAlignment.MiddleLeft;
            btnInterns.Location = new Point(3, 103);
            btnInterns.Name = "btnInterns";
            btnInterns.Padding = new Padding(20, 0, 0, 0);
            btnInterns.Size = new Size(319, 44);
            btnInterns.TabIndex = 2;
            btnInterns.Text = "List of Interns";
            btnInterns.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.FromArgb(23, 24, 29);
            btnAttendance.FlatAppearance.BorderColor = Color.Black;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Segoe UI", 10F);
            btnAttendance.ForeColor = SystemColors.ButtonHighlight;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(3, 153);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(20, 0, 0, 0);
            btnAttendance.Size = new Size(319, 44);
            btnAttendance.TabIndex = 2;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(23, 24, 29);
            btnSettings.FlatAppearance.BorderColor = Color.Black;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = SystemColors.ButtonHighlight;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 203);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(20, 0, 0, 0);
            btnSettings.Size = new Size(319, 44);
            btnSettings.TabIndex = 2;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(23, 24, 29);
            btnLogout.FlatAppearance.BorderColor = Color.Black;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 253);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(319, 44);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(23, 24, 29);
            btnHome.FlatAppearance.BorderColor = Color.Black;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 10F);
            btnHome.ForeColor = SystemColors.ButtonHighlight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 0, 0);
            btnHome.Size = new Size(319, 44);
            btnHome.TabIndex = 2;
            btnHome.Text = " Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += button1_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1049, 586);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHam;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button btnAR;
        private Button btnInterns;
        private Button btnAttendance;
        private Button btnSettings;
        private Button btnLogout;
        private Button btnHome;
    }
}
