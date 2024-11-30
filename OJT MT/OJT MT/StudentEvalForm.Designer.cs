namespace OJT_MT
{
    partial class StudentEvalForm
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
            tableLayoutPanelQuestions = new TableLayoutPanel();
            labelName = new Label();
            labelStudentIDIndicator = new Label();
            labelContactNumberIndicator = new Label();
            labelStudentID = new Label();
            labelContactNumber = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelQuestions
            // 
            tableLayoutPanelQuestions.AutoScroll = true;
            tableLayoutPanelQuestions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanelQuestions.BackColor = Color.FromArgb(33, 31, 30);
            tableLayoutPanelQuestions.ColumnCount = 2;
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuestions.Dock = DockStyle.Fill;
            tableLayoutPanelQuestions.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanelQuestions.ForeColor = Color.FromArgb(244, 244, 239);
            tableLayoutPanelQuestions.Location = new Point(110, 110);
            tableLayoutPanelQuestions.Margin = new Padding(10);
            tableLayoutPanelQuestions.Name = "tableLayoutPanelQuestions";
            tableLayoutPanelQuestions.RowCount = 2;
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle());
            tableLayoutPanelQuestions.Size = new Size(721, 421);
            tableLayoutPanelQuestions.TabIndex = 4;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Roboto Cn", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.ForeColor = SystemColors.ButtonHighlight;
            labelName.Location = new Point(702, 108);
            labelName.Name = "labelName";
            labelName.Size = new Size(86, 23);
            labelName.TabIndex = 0;
            labelName.Text = "Full Name";
            // 
            // labelStudentIDIndicator
            // 
            labelStudentIDIndicator.AutoSize = true;
            labelStudentIDIndicator.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStudentIDIndicator.ForeColor = SystemColors.ButtonHighlight;
            labelStudentIDIndicator.Location = new Point(708, 138);
            labelStudentIDIndicator.Name = "labelStudentIDIndicator";
            labelStudentIDIndicator.Size = new Size(70, 15);
            labelStudentIDIndicator.TabIndex = 1;
            labelStudentIDIndicator.Text = "Student ID:";
            // 
            // labelContactNumberIndicator
            // 
            labelContactNumberIndicator.AutoSize = true;
            labelContactNumberIndicator.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContactNumberIndicator.ForeColor = SystemColors.ButtonHighlight;
            labelContactNumberIndicator.Location = new Point(702, 157);
            labelContactNumberIndicator.Name = "labelContactNumberIndicator";
            labelContactNumberIndicator.Size = new Size(76, 15);
            labelContactNumberIndicator.TabIndex = 2;
            labelContactNumberIndicator.Text = "Contact No.:";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Roboto Cn", 9F);
            labelStudentID.ForeColor = SystemColors.ButtonFace;
            labelStudentID.Location = new Point(784, 138);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(62, 14);
            labelStudentID.TabIndex = 3;
            labelStudentID.Text = "placeholder";
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Roboto Cn", 9F);
            labelContactNumber.ForeColor = SystemColors.ButtonFace;
            labelContactNumber.Location = new Point(784, 157);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(62, 14);
            labelContactNumber.TabIndex = 4;
            labelContactNumber.Text = "placeholder";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.FromArgb(15, 15, 11);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanelQuestions, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(941, 601);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // StudentEvalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 601);
            Controls.Add(labelContactNumber);
            Controls.Add(labelStudentID);
            Controls.Add(labelContactNumberIndicator);
            Controls.Add(labelName);
            Controls.Add(labelStudentIDIndicator);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentEvalForm";
            Text = "Form1";
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanelQuestions;
        private Label labelContactNumber;
        private Label labelStudentID;
        private Label labelContactNumberIndicator;
        private Label labelStudentIDIndicator;
        private Label labelName;
        private TableLayoutPanel tableLayoutPanel2;
    }
}