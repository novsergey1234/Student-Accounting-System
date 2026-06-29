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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvgGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalGroupsValue = new System.Windows.Forms.Label();
            this.lblTotalGroupsLabel = new System.Windows.Forms.Label();
            this.lblGroupsTitle = new System.Windows.Forms.Label();
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
            this.panelHeader.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(960, 60);
            this.panelHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 25);
            this.lblTitle.TabIndex = 0;
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
            this.panelToolbar.Location = new System.Drawing.Point(0, 60);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.panelToolbar.Size = new System.Drawing.Size(960, 42);
            this.panelToolbar.TabIndex = 2;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AutoSize = true;
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddGroup.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnAddGroup.Location = new System.Drawing.Point(12, 6);
            this.btnAddGroup.MinimumSize = new System.Drawing.Size(120, 28);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddGroup.Size = new System.Drawing.Size(140, 28);
            this.btnAddGroup.TabIndex = 0;
            this.btnAddGroup.Text = "+ Добавить группу";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.AutoSize = true;
            this.btnEditGroup.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGroup.Enabled = false;
            this.btnEditGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditGroup.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnEditGroup.Location = new System.Drawing.Point(160, 6);
            this.btnEditGroup.MinimumSize = new System.Drawing.Size(120, 28);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnEditGroup.Size = new System.Drawing.Size(120, 28);
            this.btnEditGroup.TabIndex = 1;
            this.btnEditGroup.Text = "✎ Редактировать";
            this.btnEditGroup.UseVisualStyleBackColor = false;
            this.btnEditGroup.Click += new System.EventHandler(this.btnEditGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.AutoSize = true;
            this.btnDeleteGroup.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnDeleteGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnDeleteGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGroup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteGroup.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnDeleteGroup.Location = new System.Drawing.Point(288, 6);
            this.btnDeleteGroup.MinimumSize = new System.Drawing.Size(100, 28);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnDeleteGroup.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteGroup.TabIndex = 2;
            this.btnDeleteGroup.Text = "🗑 Удалить";
            this.btnDeleteGroup.UseVisualStyleBackColor = false;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnExcel.AutoSize = true;
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnExcel.Location = new System.Drawing.Point(620, 6);
            this.btnExcel.MinimumSize = new System.Drawing.Size(80, 28);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnExcel.Size = new System.Drawing.Size(80, 28);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "⊞ Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnPdf.AutoSize = true;
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdf.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnPdf.Location = new System.Drawing.Point(710, 6);
            this.btnPdf.MinimumSize = new System.Drawing.Size(80, 28);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnPdf.Size = new System.Drawing.Size(80, 28);
            this.btnPdf.TabIndex = 4;
            this.btnPdf.Text = "⊟ PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            // 
            // btnWord
            // 
            this.btnWord.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnWord.AutoSize = true;
            this.btnWord.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWord.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnWord.Location = new System.Drawing.Point(800, 6);
            this.btnWord.MinimumSize = new System.Drawing.Size(80, 28);
            this.btnWord.Name = "btnWord";
            this.btnWord.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnWord.Size = new System.Drawing.Size(80, 28);
            this.btnWord.TabIndex = 5;
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
            this.panelSearch.Location = new System.Drawing.Point(0, 102);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(960, 50);
            this.panelSearch.TabIndex = 1;
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblSearchIcon.Location = new System.Drawing.Point(12, 4);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(20, 19);
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "🔍";
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchTitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblSearchTitle.Location = new System.Drawing.Point(36, 5);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(90, 15);
            this.lblSearchTitle.TabIndex = 1;
            this.lblSearchTitle.Text = "Поиск группы";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtSearch.Location = new System.Drawing.Point(12, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(760, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnSearch.Location = new System.Drawing.Point(780, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "🔍  Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelContent.Controls.Add(this.dataGridViewGroups);
            this.panelContent.Controls.Add(this.lblTotalGroupsValue);
            this.panelContent.Controls.Add(this.lblTotalGroupsLabel);
            this.panelContent.Controls.Add(this.lblGroupsTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 152);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelContent.Size = new System.Drawing.Size(960, 448);
            this.panelContent.TabIndex = 0;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(30, 32, 52);
            this.dataGridViewGroups.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewGroups.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.BackgroundColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewGroups.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGroups.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGroups.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(20, 22, 40);
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGroups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewGroups.ColumnHeadersHeight = 36;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSubGroup,
            this.colStudents,
            this.colAvgGrade});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(50, 80, 140);
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGroups.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewGroups.EnableHeadersVisualStyles = false;
            this.dataGridViewGroups.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewGroups.GridColor = System.Drawing.Color.FromArgb(40, 44, 68);
            this.dataGridViewGroups.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewGroups.MultiSelect = false;
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.RowHeadersWidth = 82;
            this.dataGridViewGroups.RowTemplate.Height = 36;
            this.dataGridViewGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.Size = new System.Drawing.Size(936, 400);
            this.dataGridViewGroups.TabIndex = 0;
            this.dataGridViewGroups.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellDoubleClick);
            this.dataGridViewGroups.SelectionChanged += new System.EventHandler(this.dataGridViewGroups_SelectionChanged);
            // 
            // colName
            // 
            this.colName.FillWeight = 30F;
            this.colName.HeaderText = "Группа";
            this.colName.MinimumWidth = 10;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSubGroup
            // 
            this.colSubGroup.FillWeight = 25F;
            this.colSubGroup.HeaderText = "Подгруппа";
            this.colSubGroup.MinimumWidth = 10;
            this.colSubGroup.Name = "colSubGroup";
            this.colSubGroup.ReadOnly = true;
            // 
            // colStudents
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStudents.DefaultCellStyle = dataGridViewCellStyle18;
            this.colStudents.FillWeight = 25F;
            this.colStudents.HeaderText = "Студентов";
            this.colStudents.MinimumWidth = 10;
            this.colStudents.Name = "colStudents";
            this.colStudents.ReadOnly = true;
            // 
            // colAvgGrade
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAvgGrade.DefaultCellStyle = dataGridViewCellStyle19;
            this.colAvgGrade.FillWeight = 25F;
            this.colAvgGrade.HeaderText = "Ср. балл";
            this.colAvgGrade.MinimumWidth = 10;
            this.colAvgGrade.Name = "colAvgGrade";
            this.colAvgGrade.ReadOnly = true;
            // 
            // lblTotalGroupsValue
            // 
            this.lblTotalGroupsValue.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalGroupsValue.AutoSize = true;
            this.lblTotalGroupsValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalGroupsValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalGroupsValue.Location = new System.Drawing.Point(910, 12);
            this.lblTotalGroupsValue.Name = "lblTotalGroupsValue";
            this.lblTotalGroupsValue.Size = new System.Drawing.Size(14, 15);
            this.lblTotalGroupsValue.TabIndex = 1;
            this.lblTotalGroupsValue.Text = "0";
            // 
            // lblTotalGroupsLabel
            // 
            this.lblTotalGroupsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblTotalGroupsLabel.AutoSize = true;
            this.lblTotalGroupsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTotalGroupsLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalGroupsLabel.Location = new System.Drawing.Point(800, 12);
            this.lblTotalGroupsLabel.Name = "lblTotalGroupsLabel";
            this.lblTotalGroupsLabel.Size = new System.Drawing.Size(110, 15);
            this.lblTotalGroupsLabel.TabIndex = 2;
            this.lblTotalGroupsLabel.Text = "👥 Всего групп:";
            // 
            // lblGroupsTitle
            // 
            this.lblGroupsTitle.AutoSize = true;
            this.lblGroupsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGroupsTitle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblGroupsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblGroupsTitle.Name = "lblGroupsTitle";
            this.lblGroupsTitle.Size = new System.Drawing.Size(120, 19);
            this.lblGroupsTitle.TabIndex = 3;
            this.lblGroupsTitle.Text = "Учебные группы";
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
            this.panelFooter.Location = new System.Drawing.Point(0, 600);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(960, 50);
            this.panelFooter.TabIndex = 4;
            // 
            // lblFooterIcon
            // 
            this.lblFooterIcon.AutoSize = true;
            this.lblFooterIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFooterIcon.ForeColor = System.Drawing.Color.FromArgb(100, 140, 200);
            this.lblFooterIcon.Location = new System.Drawing.Point(12, 14);
            this.lblFooterIcon.Name = "lblFooterIcon";
            this.lblFooterIcon.Size = new System.Drawing.Size(32, 21);
            this.lblFooterIcon.TabIndex = 0;
            this.lblFooterIcon.Text = "🎓";
            // 
            // lblFooterTitle
            // 
            this.lblFooterTitle.AutoSize = true;
            this.lblFooterTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFooterTitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblFooterTitle.Location = new System.Drawing.Point(48, 18);
            this.lblFooterTitle.Name = "lblFooterTitle";
            this.lblFooterTitle.Size = new System.Drawing.Size(140, 15);
            this.lblFooterTitle.TabIndex = 1;
            this.lblFooterTitle.Text = "Сводная статистика";
            // 
            // lblTotalGroupsStat
            // 
            this.lblTotalGroupsStat.AutoSize = true;
            this.lblTotalGroupsStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalGroupsStat.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalGroupsStat.Location = new System.Drawing.Point(400, 8);
            this.lblTotalGroupsStat.Name = "lblTotalGroupsStat";
            this.lblTotalGroupsStat.Size = new System.Drawing.Size(76, 13);
            this.lblTotalGroupsStat.TabIndex = 2;
            this.lblTotalGroupsStat.Text = "Всего групп";
            // 
            // lblTotalGroups
            // 
            this.lblTotalGroups.AutoSize = true;
            this.lblTotalGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalGroups.ForeColor = System.Drawing.Color.White;
            this.lblTotalGroups.Location = new System.Drawing.Point(400, 24);
            this.lblTotalGroups.Name = "lblTotalGroups";
            this.lblTotalGroups.Size = new System.Drawing.Size(18, 21);
            this.lblTotalGroups.TabIndex = 3;
            this.lblTotalGroups.Text = "0";
            // 
            // lblTotalStudentsStat
            // 
            this.lblTotalStudentsStat.AutoSize = true;
            this.lblTotalStudentsStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalStudentsStat.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalStudentsStat.Location = new System.Drawing.Point(520, 8);
            this.lblTotalStudentsStat.Name = "lblTotalStudentsStat";
            this.lblTotalStudentsStat.Size = new System.Drawing.Size(100, 13);
            this.lblTotalStudentsStat.TabIndex = 4;
            this.lblTotalStudentsStat.Text = "Всего студентов";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalStudents.ForeColor = System.Drawing.Color.White;
            this.lblTotalStudents.Location = new System.Drawing.Point(520, 24);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(18, 21);
            this.lblTotalStudents.TabIndex = 5;
            this.lblTotalStudents.Text = "0";
            // 
            // lblAvgGradeStat
            // 
            this.lblAvgGradeStat.AutoSize = true;
            this.lblAvgGradeStat.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvgGradeStat.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblAvgGradeStat.Location = new System.Drawing.Point(650, 8);
            this.lblAvgGradeStat.Name = "lblAvgGradeStat";
            this.lblAvgGradeStat.Size = new System.Drawing.Size(79, 13);
            this.lblAvgGradeStat.TabIndex = 6;
            this.lblAvgGradeStat.Text = "Средний балл";
            // 
            // lblAvgGrade
            // 
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.White;
            this.lblAvgGrade.Location = new System.Drawing.Point(650, 24);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Size = new System.Drawing.Size(25, 21);
            this.lblAvgGrade.TabIndex = 7;
            this.lblAvgGrade.Text = "—";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Visible = false;
            // 
            // FormGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.btnOpen);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(960, 650);
            this.Name = "FormGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система учета студентов";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
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
