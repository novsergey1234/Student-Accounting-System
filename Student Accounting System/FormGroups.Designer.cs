namespace Student_Accounting_System
{
    partial class FormGroups
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblGroupsTitle = new System.Windows.Forms.Label();
            this.lblTotalGroupsLabel = new System.Windows.Forms.Label();
            this.lblTotalGroupsValue = new System.Windows.Forms.Label();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvgGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblFooterIcon = new System.Windows.Forms.Label();
            this.lblFooterTitle = new System.Windows.Forms.Label();
            this.lblTotalGroupsStat = new System.Windows.Forms.Label();
            this.lblTotalGroups = new System.Windows.Forms.Label();
            this.lblTotalStudentsStat = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblAvgGradeStat = new System.Windows.Forms.Label();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 52;
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Система учета студентов";
            //
            // panelToolbar
            //
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.panelToolbar.Controls.Add(this.btnAddGroup);
            this.panelToolbar.Controls.Add(this.btnEditGroup);
            this.panelToolbar.Controls.Add(this.btnDeleteGroup);
            this.panelToolbar.Controls.Add(this.btnExcel);
            this.panelToolbar.Controls.Add(this.btnPdf);
            this.panelToolbar.Controls.Add(this.btnWord);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Height = 52;
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            //
            // btnAddGroup
            //
            this.btnAddGroup.AutoSize = true;
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnAddGroup.FlatAppearance.BorderSize = 1;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGroup.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnAddGroup.Location = new System.Drawing.Point(12, 12);
            this.btnAddGroup.MinimumSize = new System.Drawing.Size(120, 30);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddGroup.Text = "+ Добавить группу";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            //
            // btnEditGroup
            //
            this.btnEditGroup.AutoSize = true;
            this.btnEditGroup.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.Enabled = false;
            this.btnEditGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnEditGroup.FlatAppearance.BorderSize = 1;
            this.btnEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditGroup.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnEditGroup.Location = new System.Drawing.Point(150, 12);
            this.btnEditGroup.MinimumSize = new System.Drawing.Size(120, 30);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnEditGroup.Text = "✎ Редактировать";
            this.btnEditGroup.UseVisualStyleBackColor = false;
            //
            // btnDeleteGroup
            //
            this.btnDeleteGroup.AutoSize = true;
            this.btnDeleteGroup.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnDeleteGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnDeleteGroup.FlatAppearance.BorderSize = 1;
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteGroup.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnDeleteGroup.Location = new System.Drawing.Point(288, 12);
            this.btnDeleteGroup.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnDeleteGroup.Text = "🗑 Удалить";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            //
            // btnExcel
            //
            this.btnExcel.AutoSize = true;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnExcel.FlatAppearance.BorderSize = 1;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnExcel.Location = new System.Drawing.Point(408, 12);
            this.btnExcel.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnExcel.Text = "⊞ Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            //
            // btnPdf
            //
            this.btnPdf.AutoSize = true;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnPdf.FlatAppearance.BorderSize = 1;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdf.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnPdf.Location = new System.Drawing.Point(498, 12);
            this.btnPdf.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnPdf.Text = "⊟ PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            //
            // btnWord
            //
            this.btnWord.AutoSize = true;
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnWord.FlatAppearance.BorderSize = 1;
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWord.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnWord.Location = new System.Drawing.Point(588, 12);
            this.btnWord.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnWord.Name = "btnWord";
            this.btnWord.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnWord.Text = "⊡ Word";
            this.btnWord.UseVisualStyleBackColor = false;
            //
            // panelSearch
            //
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.panelSearch.Controls.Add(this.lblSearchIcon);
            this.panelSearch.Controls.Add(this.lblSearchTitle);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Height = 90;
            this.panelSearch.Name = "panelSearch";
            //
            // lblSearchIcon
            //
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblSearchIcon.Location = new System.Drawing.Point(12, 10);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Text = "🔍";
            //
            // lblSearchTitle
            //
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblSearchTitle.Location = new System.Drawing.Point(32, 11);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Text = "Поиск группы";
            //
            // txtSearch
            //
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtSearch.Location = new System.Drawing.Point(12, 38);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(680, 30);
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnSearch.FlatAppearance.BorderSize = 1;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnSearch.Location = new System.Drawing.Point(700, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 30);
            this.btnSearch.Text = "🔍  Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            //
            // panelContent
            //
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelContent.Controls.Add(this.dataGridViewGroups);
            this.panelContent.Controls.Add(this.lblTotalGroupsValue);
            this.panelContent.Controls.Add(this.lblTotalGroupsLabel);
            this.panelContent.Controls.Add(this.lblGroupsTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            //
            // lblGroupsTitle
            //
            this.lblGroupsTitle.AutoSize = true;
            this.lblGroupsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGroupsTitle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblGroupsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblGroupsTitle.Name = "lblGroupsTitle";
            this.lblGroupsTitle.Text = "Учебные группы";
            //
            // lblTotalGroupsLabel
            //
            this.lblTotalGroupsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalGroupsLabel.AutoSize = true;
            this.lblTotalGroupsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalGroupsLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalGroupsLabel.Location = new System.Drawing.Point(660, 10);
            this.lblTotalGroupsLabel.Name = "lblTotalGroupsLabel";
            this.lblTotalGroupsLabel.Text = "👥 Всего групп:";
            //
            // lblTotalGroupsValue
            //
            this.lblTotalGroupsValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalGroupsValue.AutoSize = true;
            this.lblTotalGroupsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalGroupsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalGroupsValue.Location = new System.Drawing.Point(780, 10);
            this.lblTotalGroupsValue.Name = "lblTotalGroupsValue";
            this.lblTotalGroupsValue.Text = "0";
            //
            // dataGridViewGroups
            //
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewGroups.ColumnHeadersHeight = 36;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colName, this.colSubGroup, this.colStudents, this.colAvgGrade, this.colOpen });
            this.dataGridViewGroups.EnableHeadersVisualStyles = false;
            this.dataGridViewGroups.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewGroups.GridColor = System.Drawing.Color.FromArgb(40, 44, 68);
            this.dataGridViewGroups.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewGroups.MultiSelect = false;
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.RowTemplate.Height = 48;
            this.dataGridViewGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.Size = new System.Drawing.Size(836, 370);
            // Styles
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 22, 40);
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dataGridViewGroups.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewGroups.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewGroups.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(50, 80, 140);
            this.dataGridViewGroups.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewGroups.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dataGridViewGroups.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 32, 52);
            //
            // colName
            //
            this.colName.FillWeight = 30F;
            this.colName.HeaderText = "Группа";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            //
            // colSubGroup
            //
            this.colSubGroup.FillWeight = 25F;
            this.colSubGroup.HeaderText = "Подгруппа";
            this.colSubGroup.Name = "colSubGroup";
            this.colSubGroup.ReadOnly = true;
            //
            // colStudents
            //
            this.colStudents.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStudents.FillWeight = 25F;
            this.colStudents.HeaderText = "Студентов";
            this.colStudents.Name = "colStudents";
            this.colStudents.ReadOnly = true;
            //
            // colAvgGrade
            //
            this.colAvgGrade.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAvgGrade.FillWeight = 25F;
            this.colAvgGrade.HeaderText = "Ср. балл";
            this.colAvgGrade.Name = "colAvgGrade";
            this.colAvgGrade.ReadOnly = true;
            //
            // colOpen
            //
            this.colOpen.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colOpen.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.colOpen.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.colOpen.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(55, 60, 95);
            this.colOpen.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.colOpen.FillWeight = 20F;
            this.colOpen.HeaderText = "";
            this.colOpen.Name = "colOpen";
            this.colOpen.ReadOnly = true;
            this.colOpen.Text = "> Открыть";
            this.colOpen.UseColumnTextForButtonValue = true;
            //
            // panelFooter
            //
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelFooter.Controls.Add(this.lblFooterIcon);
            this.panelFooter.Controls.Add(this.lblFooterTitle);
            this.panelFooter.Controls.Add(this.lblTotalGroupsStat);
            this.panelFooter.Controls.Add(this.lblTotalGroups);
            this.panelFooter.Controls.Add(this.lblTotalStudentsStat);
            this.panelFooter.Controls.Add(this.lblTotalStudents);
            this.panelFooter.Controls.Add(this.lblAvgGradeStat);
            this.panelFooter.Controls.Add(this.lblAvgGrade);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Height = 60;
            this.panelFooter.Name = "panelFooter";
            //
            // lblFooterIcon
            //
            this.lblFooterIcon.AutoSize = true;
            this.lblFooterIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFooterIcon.ForeColor = System.Drawing.Color.FromArgb(100, 140, 200);
            this.lblFooterIcon.Location = new System.Drawing.Point(14, 18);
            this.lblFooterIcon.Name = "lblFooterIcon";
            this.lblFooterIcon.Text = "🎓";
            //
            // lblFooterTitle
            //
            this.lblFooterTitle.AutoSize = true;
            this.lblFooterTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFooterTitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblFooterTitle.Location = new System.Drawing.Point(36, 20);
            this.lblFooterTitle.Name = "lblFooterTitle";
            this.lblFooterTitle.Text = "Сводная статистика";
            //
            // lblTotalGroupsStat
            //
            this.lblTotalGroupsStat.AutoSize = true;
            this.lblTotalGroupsStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalGroupsStat.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalGroupsStat.Location = new System.Drawing.Point(500, 10);
            this.lblTotalGroupsStat.Name = "lblTotalGroupsStat";
            this.lblTotalGroupsStat.Text = "Всего групп";
            //
            // lblTotalGroups
            //
            this.lblTotalGroups.AutoSize = true;
            this.lblTotalGroups.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalGroups.ForeColor = System.Drawing.Color.White;
            this.lblTotalGroups.Location = new System.Drawing.Point(500, 26);
            this.lblTotalGroups.Name = "lblTotalGroups";
            this.lblTotalGroups.Text = "0";
            //
            // lblTotalStudentsStat
            //
            this.lblTotalStudentsStat.AutoSize = true;
            this.lblTotalStudentsStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalStudentsStat.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalStudentsStat.Location = new System.Drawing.Point(620, 10);
            this.lblTotalStudentsStat.Name = "lblTotalStudentsStat";
            this.lblTotalStudentsStat.Text = "Всего студентов";
            //
            // lblTotalStudents
            //
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(620, 26);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Text = "0";
            //
            // lblAvgGradeStat
            //
            this.lblAvgGradeStat.AutoSize = true;
            this.lblAvgGradeStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvgGradeStat.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblAvgGradeStat.Location = new System.Drawing.Point(750, 10);
            this.lblAvgGradeStat.Name = "lblAvgGradeStat";
            this.lblAvgGradeStat.Text = "Средний балл";
            //
            // lblAvgGrade
            //
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.White;
            this.lblAvgGrade.Location = new System.Drawing.Point(750, 26);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Text = "—";
            //
            // btnOpen (скрытая вспомогательная кнопка)
            //
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Visible = false;
            //
            // FormGroups
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.ClientSize = new System.Drawing.Size(860, 620);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(860, 620);
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета студентов";
            // Events
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.dataGridViewGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellDoubleClick);
            this.dataGridViewGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellClick);
            this.dataGridViewGroups.SelectionChanged += new System.EventHandler(this.dataGridViewGroups_SelectionChanged);
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblGroupsTitle;
        private System.Windows.Forms.Label lblTotalGroupsLabel;
        private System.Windows.Forms.Label lblTotalGroupsValue;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvgGrade;
        private System.Windows.Forms.DataGridViewButtonColumn colOpen;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblFooterIcon;
        private System.Windows.Forms.Label lblFooterTitle;
        private System.Windows.Forms.Label lblTotalGroupsStat;
        private System.Windows.Forms.Label lblTotalGroups;
        private System.Windows.Forms.Label lblTotalStudentsStat;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblAvgGradeStat;
        private System.Windows.Forms.Label lblAvgGrade;
        private System.Windows.Forms.Button btnOpen;
    }
}
