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
            this.components = new System.ComponentModel.Container();
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
            this.lblStudentsTitle = new System.Windows.Forms.Label();
            this.lblAvgGradeLabel = new System.Windows.Forms.Label();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvgGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCard = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblExcellentLabel = new System.Windows.Forms.Label();
            this.lblExcellent = new System.Windows.Forms.Label();
            this.lblDebtorsLabel = new System.Windows.Forms.Label();
            this.lblDebtors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
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
            this.panelHeader.Height = 68;
            this.panelHeader.Name = "panelHeader";
            //
            // btnBack
            //
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnBack.FlatAppearance.BorderSize = 1;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnBack.Location = new System.Drawing.Point(12, 20);
            this.btnBack.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnBack.Text = "← Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            //
            // lblGroupTitle
            //
            this.lblGroupTitle.AutoSize = true;
            this.lblGroupTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGroupTitle.ForeColor = System.Drawing.Color.White;
            this.lblGroupTitle.Location = new System.Drawing.Point(110, 12);
            this.lblGroupTitle.Name = "lblGroupTitle";
            this.lblGroupTitle.Text = "Группа";
            //
            // lblGroupSubtitle
            //
            this.lblGroupSubtitle.AutoSize = true;
            this.lblGroupSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGroupSubtitle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblGroupSubtitle.Location = new System.Drawing.Point(112, 40);
            this.lblGroupSubtitle.Name = "lblGroupSubtitle";
            this.lblGroupSubtitle.Text = "Список студентов и успеваемость";
            //
            // lblStudentCount
            //
            this.lblStudentCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblStudentCount.AutoSize = true;
            this.lblStudentCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStudentCount.ForeColor = System.Drawing.Color.FromArgb(100, 149, 237);
            this.lblStudentCount.Location = new System.Drawing.Point(800, 24);
            this.lblStudentCount.Name = "lblStudentCount";
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
            this.panelSearch.Height = 100;
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
            this.lblSearchTitle.Text = "Поиск студента";
            //
            // txtSearch
            //
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtSearch.Location = new System.Drawing.Point(12, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(700, 30);
            //
            // cmbSearchField
            //
            this.cmbSearchField.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.cmbSearchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSearchField.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.cmbSearchField.Items.AddRange(new object[] { "Все поля", "Фамилия", "Имя", "Отчество" });
            this.cmbSearchField.Location = new System.Drawing.Point(12, 70);
            this.cmbSearchField.Name = "cmbSearchField";
            this.cmbSearchField.SelectedIndex = 0;
            this.cmbSearchField.Size = new System.Drawing.Size(140, 26);
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
            this.btnSearch.Location = new System.Drawing.Point(720, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 30);
            this.btnSearch.Text = "🔍  Найти";
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.panelToolbar.Height = 52;
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            //
            // btnAddStudent
            //
            this.btnAddStudent.AutoSize = true;
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnAddStudent.FlatAppearance.BorderSize = 1;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnAddStudent.Location = new System.Drawing.Point(12, 12);
            this.btnAddStudent.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddStudent.Text = "+ Добавить";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            //
            // btnEditStudent
            //
            this.btnEditStudent.AutoSize = true;
            this.btnEditStudent.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditStudent.Enabled = false;
            this.btnEditStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnEditStudent.FlatAppearance.BorderSize = 1;
            this.btnEditStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditStudent.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnEditStudent.Location = new System.Drawing.Point(122, 12);
            this.btnEditStudent.MinimumSize = new System.Drawing.Size(120, 30);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnEditStudent.Text = "✎ Редактировать";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            //
            // btnDeleteStudent
            //
            this.btnDeleteStudent.AutoSize = true;
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStudent.Enabled = false;
            this.btnDeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnDeleteStudent.FlatAppearance.BorderSize = 1;
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnDeleteStudent.Location = new System.Drawing.Point(252, 12);
            this.btnDeleteStudent.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnDeleteStudent.Text = "🗑 Удалить";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
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
            this.btnExcel.Location = new System.Drawing.Point(362, 12);
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
            this.btnPdf.Location = new System.Drawing.Point(452, 12);
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
            this.btnWord.Location = new System.Drawing.Point(542, 12);
            this.btnWord.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnWord.Name = "btnWord";
            this.btnWord.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            //
            // lblStudentsTitle
            //
            this.lblStudentsTitle.AutoSize = true;
            this.lblStudentsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStudentsTitle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblStudentsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblStudentsTitle.Name = "lblStudentsTitle";
            this.lblStudentsTitle.Text = "Студенты группы";
            //
            // lblAvgGradeLabel
            //
            this.lblAvgGradeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgGradeLabel.AutoSize = true;
            this.lblAvgGradeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvgGradeLabel.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblAvgGradeLabel.Location = new System.Drawing.Point(660, 10);
            this.lblAvgGradeLabel.Name = "lblAvgGradeLabel";
            this.lblAvgGradeLabel.Text = "● Средний балл группы:";
            //
            // lblAvgGrade
            //
            this.lblAvgGrade.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.White;
            this.lblAvgGrade.Location = new System.Drawing.Point(830, 10);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Text = "—";
            //
            // dataGridViewStudents
            //
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.BackgroundColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStudents.ColumnHeadersHeight = 36;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colNum, this.colLastName, this.colFirstName, this.colMiddleName, this.colAvgGrade, this.colStatus, this.colCard });
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewStudents.GridColor = System.Drawing.Color.FromArgb(40, 44, 68);
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 32);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.RowTemplate.Height = 48;
            this.dataGridViewStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(896, 390);
            // Styles
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 22, 40);
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewStudents.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGridViewStudents.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewStudents.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewStudents.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(50, 80, 140);
            this.dataGridViewStudents.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewStudents.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGridViewStudents.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 32, 52);
            //
            // colNum
            //
            this.colNum.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNum.FillWeight = 8F;
            this.colNum.HeaderText = "№";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            //
            // colLastName
            //
            this.colLastName.FillWeight = 22F;
            this.colLastName.HeaderText = "Фамилия";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            //
            // colFirstName
            //
            this.colFirstName.FillWeight = 18F;
            this.colFirstName.HeaderText = "Имя";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            //
            // colMiddleName
            //
            this.colMiddleName.FillWeight = 22F;
            this.colMiddleName.HeaderText = "Отчество";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.ReadOnly = true;
            //
            // colAvgGrade
            //
            this.colAvgGrade.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAvgGrade.FillWeight = 15F;
            this.colAvgGrade.HeaderText = "Ср. балл";
            this.colAvgGrade.Name = "colAvgGrade";
            this.colAvgGrade.ReadOnly = true;
            //
            // colStatus
            //
            this.colStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStatus.FillWeight = 15F;
            this.colStatus.HeaderText = "Статус";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            //
            // colCard
            //
            this.colCard.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCard.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.colCard.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.colCard.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(55, 60, 95);
            this.colCard.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.colCard.FillWeight = 16F;
            this.colCard.HeaderText = "";
            this.colCard.Name = "colCard";
            this.colCard.ReadOnly = true;
            this.colCard.Text = "> Карточка";
            this.colCard.UseColumnTextForButtonValue = true;
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
            this.panelFooter.Height = 60;
            this.panelFooter.Name = "panelFooter";
            //
            // lblTotalLabel
            //
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblTotalLabel.Location = new System.Drawing.Point(480, 10);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Text = "Всего студентов";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(480, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Text = "0";
            //
            // lblExcellentLabel
            //
            this.lblExcellentLabel.AutoSize = true;
            this.lblExcellentLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblExcellentLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblExcellentLabel.Location = new System.Drawing.Point(630, 10);
            this.lblExcellentLabel.Name = "lblExcellentLabel";
            this.lblExcellentLabel.Text = "Отличников";
            //
            // lblExcellent
            //
            this.lblExcellent.AutoSize = true;
            this.lblExcellent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblExcellent.ForeColor = System.Drawing.Color.White;
            this.lblExcellent.Location = new System.Drawing.Point(630, 26);
            this.lblExcellent.Name = "lblExcellent";
            this.lblExcellent.Text = "0";
            //
            // lblDebtorsLabel
            //
            this.lblDebtorsLabel.AutoSize = true;
            this.lblDebtorsLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDebtorsLabel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblDebtorsLabel.Location = new System.Drawing.Point(770, 10);
            this.lblDebtorsLabel.Name = "lblDebtorsLabel";
            this.lblDebtorsLabel.Text = "Должников";
            //
            // lblDebtors
            //
            this.lblDebtors.AutoSize = true;
            this.lblDebtors.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDebtors.ForeColor = System.Drawing.Color.White;
            this.lblDebtors.Location = new System.Drawing.Point(770, 26);
            this.lblDebtors.Name = "lblDebtors";
            this.lblDebtors.Text = "0";
            //
            // FormStudents
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.ClientSize = new System.Drawing.Size(920, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(920, 620);
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты группы";
            // Events
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.dataGridViewStudents_SelectionChanged);
            this.dataGridViewStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellDoubleClick);
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            this.dataGridViewStudents.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewStudents_RowPrePaint);
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvgGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colCard;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblExcellentLabel;
        private System.Windows.Forms.Label lblExcellent;
        private System.Windows.Forms.Label lblDebtorsLabel;
        private System.Windows.Forms.Label lblDebtors;
    }
}
