namespace OJT_MT
{
    partial class QuestionsPanel
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
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            btnAddCriteria = new Button();
            comboBoxFilter = new ComboBox();
            label3 = new Label();
            buttonRemove = new Button();
            buttonUpdate = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            labelAddNewUser = new Label();
            pictureBoxAddNewUser = new PictureBox();
            tbFilter = new TextBox();
            tableLayoutPanelManageCriteria = new TableLayoutPanel();
            dataGridViewUsers = new DataGridView();
            panelUpdateWindow = new Panel();
            flowLayoutPanelUpdateWindow = new FlowLayoutPanel();
            updatePanel = new Panel();
            panel3 = new Panel();
            labelIdNumber = new Label();
            tbCriteriaID = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            panel4 = new Panel();
            tbCriteria = new RichTextBox();
            labelName = new Label();
            labelSuccessMessage = new Label();
            panel10 = new Panel();
            btnSave = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            labelErrorMessage = new Label();
            addPanel = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            panel7 = new Panel();
            tbAddCriteria = new RichTextBox();
            label2 = new Label();
            label5 = new Label();
            panel8 = new Panel();
            btnAddSubmit = new Button();
            button1 = new Button();
            btnCancelAdd = new Button();
            button3 = new Button();
            label6 = new Label();
            label4 = new Label();
            manageCriteriaPanelTimer = new System.Windows.Forms.Timer(components);
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddNewUser).BeginInit();
            tableLayoutPanelManageCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelUpdateWindow.SuspendLayout();
            flowLayoutPanelUpdateWindow.SuspendLayout();
            updatePanel.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            addPanel.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
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
            tableLayoutPanel2.Controls.Add(tableLayoutPanelManageCriteria, 1, 2);
            tableLayoutPanel2.Controls.Add(label4, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(1106, 788);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 40, 39);
            panel1.Controls.Add(btnAddCriteria);
            panel1.Controls.Add(comboBoxFilter);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(buttonRemove);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(labelAddNewUser);
            panel1.Controls.Add(pictureBoxAddNewUser);
            panel1.Controls.Add(tbFilter);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(103, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 99);
            panel1.TabIndex = 13;
            // 
            // btnAddCriteria
            // 
            btnAddCriteria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCriteria.FlatAppearance.BorderSize = 0;
            btnAddCriteria.FlatAppearance.MouseDownBackColor = Color.FromArgb(87, 171, 134);
            btnAddCriteria.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 132, 90);
            btnAddCriteria.FlatStyle = FlatStyle.Flat;
            btnAddCriteria.Font = new Font("Microsoft Sans Serif", 12F);
            btnAddCriteria.ForeColor = SystemColors.ButtonHighlight;
            btnAddCriteria.Image = Properties.Resources.plus_icon;
            btnAddCriteria.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCriteria.Location = new Point(703, 13);
            btnAddCriteria.Margin = new Padding(0);
            btnAddCriteria.Name = "btnAddCriteria";
            btnAddCriteria.Padding = new Padding(15, 0, 0, 0);
            btnAddCriteria.Size = new Size(171, 33);
            btnAddCriteria.TabIndex = 24;
            btnAddCriteria.Text = "          Add Criteria";
            btnAddCriteria.TextAlign = ContentAlignment.MiddleLeft;
            btnAddCriteria.UseVisualStyleBackColor = true;
            btnAddCriteria.Click += btnAddCriteria_Click;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.BackColor = Color.FromArgb(254, 255, 250);
            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.Font = new Font("Microsoft Sans Serif", 8F);
            comboBoxFilter.ForeColor = Color.FromArgb(50, 49, 48);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.ItemHeight = 13;
            comboBoxFilter.Items.AddRange(new object[] { "-- Select --", "Criteria ID", "Criteria Name" });
            comboBoxFilter.Location = new Point(95, 21);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(140, 21);
            comboBoxFilter.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(254, 255, 250);
            label3.Location = new Point(21, 21);
            label3.Name = "label3";
            label3.Size = new Size(67, 16);
            label3.TabIndex = 22;
            label3.Text = "Filter by:";
            // 
            // buttonRemove
            // 
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemove.BackColor = Color.FromArgb(255, 66, 72);
            buttonRemove.FlatAppearance.BorderSize = 0;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            buttonRemove.ForeColor = Color.White;
            buttonRemove.Location = new Point(793, 53);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(81, 33);
            buttonRemove.TabIndex = 21;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUpdate.BackColor = Color.FromArgb(21, 115, 74);
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            buttonUpdate.ForeColor = Color.FromArgb(244, 244, 239);
            buttonUpdate.Location = new Point(703, 53);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(71, 33);
            buttonUpdate.TabIndex = 20;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += btnUpdate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(21, 115, 74);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.FromArgb(244, 244, 239);
            btnUpdate.Location = new Point(1395, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(71, 33);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.BackColor = Color.FromArgb(255, 66, 72);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(1472, 33);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(81, 33);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // labelAddNewUser
            // 
            labelAddNewUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelAddNewUser.AutoSize = true;
            labelAddNewUser.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddNewUser.ForeColor = Color.FromArgb(254, 255, 250);
            labelAddNewUser.Location = new Point(1463, 9);
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
            pictureBoxAddNewUser.Location = new Point(1533, 8);
            pictureBoxAddNewUser.Name = "pictureBoxAddNewUser";
            pictureBoxAddNewUser.Size = new Size(20, 20);
            pictureBoxAddNewUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAddNewUser.TabIndex = 18;
            pictureBoxAddNewUser.TabStop = false;
            // 
            // tbFilter
            // 
            tbFilter.BackColor = Color.FromArgb(254, 255, 250);
            tbFilter.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbFilter.ForeColor = Color.FromArgb(50, 49, 48);
            tbFilter.Location = new Point(21, 58);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(214, 21);
            tbFilter.TabIndex = 13;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // tableLayoutPanelManageCriteria
            // 
            tableLayoutPanelManageCriteria.ColumnCount = 2;
            tableLayoutPanelManageCriteria.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageCriteria.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanelManageCriteria.Controls.Add(dataGridViewUsers, 0, 0);
            tableLayoutPanelManageCriteria.Controls.Add(panelUpdateWindow, 1, 0);
            tableLayoutPanelManageCriteria.Dock = DockStyle.Fill;
            tableLayoutPanelManageCriteria.Location = new Point(103, 208);
            tableLayoutPanelManageCriteria.Name = "tableLayoutPanelManageCriteria";
            tableLayoutPanelManageCriteria.RowCount = 1;
            tableLayoutPanelManageCriteria.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelManageCriteria.Size = new Size(900, 517);
            tableLayoutPanelManageCriteria.TabIndex = 14;
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
            dataGridViewUsers.Size = new Size(886, 511);
            dataGridViewUsers.TabIndex = 2;
            dataGridViewUsers.SelectionChanged += DataGridViewCriteria_SelectionChanged;
            // 
            // panelUpdateWindow
            // 
            panelUpdateWindow.BackColor = Color.FromArgb(41, 40, 39);
            panelUpdateWindow.Controls.Add(flowLayoutPanelUpdateWindow);
            panelUpdateWindow.Dock = DockStyle.Fill;
            panelUpdateWindow.ForeColor = Color.FromArgb(254, 255, 250);
            panelUpdateWindow.Location = new Point(892, 0);
            panelUpdateWindow.Margin = new Padding(0);
            panelUpdateWindow.MinimumSize = new Size(10, 0);
            panelUpdateWindow.Name = "panelUpdateWindow";
            panelUpdateWindow.Size = new Size(10, 517);
            panelUpdateWindow.TabIndex = 0;
            // 
            // flowLayoutPanelUpdateWindow
            // 
            flowLayoutPanelUpdateWindow.Controls.Add(updatePanel);
            flowLayoutPanelUpdateWindow.Controls.Add(addPanel);
            flowLayoutPanelUpdateWindow.Dock = DockStyle.Fill;
            flowLayoutPanelUpdateWindow.Location = new Point(0, 0);
            flowLayoutPanelUpdateWindow.Name = "flowLayoutPanelUpdateWindow";
            flowLayoutPanelUpdateWindow.Size = new Size(10, 517);
            flowLayoutPanelUpdateWindow.TabIndex = 23;
            // 
            // updatePanel
            // 
            updatePanel.Controls.Add(panel3);
            updatePanel.Controls.Add(panel2);
            updatePanel.Controls.Add(panel4);
            updatePanel.Controls.Add(labelSuccessMessage);
            updatePanel.Controls.Add(panel10);
            updatePanel.Controls.Add(labelErrorMessage);
            updatePanel.Location = new Point(3, 3);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(410, 300);
            updatePanel.TabIndex = 43;
            // 
            // panel3
            // 
            panel3.Controls.Add(labelIdNumber);
            panel3.Controls.Add(tbCriteriaID);
            panel3.Location = new Point(16, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 26);
            panel3.TabIndex = 24;
            // 
            // labelIdNumber
            // 
            labelIdNumber.AutoSize = true;
            labelIdNumber.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelIdNumber.Location = new Point(3, 1);
            labelIdNumber.Name = "labelIdNumber";
            labelIdNumber.Size = new Size(76, 15);
            labelIdNumber.TabIndex = 1;
            labelIdNumber.Text = "Criteria ID:";
            // 
            // tbCriteriaID
            // 
            tbCriteriaID.BackColor = Color.FromArgb(254, 255, 250);
            tbCriteriaID.Enabled = false;
            tbCriteriaID.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbCriteriaID.ForeColor = Color.FromArgb(50, 49, 48);
            tbCriteriaID.Location = new Point(97, 2);
            tbCriteriaID.Name = "tbCriteriaID";
            tbCriteriaID.PlaceholderText = "Enter ID Number";
            tbCriteriaID.Size = new Size(239, 21);
            tbCriteriaID.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(label7);
            panel2.Location = new Point(16, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 26);
            panel2.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(100, 0);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
            label7.TabIndex = 1;
            label7.Text = "UPDATE CRITERIA";
            // 
            // panel4
            // 
            panel4.Controls.Add(tbCriteria);
            panel4.Controls.Add(labelName);
            panel4.Location = new Point(16, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(381, 108);
            panel4.TabIndex = 25;
            // 
            // tbCriteria
            // 
            tbCriteria.Location = new Point(97, 15);
            tbCriteria.Name = "tbCriteria";
            tbCriteria.Size = new Size(239, 77);
            tbCriteria.TabIndex = 1;
            tbCriteria.Text = "";
            tbCriteria.TextChanged += tbCriteria_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            labelName.Location = new Point(21, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(58, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Criteria:";
            // 
            // labelSuccessMessage
            // 
            labelSuccessMessage.AutoSize = true;
            labelSuccessMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSuccessMessage.ForeColor = Color.FromArgb(87, 171, 134);
            labelSuccessMessage.Location = new Point(16, 275);
            labelSuccessMessage.Name = "labelSuccessMessage";
            labelSuccessMessage.Size = new Size(157, 15);
            labelSuccessMessage.TabIndex = 42;
            labelSuccessMessage.Text = "Success Message Here";
            labelSuccessMessage.Visible = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(btnSave);
            panel10.Controls.Add(buttonCancel);
            panel10.Controls.Add(buttonSave);
            panel10.Location = new Point(16, 196);
            panel10.Name = "panel10";
            panel10.Size = new Size(381, 50);
            panel10.TabIndex = 29;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(21, 115, 74);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(190, 9);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 33);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonCancel.BackColor = Color.FromArgb(255, 66, 72);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(88, 9);
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
            buttonSave.Location = new Point(389, 9);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(87, 33);
            buttonSave.TabIndex = 22;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErrorMessage.ForeColor = Color.FromArgb(255, 66, 72);
            labelErrorMessage.Location = new Point(16, 260);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(136, 15);
            labelErrorMessage.TabIndex = 41;
            labelErrorMessage.Text = "Error Message Here";
            labelErrorMessage.Visible = false;
            // 
            // addPanel
            // 
            addPanel.Controls.Add(panel6);
            addPanel.Controls.Add(panel7);
            addPanel.Controls.Add(label5);
            addPanel.Controls.Add(panel8);
            addPanel.Controls.Add(label6);
            addPanel.Location = new Point(3, 309);
            addPanel.Name = "addPanel";
            addPanel.Size = new Size(410, 300);
            addPanel.TabIndex = 44;
            addPanel.Visible = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Location = new Point(16, 16);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 26);
            panel6.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(120, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 1;
            label1.Text = "ADD CRITERIA";
            // 
            // panel7
            // 
            panel7.Controls.Add(tbAddCriteria);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(16, 48);
            panel7.Name = "panel7";
            panel7.Size = new Size(354, 108);
            panel7.TabIndex = 25;
            // 
            // tbAddCriteria
            // 
            tbAddCriteria.Location = new Point(97, 15);
            tbAddCriteria.Name = "tbAddCriteria";
            tbAddCriteria.Size = new Size(239, 77);
            tbAddCriteria.TabIndex = 1;
            tbAddCriteria.Text = "";
            tbAddCriteria.TextChanged += tbAddCriteria_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 15);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Criteria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(87, 171, 134);
            label5.Location = new Point(16, 240);
            label5.Name = "label5";
            label5.Size = new Size(157, 15);
            label5.TabIndex = 42;
            label5.Text = "Success Message Here";
            label5.Visible = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnAddSubmit);
            panel8.Controls.Add(button1);
            panel8.Controls.Add(btnCancelAdd);
            panel8.Controls.Add(button3);
            panel8.Location = new Point(16, 162);
            panel8.Name = "panel8";
            panel8.Size = new Size(354, 50);
            panel8.TabIndex = 29;
            // 
            // btnAddSubmit
            // 
            btnAddSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddSubmit.BackColor = Color.FromArgb(21, 115, 74);
            btnAddSubmit.FlatAppearance.BorderSize = 0;
            btnAddSubmit.FlatStyle = FlatStyle.Flat;
            btnAddSubmit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnAddSubmit.ForeColor = Color.White;
            btnAddSubmit.Location = new Point(187, 9);
            btnAddSubmit.Name = "btnAddSubmit";
            btnAddSubmit.Size = new Size(87, 33);
            btnAddSubmit.TabIndex = 24;
            btnAddSubmit.Text = "Submit";
            btnAddSubmit.UseVisualStyleBackColor = false;
            btnAddSubmit.Click += btnAddSubmit_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(21, 115, 74);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(355, 9);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCancelAdd
            // 
            btnCancelAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelAdd.BackColor = Color.FromArgb(255, 66, 72);
            btnCancelAdd.FlatAppearance.BorderSize = 0;
            btnCancelAdd.FlatStyle = FlatStyle.Flat;
            btnCancelAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCancelAdd.ForeColor = Color.White;
            btnCancelAdd.Location = new Point(85, 9);
            btnCancelAdd.Name = "btnCancelAdd";
            btnCancelAdd.Size = new Size(87, 33);
            btnCancelAdd.TabIndex = 18;
            btnCancelAdd.Text = "Cancel";
            btnCancelAdd.UseVisualStyleBackColor = false;
            btnCancelAdd.Click += btnCancelAdd_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(21, 115, 74);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(244, 244, 239);
            button3.Location = new Point(540, 9);
            button3.Name = "button3";
            button3.Size = new Size(87, 33);
            button3.TabIndex = 22;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 66, 72);
            label6.Location = new Point(16, 225);
            label6.Name = "label6";
            label6.Size = new Size(136, 15);
            label6.TabIndex = 41;
            label6.Text = "Error Message Here";
            label6.Visible = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(254, 255, 250);
            label4.Location = new Point(375, 31);
            label4.Name = "label4";
            label4.Size = new Size(355, 37);
            label4.TabIndex = 0;
            label4.Text = "Manage Criteria Panel";
            // 
            // manageCriteriaPanelTimer
            // 
            manageCriteriaPanelTimer.Tick += manageCriteriaPanelTimer_Tick;
            // 
            // QuestionsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 788);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionsPanel";
            Text = "Form1";
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddNewUser).EndInit();
            tableLayoutPanelManageCriteria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelUpdateWindow.ResumeLayout(false);
            flowLayoutPanelUpdateWindow.ResumeLayout(false);
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel10.ResumeLayout(false);
            addPanel.ResumeLayout(false);
            addPanel.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Button btnUpdate;
        private Button btnRemove;
        private Label labelAddNewUser;
        private PictureBox pictureBoxAddNewUser;
        private TableLayoutPanel tableLayoutPanelManageCriteria;
        private DataGridView dataGridViewUsers;
        private Panel panelUpdateWindow;
        private FlowLayoutPanel flowLayoutPanelUpdateWindow;
        private Panel panel3;
        private Label labelIdNumber;
        private TextBox tbCriteriaID;
        private Panel panel4;
        private Label labelName;
        private Panel panel10;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelErrorMessage;
        private Label labelSuccessMessage;
        private Label label4;
        private TextBox tbFilter;
        private Button buttonUpdate;
        private Button buttonRemove;
        private Button btnSave;
        private RichTextBox tbCriteria;
        private System.Windows.Forms.Timer manageCriteriaPanelTimer;
        private ComboBox comboBoxFilter;
        private Label label3;
        private Button btnAddCriteria;
        private Panel updatePanel;
        private Panel addPanel;
        private Panel panel6;
        private Label label1;
        private Panel panel7;
        private RichTextBox tbAddCriteria;
        private Label label2;
        private Label label5;
        private Panel panel8;
        private Button button1;
        private Button btnCancelAdd;
        private Button button3;
        private Label label6;
        private Button btnAddSubmit;
        private Panel panel2;
        private Label label7;
    }
}