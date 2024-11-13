namespace OJT_MT
{
    partial class AdminManageUsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnUpdate = new Button();
            btnRemove = new Button();
            label2 = new Label();
            tbFilter = new TextBox();
            dataGridViewUsers = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            labelAddNewUser = new Label();
            pictureBoxAddNewUser = new PictureBox();
            comboBoxFilter = new ComboBox();
            tableLayoutPanelManageAccounts = new TableLayoutPanel();
            panelUpdateWindow = new Panel();
            flowLayoutPanelUpdateWindow = new FlowLayoutPanel();
            panel3 = new Panel();
            labelIdNumber = new Label();
            textBoxID = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            labelName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            labelContactNumber = new Label();
            textBoxContactNumber = new TextBox();
            panelSupervisorID = new Panel();
            panel9 = new Panel();
            labelSupervisorId = new Label();
            comboBoxSupervisorID = new ComboBox();
            panel10 = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelErrorMessage = new Label();
            labelSuccessMessage = new Label();
            label4 = new Label();
            manageUsersPanelTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddNewUser).BeginInit();
            tableLayoutPanelManageAccounts.SuspendLayout();
            panelUpdateWindow.SuspendLayout();
            flowLayoutPanelUpdateWindow.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panelSupervisorID.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(21, 115, 74);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(244, 244, 239);
            btnUpdate.Location = new Point(695, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(71, 33);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(255, 66, 72);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(772, 33);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(81, 33);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(254, 255, 250);
            label2.Location = new Point(22, 8);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 14;
            label2.Text = "Filter by:";
            // 
            // tbFilter
            // 
            tbFilter.BackColor = Color.FromArgb(254, 255, 250);
            tbFilter.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFilter.ForeColor = Color.FromArgb(50, 49, 48);
            tbFilter.Location = new Point(22, 41);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(195, 21);
            tbFilter.TabIndex = 13;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AllowUserToDeleteRows = false;
            dataGridViewUsers.AllowUserToResizeColumns = false;
            dataGridViewUsers.AllowUserToResizeRows = false;
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsers.BackgroundColor = Color.FromArgb(217, 218, 214);
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(254, 255, 250);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(50, 49, 48);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(161, 213, 190);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(50, 49, 48);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(3, 3);
            dataGridViewUsers.MultiSelect = false;
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.ReadOnly = true;
            dataGridViewUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUsers.Size = new Size(883, 383);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.SelectionChanged += dataGridViewUsers_SelectionChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.FromArgb(12, 64, 41);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanelManageAccounts, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(1106, 635);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 40, 39);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(labelAddNewUser);
            panel1.Controls.Add(pictureBoxAddNewUser);
            panel1.Controls.Add(comboBoxFilter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbFilter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(103, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 74);
            panel1.TabIndex = 13;
            // 
            // labelAddNewUser
            // 
            labelAddNewUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAddNewUser.AutoSize = true;
            labelAddNewUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddNewUser.ForeColor = Color.FromArgb(254, 255, 250);
            labelAddNewUser.Location = new Point(763, 9);
            labelAddNewUser.Name = "labelAddNewUser";
            labelAddNewUser.Size = new Size(66, 16);
            labelAddNewUser.TabIndex = 19;
            labelAddNewUser.Text = "Add new";
            // 
            // pictureBoxAddNewUser
            // 
            pictureBoxAddNewUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxAddNewUser.Cursor = Cursors.Hand;
            pictureBoxAddNewUser.Image = Properties.Resources.user_add;
            pictureBoxAddNewUser.Location = new Point(833, 8);
            pictureBoxAddNewUser.Name = "pictureBoxAddNewUser";
            pictureBoxAddNewUser.Size = new Size(20, 20);
            pictureBoxAddNewUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAddNewUser.TabIndex = 18;
            pictureBoxAddNewUser.TabStop = false;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.BackColor = Color.FromArgb(254, 255, 250);
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.Font = new Font("Microsoft Sans Serif", 8F);
            comboBoxFilter.ForeColor = Color.FromArgb(50, 49, 48);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.ItemHeight = 13;
            comboBoxFilter.Items.AddRange(new object[] { "-- Select --", "Name", "ID Number" });
            comboBoxFilter.Location = new Point(96, 8);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(121, 21);
            comboBoxFilter.TabIndex = 17;
            // 
            // tableLayoutPanelManageAccounts
            // 
            tableLayoutPanelManageAccounts.ColumnCount = 2;
            tableLayoutPanelManageAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageAccounts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 11F));
            tableLayoutPanelManageAccounts.Controls.Add(dataGridViewUsers, 0, 0);
            tableLayoutPanelManageAccounts.Controls.Add(panelUpdateWindow, 1, 0);
            tableLayoutPanelManageAccounts.Dock = DockStyle.Fill;
            tableLayoutPanelManageAccounts.Location = new Point(103, 183);
            tableLayoutPanelManageAccounts.Name = "tableLayoutPanelManageAccounts";
            tableLayoutPanelManageAccounts.RowCount = 1;
            tableLayoutPanelManageAccounts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageAccounts.Size = new Size(900, 389);
            tableLayoutPanelManageAccounts.TabIndex = 14;
            // 
            // panelUpdateWindow
            // 
            panelUpdateWindow.BackColor = Color.FromArgb(41, 40, 39);
            panelUpdateWindow.Controls.Add(flowLayoutPanelUpdateWindow);
            panelUpdateWindow.Dock = DockStyle.Fill;
            panelUpdateWindow.ForeColor = Color.FromArgb(254, 255, 250);
            panelUpdateWindow.Location = new Point(889, 0);
            panelUpdateWindow.Margin = new Padding(0);
            panelUpdateWindow.MinimumSize = new Size(10, 0);
            panelUpdateWindow.Name = "panelUpdateWindow";
            panelUpdateWindow.Size = new Size(11, 389);
            panelUpdateWindow.TabIndex = 0;
            // 
            // flowLayoutPanelUpdateWindow
            // 
            flowLayoutPanelUpdateWindow.Controls.Add(panel3);
            flowLayoutPanelUpdateWindow.Controls.Add(panel4);
            flowLayoutPanelUpdateWindow.Controls.Add(panel6);
            flowLayoutPanelUpdateWindow.Controls.Add(panelSupervisorID);
            flowLayoutPanelUpdateWindow.Controls.Add(panel10);
            flowLayoutPanelUpdateWindow.Controls.Add(labelErrorMessage);
            flowLayoutPanelUpdateWindow.Controls.Add(labelSuccessMessage);
            flowLayoutPanelUpdateWindow.Dock = DockStyle.Fill;
            flowLayoutPanelUpdateWindow.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelUpdateWindow.Location = new Point(0, 0);
            flowLayoutPanelUpdateWindow.Name = "flowLayoutPanelUpdateWindow";
            flowLayoutPanelUpdateWindow.Size = new Size(11, 389);
            flowLayoutPanelUpdateWindow.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelIdNumber);
            panel3.Controls.Add(textBoxID);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 26);
            panel3.TabIndex = 24;
            // 
            // labelIdNumber
            // 
            labelIdNumber.AutoSize = true;
            labelIdNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelIdNumber.Location = new Point(21, 1);
            labelIdNumber.Name = "labelIdNumber";
            labelIdNumber.Size = new Size(80, 15);
            labelIdNumber.TabIndex = 1;
            labelIdNumber.Text = "ID Number:";
            // 
            // textBoxID
            // 
            textBoxID.BackColor = Color.FromArgb(254, 255, 250);
            textBoxID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxID.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxID.Location = new Point(115, 1);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "Enter ID Number";
            textBoxID.Size = new Size(195, 21);
            textBoxID.TabIndex = 18;
            textBoxID.KeyPress += textBoxID_KeyPress;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(labelName);
            panel4.Controls.Add(textBoxFirstName);
            panel4.Controls.Add(textBoxLastName);
            panel4.Location = new Point(3, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(354, 26);
            panel4.TabIndex = 25;
            // 
            // panel5
            // 
            panel5.Location = new Point(0, 32);
            panel5.Name = "panel5";
            panel5.Size = new Size(354, 26);
            panel5.TabIndex = 26;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelName.Location = new Point(52, 3);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(254, 255, 250);
            textBoxFirstName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxFirstName.Location = new Point(115, 0);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "First Name";
            textBoxFirstName.Size = new Size(115, 21);
            textBoxFirstName.TabIndex = 19;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BackColor = Color.FromArgb(254, 255, 250);
            textBoxLastName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLastName.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxLastName.Location = new Point(239, 0);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "Last Name";
            textBoxLastName.Size = new Size(115, 21);
            textBoxLastName.TabIndex = 20;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(labelContactNumber);
            panel6.Controls.Add(textBoxContactNumber);
            panel6.Location = new Point(3, 67);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 26);
            panel6.TabIndex = 27;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 32);
            panel7.Name = "panel7";
            panel7.Size = new Size(354, 26);
            panel7.TabIndex = 26;
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelContactNumber.Location = new Point(16, 3);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(85, 15);
            labelContactNumber.TabIndex = 2;
            labelContactNumber.Text = "Contact No.:";
            // 
            // textBoxContactNumber
            // 
            textBoxContactNumber.BackColor = Color.FromArgb(254, 255, 250);
            textBoxContactNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContactNumber.ForeColor = Color.FromArgb(50, 49, 48);
            textBoxContactNumber.Location = new Point(115, 0);
            textBoxContactNumber.Name = "textBoxContactNumber";
            textBoxContactNumber.PlaceholderText = "Enter Contact Number";
            textBoxContactNumber.Size = new Size(195, 21);
            textBoxContactNumber.TabIndex = 21;
            // 
            // panelSupervisorID
            // 
            panelSupervisorID.Controls.Add(panel9);
            panelSupervisorID.Controls.Add(labelSupervisorId);
            panelSupervisorID.Controls.Add(comboBoxSupervisorID);
            panelSupervisorID.Location = new Point(3, 99);
            panelSupervisorID.Name = "panelSupervisorID";
            panelSupervisorID.Size = new Size(354, 29);
            panelSupervisorID.TabIndex = 28;
            // 
            // panel9
            // 
            panel9.Location = new Point(0, 32);
            panel9.Name = "panel9";
            panel9.Size = new Size(354, 26);
            panel9.TabIndex = 26;
            // 
            // labelSupervisorId
            // 
            labelSupervisorId.AutoSize = true;
            labelSupervisorId.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelSupervisorId.Location = new Point(12, 1);
            labelSupervisorId.Name = "labelSupervisorId";
            labelSupervisorId.Size = new Size(97, 15);
            labelSupervisorId.TabIndex = 3;
            labelSupervisorId.Text = "Supervisor ID:";
            // 
            // comboBoxSupervisorID
            // 
            comboBoxSupervisorID.BackColor = Color.FromArgb(254, 255, 250);
            comboBoxSupervisorID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSupervisorID.Font = new Font("Microsoft Sans Serif", 8F);
            comboBoxSupervisorID.ForeColor = Color.FromArgb(50, 49, 48);
            comboBoxSupervisorID.FormattingEnabled = true;
            comboBoxSupervisorID.ItemHeight = 13;
            comboBoxSupervisorID.Location = new Point(115, 1);
            comboBoxSupervisorID.Name = "comboBoxSupervisorID";
            comboBoxSupervisorID.Size = new Size(195, 21);
            comboBoxSupervisorID.TabIndex = 18;
            comboBoxSupervisorID.SelectionChangeCommitted += comboBoxSupervisorID_SelectionChangeCommitted;
            // 
            // panel10
            // 
            panel10.Controls.Add(buttonCancel);
            panel10.Controls.Add(buttonSave);
            panel10.Location = new Point(3, 134);
            panel10.Name = "panel10";
            panel10.Size = new Size(354, 50);
            panel10.TabIndex = 29;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.BackColor = Color.FromArgb(255, 66, 72);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(115, 9);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(87, 33);
            buttonCancel.TabIndex = 18;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave.BackColor = Color.FromArgb(21, 115, 74);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            buttonSave.ForeColor = Color.FromArgb(244, 244, 239);
            buttonSave.Location = new Point(208, 9);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(87, 33);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.FromArgb(255, 66, 72);
            labelErrorMessage.Location = new Point(363, 0);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(136, 15);
            labelErrorMessage.TabIndex = 41;
            labelErrorMessage.Text = "Error Message Here";
            labelErrorMessage.Visible = false;
            // 
            // labelSuccessMessage
            // 
            labelSuccessMessage.AutoSize = true;
            labelSuccessMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccessMessage.ForeColor = Color.FromArgb(87, 171, 134);
            labelSuccessMessage.Location = new Point(363, 15);
            labelSuccessMessage.Name = "labelSuccessMessage";
            labelSuccessMessage.Size = new Size(157, 15);
            labelSuccessMessage.TabIndex = 42;
            labelSuccessMessage.Text = "Success Message Here";
            labelSuccessMessage.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(254, 255, 250);
            label4.Location = new Point(408, 31);
            label4.Name = "label4";
            label4.Size = new Size(289, 37);
            label4.TabIndex = 0;
            label4.Text = "Manage Accounts";
            // 
            // manageUsersPanelTimer
            // 
            manageUsersPanelTimer.Interval = 10;
            manageUsersPanelTimer.Tick += manageUsersPanelTimer_Tick;
            // 
            // AdminManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1106, 635);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageUsersForm";
            Text = "AdminManageUsersForm";
            Load += AdminManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddNewUser).EndInit();
            tableLayoutPanelManageAccounts.ResumeLayout(false);
            panelUpdateWindow.ResumeLayout(false);
            flowLayoutPanelUpdateWindow.ResumeLayout(false);
            flowLayoutPanelUpdateWindow.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panelSupervisorID.ResumeLayout(false);
            panelSupervisorID.PerformLayout();
            panel10.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnUpdate;
        private Button btnRemove;
        private Label label2;
        private TextBox tbFilter;
        private DataGridView dataGridViewUsers;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private Panel panel1;
        private ComboBox comboBoxFilter;
        private Panel panelUpdateWindow;
        private Label labelName;
        private Label labelIdNumber;
        private Label labelContactNumber;
        private TextBox textBoxID;
        private TextBox textBoxContactNumber;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Button buttonSave;
        private FlowLayoutPanel flowLayoutPanelUpdateWindow;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private Panel panel10;
        private Button buttonCancel;
        private System.Windows.Forms.Timer manageUsersPanelTimer;
        private TableLayoutPanel tableLayoutPanelManageAccounts;
        private Panel panelSupervisorID;
        private Panel panel9;
        private Label labelSupervisorId;
        private ComboBox comboBoxSupervisorID;
        private Label labelErrorMessage;
        private Label labelSuccessMessage;
        private PictureBox pictureBoxAddNewUser;
        private Label labelAddNewUser;
    }
}