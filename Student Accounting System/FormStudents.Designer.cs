namespace Student_Accounting_System
{
    partial class FormStudents
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGroupTitle = new System.Windows.Forms.Label();
            this.lblGroupSubtitle = new System.Windows.Forms.Label();
            this.lblStudentCount = new System.Windows.Forms.Label();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchField = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvgGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.lblAvgGradeLabel = new System.Windows.Forms.Label();
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblExcellentLabel = new System.Windows.Forms.Label();
            this.lblExcellent = new System.Windows.Forms.Label();
            this.lblDebtorsLabel = new System.Windows.Forms.Label();
            this.lblDebtors = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblGroupTitle);
            this.panelHeader.Controls.Add(this.lblGroupSubtitle);
            this.panelHeader.Controls.Add(this.lblStudentCount);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(960, 60);
            this.panelHeader.TabIndex = 3;
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
            this.lblGroupTitle.Location = new System.Drawing.Point(120, 10);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Size = new System.Drawing.Size(80, 25);
            this.lblGroupTitle.TabIndex = 1;
            this.lblGroupTitle.Text = "Группа";
            // 
            // lblGroupSubtitle
            // 
            this.lblGroupSubtitle.AutoSize = true;
            this.lblGroupSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGroupSubtitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblGroupSubtitle.Location = new System.Drawing.Point(120, 35);
            this.lblGroupSubtitle.Name = "lblGroupSubtitle";
            this.lblGroupSubtitle.Size = new System.Drawing.Size(200, 15);
            this.lblGroupSubtitle.TabIndex = 2;
            this.lblGroupSubtitle.Text = "Список студентов и успеваемость";
            // 
            // lblStudentCount
            // 
            this.lblStudentCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentCount.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
            this.lblStudentCount.Location = new System.Drawing.Point(830, 22);
            this.lblStudentCount.Name = "lblStudentCount";
            this.lblStudentCount.Size = new System.Drawing.Size(100, 15);
            this.lblStudentCount.TabIndex = 3;
            this.lblStudentCount.Text = "0 студентов";
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.panelSearch.Controls.Add(this.lblSearchIcon);
            this.panelSearch.Controls.Add(this.lblSearchTitle);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Controls.Add(this.cmbSearchField);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 60);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(960, 50);
            this.panelSearch.TabIndex = 2;
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
            this.lblSearchTitle.Size = new System.Drawing.Size(120, 15);
            this.lblSearchTitle.TabIndex = 1;
            this.lblSearchTitle.Text = "Поиск студента";
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
            this.txtSearch.Size = new System.Drawing.Size(580, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cmbSearchField
            // 
            this.cmbSearchField.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.cmbSearchField.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.cmbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSearchField.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.cmbSearchField.Items.AddRange(new object[] {
            "Все поля",
            "Фамилия",
            "Имя",
            "Отчество"});
            this.cmbSearchField.Location = new System.Drawing.Point(610, 24);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.Size = new System.Drawing.Size(140, 23);
            this.cmbSearchField.TabIndex = 3;
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
            this.btnSearch.Location = new System.Drawing.Point(760, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍  Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.panelToolbar.Controls.Add(this.btnAddStudent);
            this.panelToolbar.Controls.Add(this.btnEditStudent);
            this.panelToolbar.Controls.Add(this.btnDeleteStudent);
            this.panelToolbar.Controls.Add(this.btnExcel);
            this.panelToolbar.Controls.Add(this.btnPdf);
            this.panelToolbar.Controls.Add(this.btnWord);
            this.panelToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelToolbar.Location = new System.Drawing.Point(0, 110);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.panelToolbar.Size = new System.Drawing.Size(960, 42);
            this.panelToolbar.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AutoSize = true;
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnAddStudent.Location = new System.Drawing.Point(12, 6);
            this.btnAddStudent.MinimumSize = new System.Drawing.Size(100, 28);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddStudent.Size = new System.Drawing.Size(100, 28);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "+ Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.AutoSize = true;
            this.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStudent.Enabled = false;
            this.btnEditStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditStudent.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnEditStudent.Location = new System.Drawing.Point(120, 6);
            this.btnEditStudent.MinimumSize = new System.Drawing.Size(120, 28);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnEditStudent.Size = new System.Drawing.Size(120, 28);
            this.btnEditStudent.TabIndex = 1;
            this.btnEditStudent.Text = "✎ Редактировать";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.AutoSize = true;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnDeleteStudent.Location = new System.Drawing.Point(250, 6);
            this.btnDeleteStudent.MinimumSize = new System.Drawing.Size(100, 28);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnDeleteStudent.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "🗑 Удалить";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
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
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelContent.Controls.Add(this.dataGridViewStudents);
            this.panelContent.Controls.Add(this.lblAvgGrade);
            this.panelContent.Controls.Add(this.lblAvgGradeLabel);
            this.panelContent.Controls.Add(this.lblStudentsTitle);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 152);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.panelContent.Size = new System.Drawing.Size(960, 448);
            this.panelContent.TabIndex = 0;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.AllowUserToResizeColumns = false;
            this.dataGridViewStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 32, 52);
            this.dataGridViewStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(20, 22, 40);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudents.ColumnHeadersHeight = 36;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colLastName,
            this.colFirstName,
            this.colMiddleName,
            this.colSubGroup,
            this.colAvgGrade,
            this.colStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(50, 80, 140);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewStudents.GridColor = System.Drawing.Color.FromArgb(40, 44, 68);
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowHeadersWidth = 82;
            this.dataGridViewStudents.RowTemplate.Height = 36;
            this.dataGridViewStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(936, 400);
            this.dataGridViewStudents.TabIndex = 0;
            this.dataGridViewStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellDoubleClick);
            this.dataGridViewStudents.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewStudents_RowPrePaint);
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            // 
            // colNum
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNum.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNum.FillWeight = 8F;
            this.colNum.HeaderText = "№";
            this.colNum.MinimumWidth = 10;
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.FillWeight = 22F;
            this.colLastName.HeaderText = "Фамилия";
            this.colLastName.MinimumWidth = 10;
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.FillWeight = 18F;
            this.colFirstName.HeaderText = "Имя";
            this.colFirstName.MinimumWidth = 10;
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colMiddleName
            // 
            this.colMiddleName.FillWeight = 22F;
            this.colMiddleName.HeaderText = "Отчество";
            this.colMiddleName.MinimumWidth = 10;
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            // 
            // colSubGroup
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSubGroup.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSubGroup.FillWeight = 10F;
            this.colSubGroup.HeaderText = "Подгруппа";
            this.colSubGroup.MinimumWidth = 10;
            this.colSubGroup.Name = "colSubGroup";
            this.colSubGroup.ReadOnly = true;
            // 
            // colAvgGrade
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAvgGrade.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAvgGrade.FillWeight = 15F;
            this.colAvgGrade.HeaderText = "Ср. балл";
            this.colAvgGrade.MinimumWidth = 10;
            this.colAvgGrade.Name = "colAvgGrade";
            this.colAvgGrade.ReadOnly = true;
            // 
            // colStatus
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStatus.DefaultCellStyle = dataGridViewCellStyle7;
            this.colStatus.FillWeight = 15F;
            this.colStatus.HeaderText = "Статус";
            this.colStatus.MinimumWidth = 10;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // lblAvgGrade
            // 
            this.lblAvgGrade.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.White;
            this.lblAvgGrade.Location = new System.Drawing.Point(880, 12);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Size = new System.Drawing.Size(15, 15);
            this.lblAvgGrade.TabIndex = 1;
            this.lblAvgGrade.Text = "—";
            // 
            // lblAvgGradeLabel
            // 
            this.lblAvgGradeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgGradeLabel.AutoSize = true;
            this.lblAvgGradeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvgGradeLabel.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblAvgGradeLabel.Location = new System.Drawing.Point(730, 12);
            this.lblAvgGradeLabel.Name = "lblAvgGradeLabel";
            this.lblAvgGradeLabel.Size = new System.Drawing.Size(150, 15);
            this.lblAvgGradeLabel.TabIndex = 2;
            this.lblAvgGradeLabel.Text = "● Средний балл группы:";
            // 
            // lblStudentsTitle
            // 
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblStudentsTitle.Location = new System.Drawing.Point(12, 12);
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.Size = new System.Drawing.Size(160, 19);
            this.lblStudentsTitle.TabIndex = 3;
            this.lblStudentsTitle.Text = "Студенты группы";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelFooter.Controls.Add(this.lblTotalLabel);
            this.panelFooter.Controls.Add(this.lblTotal);
            this.panelFooter.Controls.Add(this.lblExcellentLabel);
            this.panelFooter.Controls.Add(this.lblExcellent);
            this.panelFooter.Controls.Add(this.lblDebtorsLabel);
            this.panelFooter.Controls.Add(this.lblDebtors);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 600);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(960, 50);
            this.panelFooter.TabIndex = 4;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalLabel.Location = new System.Drawing.Point(400, 8);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(90, 13);
            this.lblTotalLabel.TabIndex = 0;
            this.lblTotalLabel.Text = "Всего студентов";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(400, 24);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // lblExcellentLabel
            // 
            this.lblExcellentLabel.AutoSize = true;
            this.lblExcellentLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblExcellentLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblExcellentLabel.Location = new System.Drawing.Point(540, 8);
            this.lblExcellentLabel.Name = "lblExcellentLabel";
            this.lblExcellentLabel.Size = new System.Drawing.Size(75, 13);
            this.lblExcellentLabel.TabIndex = 2;
            this.lblExcellentLabel.Text = "Отличников";
            // 
            // lblExcellent
            // 
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExcellent.ForeColor = System.Drawing.Color.White;
            this.lblExcellent.Location = new System.Drawing.Point(540, 24);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Size = new System.Drawing.Size(18, 21);
            this.lblExcellent.TabIndex = 3;
            this.lblExcellent.Text = "0";
            // 
            // lblDebtorsLabel
            // 
            this.lblDebtorsLabel.AutoSize = true;
            this.lblDebtorsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDebtorsLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblDebtorsLabel.Location = new System.Drawing.Point(660, 8);
            this.lblDebtorsLabel.Name = "lblDebtorsLabel";
            this.lblDebtorsLabel.Size = new System.Drawing.Size(70, 13);
            this.lblDebtorsLabel.TabIndex = 4;
            this.lblDebtorsLabel.Text = "Должников";
            // 
            // lblDebtors
            // 
            this.lblDebtors.AutoSize = true;
            this.lblDebtors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDebtors.ForeColor = System.Drawing.Color.White;
            this.lblDebtors.Location = new System.Drawing.Point(660, 24);
            this.lblDebtors.Name = "lblDebtors";
            this.lblDebtors.Size = new System.Drawing.Size(18, 21);
            this.lblDebtors.TabIndex = 5;
            this.lblDebtors.Text = "0";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(860, 550);
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты группы";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGroupTitle;
        private System.Windows.Forms.Label lblGroupSubtitle;
        private System.Windows.Forms.Label lblStudentCount;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchField;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblStudentsTitle;
        private System.Windows.Forms.Label lblAvgGradeLabel;
        private System.Windows.Forms.Label lblAvgGrade;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvgGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblExcellentLabel;
        private System.Windows.Forms.Label lblExcellent;
        private System.Windows.Forms.Label lblDebtorsLabel;
        private System.Windows.Forms.Label lblDebtors;
    }
}
