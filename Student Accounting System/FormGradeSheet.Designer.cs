namespace Student_Accounting_System
{
    partial class FormGradeSheet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGroupTitle = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.lblSubjectLabel = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblGroupTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(960, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnBack.Location = new System.Drawing.Point(12, 16);
            this.btnBack.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnBack.Size = new System.Drawing.Size(90, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGroupTitle
            // 
            this.lblGroupTitle.AutoSize = true;
            this.lblGroupTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblGroupTitle.ForeColor = System.Drawing.Color.White;
            this.lblGroupTitle.Location = new System.Drawing.Point(120, 16);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(300, 25);
            this.lblGroupTitle.TabIndex = 1;
            this.lblGroupTitle.Text = "Группа — Ведомость оценок";
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.panelToolbar.Controls.Add(this.lblSubjectLabel);
            this.panelToolbar.Controls.Add(this.cmbSubject);
            this.panelToolbar.Controls.Add(this.lblAvgGrade);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 60);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(960, 50);
            this.panelToolbar.TabIndex = 1;
            // 
            // lblSubjectLabel
            // 
            this.lblSubjectLabel.AutoSize = true;
            this.lblSubjectLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubjectLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblSubjectLabel.Location = new System.Drawing.Point(16, 16);
            this.lblSubjectLabel.Name = "lblSubjectLabel";
            this.lblSubjectLabel.Size = new System.Drawing.Size(59, 15);
            this.lblSubjectLabel.TabIndex = 0;
            this.lblSubjectLabel.Text = "Предмет:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.cmbSubject.DisplayMember = "Name";
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubject.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbSubject.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(80, 12);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(300, 25);
            this.cmbSubject.TabIndex = 1;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblAvgGrade
            // 
            this.lblAvgGrade.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblAvgGrade.Location = new System.Drawing.Point(790, 16);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Size = new System.Drawing.Size(106, 15);
            this.lblAvgGrade.TabIndex = 2;
            this.lblAvgGrade.Text = "Средний балл: —";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelContent.Controls.Add(this.dataGridViewGrades);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 110);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelContent.Size = new System.Drawing.Size(960, 540);
            this.panelContent.TabIndex = 2;
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.AllowUserToAddRows = false;
            this.dataGridViewGrades.AllowUserToDeleteRows = false;
            this.dataGridViewGrades.AllowUserToResizeColumns = false;
            this.dataGridViewGrades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 32, 52);
            this.dataGridViewGrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGrades.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrades.BackgroundColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(20, 22, 40);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGrades.ColumnHeadersHeight = 36;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudent,
            this.colSem1,
            this.colSem2,
            this.colFinal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(50, 80, 140);
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGrades.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewGrades.EnableHeadersVisualStyles = false;
            this.dataGridViewGrades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewGrades.GridColor = System.Drawing.Color.FromArgb(40, 44, 68);
            this.dataGridViewGrades.Location = new System.Drawing.Point(12, 8);
            this.dataGridViewGrades.MultiSelect = false;
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersVisible = false;
            this.dataGridViewGrades.RowTemplate.Height = 36;
            this.dataGridViewGrades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrades.Size = new System.Drawing.Size(936, 524);
            this.dataGridViewGrades.TabIndex = 0;
            this.dataGridViewGrades.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrades_CellEndEdit);
            // 
            // colStudent
            // 
            this.colStudent.FillWeight = 40F;
            this.colStudent.HeaderText = "Студент";
            this.colStudent.Name = "colStudent";
            this.colStudent.ReadOnly = true;
            // 
            // colSem1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSem1.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSem1.FillWeight = 20F;
            this.colSem1.HeaderText = "1 семестр";
            this.colSem1.Name = "colSem1";
            // 
            // colSem2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSem2.DefaultCellStyle = dataGridViewCellStyle4;
            this.colSem2.FillWeight = 20F;
            this.colSem2.HeaderText = "2 семестр";
            this.colSem2.Name = "colSem2";
            // 
            // colFinal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFinal.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFinal.FillWeight = 20F;
            this.colFinal.HeaderText = "Итог";
            this.colFinal.Name = "colFinal";
            // 
            // FormGradeSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(860, 550);
            this.Name = "FormGradeSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ведомость оценок";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGroupTitle;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Label lblSubjectLabel;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblAvgGrade;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinal;
    }
}
