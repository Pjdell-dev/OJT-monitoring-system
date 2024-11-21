namespace OJT_MT
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
            label4 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanelRegister = new TableLayoutPanel();
            panel6 = new Panel();
            buttonSubmit = new Button();
            label10 = new Label();
            label11 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBoxEmail = new TextBox();
            labelEmailError = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            labelPasswordError = new Label();
            labelPasswordUpdatedMessage = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            comboBoxAccountType = new ComboBox();
            panel3 = new Panel();
            panelCompany = new Panel();
            label6 = new Label();
            textBoxCompany = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            textBoxIdNumber = new TextBox();
            textBoxContactNumber = new TextBox();
            label5 = new Label();
            textBoxFirstName = new TextBox();
            label1 = new Label();
            panelSupervisor = new Panel();
            label12 = new Label();
            comboBoxSupervisor = new ComboBox();
            panel4 = new Panel();
            pictureBoxUserImage = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label9 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            button1 = new Button();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanelRegister.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panelCompany.SuspendLayout();
            panelSupervisor.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserImage).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(254, 255, 250);
            label4.Location = new Point(567, 31);
            label4.Name = "label4";
            label4.Size = new Size(236, 37);
            label4.TabIndex = 0;
            label4.Text = "Add New User";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.FromArgb(12, 64, 41);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanelRegister, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(1371, 788);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // tableLayoutPanelRegister
            // 
            tableLayoutPanelRegister.AutoScroll = true;
            tableLayoutPanelRegister.BackColor = Color.FromArgb(217, 218, 214);
            tableLayoutPanelRegister.ColumnCount = 4;
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            tableLayoutPanelRegister.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelRegister.Controls.Add(panel6, 2, 2);
            tableLayoutPanelRegister.Controls.Add(panel1, 1, 0);
            tableLayoutPanelRegister.Controls.Add(panel2, 2, 0);
            tableLayoutPanelRegister.Controls.Add(panel3, 2, 1);
            tableLayoutPanelRegister.Controls.Add(panel4, 1, 1);
            tableLayoutPanelRegister.Controls.Add(panel5, 1, 2);
            tableLayoutPanelRegister.Dock = DockStyle.Fill;
            tableLayoutPanelRegister.Location = new Point(103, 103);
            tableLayoutPanelRegister.Name = "tableLayoutPanelRegister";
            tableLayoutPanelRegister.RowCount = 4;
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 95F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 355F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle(SizeType.Absolute, 305F));
            tableLayoutPanelRegister.RowStyles.Add(new RowStyle());
            tableLayoutPanelRegister.Size = new Size(1165, 622);
            tableLayoutPanelRegister.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(41, 40, 39);
            panel6.Controls.Add(buttonSubmit);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(flowLayoutPanel2);
            panel6.Controls.Add(flowLayoutPanel1);
            panel6.Dock = DockStyle.Fill;
            panel6.ForeColor = Color.FromArgb(49, 81, 30);
            panel6.Location = new Point(532, 460);
            panel6.Margin = new Padding(0, 10, 10, 10);
            panel6.Name = "panel6";
            panel6.Size = new Size(490, 285);
            panel6.TabIndex = 9;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.FromArgb(21, 115, 74);
            buttonSubmit.FlatAppearance.BorderSize = 0;
            buttonSubmit.FlatStyle = FlatStyle.Flat;
            buttonSubmit.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.ForeColor = Color.FromArgb(244, 244, 239);
            buttonSubmit.Location = new Point(349, 224);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(70, 30);
            buttonSubmit.TabIndex = 40;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(244, 244, 239);
            label10.Location = new Point(34, 37);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 30;
            label10.Text = "Email Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(244, 244, 239);
            label11.Location = new Point(63, 110);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 31;
            label11.Text = "Password";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(textBoxEmail);
            flowLayoutPanel2.Controls.Add(labelEmailError);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(172, 35);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(270, 59);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(254, 255, 250);
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxEmail.Location = new Point(3, 3);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email address";
            textBoxEmail.Size = new Size(244, 21);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // labelEmailError
            // 
            labelEmailError.AutoSize = true;
            labelEmailError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmailError.ForeColor = Color.FromArgb(255, 66, 72);
            labelEmailError.Location = new Point(3, 27);
            labelEmailError.Name = "labelEmailError";
            labelEmailError.Size = new Size(30, 15);
            labelEmailError.TabIndex = 2;
            labelEmailError.Text = "Yes";
            labelEmailError.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBoxPassword);
            flowLayoutPanel1.Controls.Add(textBoxConfirmPassword);
            flowLayoutPanel1.Controls.Add(labelPasswordError);
            flowLayoutPanel1.Controls.Add(labelPasswordUpdatedMessage);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(172, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(270, 107);
            flowLayoutPanel1.TabIndex = 39;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(254, 255, 250);
            textBoxPassword.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxPassword.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxPassword.Location = new Point(3, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(244, 21);
            textBoxPassword.TabIndex = 37;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.BackColor = Color.FromArgb(254, 255, 250);
            textBoxConfirmPassword.Font = new Font("Microsoft Sans Serif", 9F);
            textBoxConfirmPassword.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxConfirmPassword.Location = new Point(3, 30);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PlaceholderText = "Confirm Password";
            textBoxConfirmPassword.Size = new Size(244, 21);
            textBoxConfirmPassword.TabIndex = 38;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // labelPasswordError
            // 
            labelPasswordError.AutoSize = true;
            labelPasswordError.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPasswordError.ForeColor = Color.FromArgb(255, 66, 72);
            labelPasswordError.Location = new Point(3, 54);
            labelPasswordError.Name = "labelPasswordError";
            labelPasswordError.Size = new Size(147, 15);
            labelPasswordError.TabIndex = 3;
            labelPasswordError.Text = "Password must match";
            labelPasswordError.Visible = false;
            // 
            // labelPasswordUpdatedMessage
            // 
            labelPasswordUpdatedMessage.AutoSize = true;
            labelPasswordUpdatedMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPasswordUpdatedMessage.ForeColor = Color.FromArgb(87, 171, 134);
            labelPasswordUpdatedMessage.Location = new Point(3, 69);
            labelPasswordUpdatedMessage.Name = "labelPasswordUpdatedMessage";
            labelPasswordUpdatedMessage.Size = new Size(206, 15);
            labelPasswordUpdatedMessage.TabIndex = 40;
            labelPasswordUpdatedMessage.Text = "Password updated successfully";
            labelPasswordUpdatedMessage.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 85, 57);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(142, 10);
            panel1.Margin = new Padding(10, 10, 0, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 75);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(244, 244, 239);
            label2.Location = new Point(80, 15);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 37;
            label2.Text = "Account Type";
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = Color.FromArgb(41, 40, 39);
            panel2.Controls.Add(comboBoxAccountType);
            panel2.Dock = DockStyle.Fill;
            panel2.ForeColor = Color.FromArgb(49, 81, 30);
            panel2.Location = new Point(532, 10);
            panel2.Margin = new Padding(0, 10, 10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 75);
            panel2.TabIndex = 5;
            // 
            // comboBoxAccountType
            // 
            comboBoxAccountType.BackColor = Color.FromArgb(254, 255, 250);
            comboBoxAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAccountType.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxAccountType.ForeColor = Color.FromArgb(50, 49, 48);
            comboBoxAccountType.FormattingEnabled = true;
            comboBoxAccountType.Items.AddRange(new object[] { "Supervisor", "Student", "Administrator" });
            comboBoxAccountType.Location = new Point(85, 21);
            comboBoxAccountType.Name = "comboBoxAccountType";
            comboBoxAccountType.Size = new Size(212, 23);
            comboBoxAccountType.TabIndex = 0;
            comboBoxAccountType.SelectedIndexChanged += comboBoxAccountType_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(41, 40, 39);
            panel3.Controls.Add(panelCompany);
            panel3.Controls.Add(textBoxLastName);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBoxIdNumber);
            panel3.Controls.Add(textBoxContactNumber);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textBoxFirstName);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panelSupervisor);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.FromArgb(49, 81, 30);
            panel3.Location = new Point(532, 105);
            panel3.Margin = new Padding(0, 10, 10, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 335);
            panel3.TabIndex = 6;
            // 
            // panelCompany
            // 
            panelCompany.Controls.Add(label6);
            panelCompany.Controls.Add(textBoxCompany);
            panelCompany.Location = new Point(54, 146);
            panelCompany.Name = "panelCompany";
            panelCompany.Size = new Size(413, 48);
            panelCompany.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(244, 244, 239);
            label6.Location = new Point(21, 13);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 25;
            label6.Text = "Company";
            // 
            // textBoxCompany
            // 
            textBoxCompany.BackColor = Color.FromArgb(254, 255, 250);
            textBoxCompany.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxCompany.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxCompany.Location = new Point(123, 13);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.PlaceholderText = "Company Name";
            textBoxCompany.Size = new Size(244, 21);
            textBoxCompany.TabIndex = 28;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(254, 255, 250);
            textBoxLastName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxLastName.Location = new Point(303, 78);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name";
            textBoxLastName.Size = new Size(118, 21);
            textBoxLastName.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(244, 244, 239);
            label3.Location = new Point(64, 37);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 22;
            label3.Text = "ID Number";
            // 
            // textBoxIdNumber
            // 
            textBoxIdNumber.BackColor = Color.FromArgb(254, 255, 250);
            textBoxIdNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxIdNumber.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxIdNumber.Location = new Point(177, 37);
            textBoxIdNumber.Name = "textBoxIdNumber";
            textBoxIdNumber.PlaceholderText = "ID number";
            textBoxIdNumber.Size = new Size(244, 21);
            textBoxIdNumber.TabIndex = 4;
            textBoxIdNumber.KeyPress += textBoxIdNumber_KeyPress;
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.BackColor = Color.FromArgb(254, 255, 250);
            textBoxContactNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactNumber.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxContactNumber.Location = new Point(177, 119);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.PlaceholderText = "Contact number";
            textBoxContactNumber.Size = new Size(244, 21);
            textBoxContactNumber.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(244, 244, 239);
            label5.Location = new Point(54, 118);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 24;
            label5.Text = "Contact No.";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(254, 255, 250);
            textBoxFirstName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxFirstName.Location = new Point(177, 78);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name";
            textBoxFirstName.Size = new Size(120, 21);
            textBoxFirstName.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(244, 244, 239);
            label1.Location = new Point(100, 75);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 23;
            label1.Text = "Name";
            // 
            // panelSupervisor
            // 
            panelSupervisor.Controls.Add(label12);
            panelSupervisor.Controls.Add(comboBoxSupervisor);
            panelSupervisor.Location = new Point(54, 195);
            panelSupervisor.Name = "panelSupervisor";
            panelSupervisor.Size = new Size(413, 52);
            panelSupervisor.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(244, 244, 239);
            label12.Location = new Point(14, 13);
            label12.Name = "label12";
            label12.Size = new Size(94, 20);
            label12.TabIndex = 30;
            label12.Text = "Supervisor";
            // 
            // comboBoxSupervisor
            // 
            comboBoxSupervisor.BackColor = Color.FromArgb(254, 255, 250);
            comboBoxSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupervisor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSupervisor.ForeColor = Color.FromArgb(50, 49, 48);
            comboBoxSupervisor.FormattingEnabled = true;
            comboBoxSupervisor.Location = new Point(123, 13);
            comboBoxSupervisor.Name = "comboBoxSupervisor";
            comboBoxSupervisor.Size = new Size(244, 23);
            comboBoxSupervisor.TabIndex = 1;
            comboBoxSupervisor.SelectedIndexChanged += comboBoxSupervisor_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(24, 85, 57);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBoxUserImage);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Dock = DockStyle.Fill;
            panel4.ForeColor = Color.FromArgb(49, 81, 30);
            panel4.Location = new Point(142, 105);
            panel4.Margin = new Padding(10, 10, 0, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 335);
            panel4.TabIndex = 7;
            // 
            // pictureBoxUserImage
            // 
            pictureBoxUserImage.Anchor = AnchorStyles.Top;
            pictureBoxUserImage.Image = Properties.Resources.icon_default;
            pictureBoxUserImage.Location = new Point(126, 93);
            pictureBoxUserImage.Name = "pictureBoxUserImage";
            pictureBoxUserImage.Size = new Size(127, 128);
            pictureBoxUserImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserImage.TabIndex = 37;
            pictureBoxUserImage.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(244, 244, 239);
            label7.Location = new Point(68, 23);
            label7.Name = "label7";
            label7.Size = new Size(254, 29);
            label7.TabIndex = 32;
            label7.Text = "Personal Information";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(244, 244, 239);
            label8.Location = new Point(167, 18);
            label8.Name = "label8";
            label8.Size = new Size(79, 29);
            label8.TabIndex = 36;
            label8.Text = "Email";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(24, 85, 57);
            panel5.Controls.Add(label9);
            panel5.Dock = DockStyle.Fill;
            panel5.ForeColor = Color.FromArgb(49, 81, 30);
            panel5.Location = new Point(142, 460);
            panel5.Margin = new Padding(10, 10, 0, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(390, 285);
            panel5.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(244, 244, 239);
            label9.Location = new Point(68, 28);
            label9.Name = "label9";
            label9.Size = new Size(233, 29);
            label9.TabIndex = 35;
            label9.Text = "Sign-In Information";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.eye;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(126, 236);
            button1.Name = "button1";
            button1.Padding = new Padding(3);
            button1.Size = new Size(127, 31);
            button1.TabIndex = 38;
            button1.Text = "Upload Image";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 788);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            Text = "AddNewUserForm";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanelRegister.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelCompany.ResumeLayout(false);
            panelCompany.PerformLayout();
            panelSupervisor.ResumeLayout(false);
            panelSupervisor.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUserImage).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanelRegister;
        private Panel panel6;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private Label labelPasswordError;
        private Label labelPasswordUpdatedMessage;
        private Panel panel1;
        private Label label7;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Label label6;
        private Label label5;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBoxEmail;
        private Label labelEmailError;
        private Panel panel4;
        private Label label8;
        private Panel panel5;
        private Label label9;
        private TextBox textBoxCompany;
        private TextBox textBoxContactNumber;
        private TextBox textBoxFirstName;
        private TextBox textBoxIdNumber;
        private TextBox textBoxLastName;
        private Label label2;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private ComboBox comboBoxAccountType;
        private Label label10;
        private Label label11;
        private PictureBox pictureBoxUserImage;
        private ComboBox comboBoxSupervisor;
        private Label label12;
        private Panel panelSupervisor;
        private Button buttonSubmit;
        private Panel panelCompany;
        private Button button1;
    }
}