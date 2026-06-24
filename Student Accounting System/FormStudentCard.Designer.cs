namespace Student_Accounting_System
{
    partial class FormStudentCard
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
            this.tabGrades = new System.Windows.Forms.TabPage();
            // Personal tab
            this.panelPersonalForm = new System.Windows.Forms.Panel();
            this.lblPersonalHeader = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblStatusField = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panelPersonalButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcelPersonal = new System.Windows.Forms.Button();
            this.btnPdfPersonal = new System.Windows.Forms.Button();
            this.btnWordPersonal = new System.Windows.Forms.Button();
            // Grades tab
            this.panelGradesHeader = new System.Windows.Forms.Panel();
            this.lblGradesTitle = new System.Windows.Forms.Label();
            this.lblGradesAvg = new System.Windows.Forms.Label();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGradesButtons = new System.Windows.Forms.Panel();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnExcelGrades = new System.Windows.Forms.Button();
            this.btnPdfGrades = new System.Windows.Forms.Button();
            this.btnWordGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblStudentName);
            this.panelHeader.Controls.Add(this.lblGroupName);
            this.panelHeader.Controls.Add(this.lblAvgGrade);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Height = 72;
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
            this.btnBack.Location = new System.Drawing.Point(12, 22);
            this.btnBack.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnBack.Text = "← Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            //
            // lblStudentName
            //
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(110, 12);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Text = "Студент";
            //
            // lblGroupName
            //
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGroupName.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblGroupName.Location = new System.Drawing.Point(112, 42);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Text = "Группа";
            //
            // lblAvgGrade
            //
            this.lblAvgGrade.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblAvgGrade.Location = new System.Drawing.Point(620, 26);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Text = "Средний балл: —";
            //
            // tabControl
            //
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Normal;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.ItemSize = new System.Drawing.Size(160, 36);
            this.tabControl.Name = "tabControl";
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabPages.AddRange(new System.Windows.Forms.TabPage[] { this.tabPersonal, this.tabGrades });
            //
            // tabPersonal
            //
            this.tabPersonal.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.tabPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabPersonal.Controls.Add(this.panelPersonalForm);
            this.tabPersonal.ForeColor = System.Drawing.Color.White;
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Text = "  👤 Личные данные  ";
            //
            // panelPersonalForm
            //
            this.panelPersonalForm.AutoScroll = true;
            this.panelPersonalForm.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelPersonalForm.Controls.Add(this.lblPersonalHeader);
            this.panelPersonalForm.Controls.Add(this.lblLastName);
            this.panelPersonalForm.Controls.Add(this.txtLastName);
            this.panelPersonalForm.Controls.Add(this.lblFirstName);
            this.panelPersonalForm.Controls.Add(this.txtFirstName);
            this.panelPersonalForm.Controls.Add(this.lblMiddleName);
            this.panelPersonalForm.Controls.Add(this.txtMiddleName);
            this.panelPersonalForm.Controls.Add(this.lblBirthDate);
            this.panelPersonalForm.Controls.Add(this.txtBirthDate);
            this.panelPersonalForm.Controls.Add(this.lblPhone);
            this.panelPersonalForm.Controls.Add(this.txtPhone);
            this.panelPersonalForm.Controls.Add(this.lblEmail);
            this.panelPersonalForm.Controls.Add(this.txtEmail);
            this.panelPersonalForm.Controls.Add(this.lblAddress);
            this.panelPersonalForm.Controls.Add(this.txtAddress);
            this.panelPersonalForm.Controls.Add(this.lblStatusField);
            this.panelPersonalForm.Controls.Add(this.cmbStatus);
            this.panelPersonalForm.Controls.Add(this.panelPersonalButtons);
            this.panelPersonalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPersonalForm.Name = "panelPersonalForm";
            this.panelPersonalForm.Padding = new System.Windows.Forms.Padding(16);
            //
            // lblPersonalHeader
            //
            this.lblPersonalHeader.AutoSize = true;
            this.lblPersonalHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonalHeader.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblPersonalHeader.Location = new System.Drawing.Point(16, 12);
            this.lblPersonalHeader.Name = "lblPersonalHeader";
            this.lblPersonalHeader.Text = "👤  Личные данные";
            //
            // lblLastName
            //
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblLastName.Location = new System.Drawing.Point(16, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Text = "Фамилия";
            //
            // txtLastName
            //
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtLastName.Location = new System.Drawing.Point(16, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(360, 28);
            //
            // lblFirstName
            //
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblFirstName.Location = new System.Drawing.Point(396, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Text = "Имя";
            //
            // txtFirstName
            //
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtFirstName.Location = new System.Drawing.Point(396, 64);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(360, 28);
            //
            // lblMiddleName
            //
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblMiddleName.Location = new System.Drawing.Point(16, 110);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Text = "Отчество";
            //
            // txtMiddleName
            //
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtMiddleName.Location = new System.Drawing.Point(16, 128);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(360, 28);
            //
            // lblBirthDate
            //
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblBirthDate.Location = new System.Drawing.Point(396, 110);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Text = "Дата рождения (дд.мм.гггг)";
            //
            // txtBirthDate  (MaskedTextBox — поддерживает BackColor в отличие от DateTimePicker)
            //
            this.txtBirthDate.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtBirthDate.Location = new System.Drawing.Point(396, 128);
            this.txtBirthDate.Mask = "00.00.0000";
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(360, 28);
            //
            // lblPhone
            //
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblPhone.Location = new System.Drawing.Point(16, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Text = "Телефон";
            //
            // txtPhone
            //
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtPhone.Location = new System.Drawing.Point(16, 192);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(360, 28);
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblEmail.Location = new System.Drawing.Point(396, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtEmail.Location = new System.Drawing.Point(396, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 28);
            //
            // lblAddress
            //
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblAddress.Location = new System.Drawing.Point(16, 238);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Text = "Адрес";
            //
            // txtAddress
            //
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtAddress.Location = new System.Drawing.Point(16, 256);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(740, 28);
            //
            // lblStatusField
            //
            this.lblStatusField.AutoSize = true;
            this.lblStatusField.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusField.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblStatusField.Location = new System.Drawing.Point(16, 302);
            this.lblStatusField.Name = "lblStatusField";
            this.lblStatusField.Text = "Статус";
            //
            // cmbStatus
            //
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.cmbStatus.Items.AddRange(new object[] { "Учится", "Академотпуск", "Должник" });
            this.cmbStatus.Location = new System.Drawing.Point(16, 320);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.SelectedIndex = 0;
            this.cmbStatus.Size = new System.Drawing.Size(360, 28);
            //
            // panelPersonalButtons
            //
            this.panelPersonalButtons.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelPersonalButtons.Controls.Add(this.btnSave);
            this.panelPersonalButtons.Controls.Add(this.btnCancel);
            this.panelPersonalButtons.Controls.Add(this.btnExcelPersonal);
            this.panelPersonalButtons.Controls.Add(this.btnPdfPersonal);
            this.panelPersonalButtons.Controls.Add(this.btnWordPersonal);
            this.panelPersonalButtons.Location = new System.Drawing.Point(16, 368);
            this.panelPersonalButtons.Name = "panelPersonalButtons";
            this.panelPersonalButtons.Size = new System.Drawing.Size(760, 40);
            //
            // btnSave
            //
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnSave.FlatAppearance.BorderSize = 1;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnSave.Location = new System.Drawing.Point(0, 4);
            this.btnSave.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            //
            // btnCancel
            //
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnCancel.Location = new System.Drawing.Point(120, 4);
            this.btnCancel.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnCancel.Text = "✕ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            //
            // btnExcelPersonal
            //
            this.btnExcelPersonal.AutoSize = true;
            this.btnExcelPersonal.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnExcelPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnExcelPersonal.FlatAppearance.BorderSize = 1;
            this.btnExcelPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcelPersonal.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnExcelPersonal.Location = new System.Drawing.Point(390, 4);
            this.btnExcelPersonal.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnExcelPersonal.Name = "btnExcelPersonal";
            this.btnExcelPersonal.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnExcelPersonal.Text = "⊞ Excel";
            this.btnExcelPersonal.UseVisualStyleBackColor = false;
            //
            // btnPdfPersonal
            //
            this.btnPdfPersonal.AutoSize = true;
            this.btnPdfPersonal.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnPdfPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnPdfPersonal.FlatAppearance.BorderSize = 1;
            this.btnPdfPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdfPersonal.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnPdfPersonal.Location = new System.Drawing.Point(480, 4);
            this.btnPdfPersonal.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnPdfPersonal.Name = "btnPdfPersonal";
            this.btnPdfPersonal.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnPdfPersonal.Text = "⊟ PDF";
            this.btnPdfPersonal.UseVisualStyleBackColor = false;
            //
            // btnWordPersonal
            //
            this.btnWordPersonal.AutoSize = true;
            this.btnWordPersonal.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnWordPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnWordPersonal.FlatAppearance.BorderSize = 1;
            this.btnWordPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWordPersonal.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnWordPersonal.Location = new System.Drawing.Point(570, 4);
            this.btnWordPersonal.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnWordPersonal.Name = "btnWordPersonal";
            this.btnWordPersonal.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnWordPersonal.Text = "⊡ Word";
            this.btnWordPersonal.UseVisualStyleBackColor = false;
            //
            // tabGrades
            //
            this.tabGrades.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.tabGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabGrades.Controls.Add(this.dataGridViewGrades);
            this.tabGrades.Controls.Add(this.panelGradesHeader);
            this.tabGrades.Controls.Add(this.panelGradesButtons);
            this.tabGrades.ForeColor = System.Drawing.Color.White;
            this.tabGrades.Name = "tabGrades";
            this.tabGrades.Text = "  📊 Оценки  ";
            //
            // panelGradesHeader
            //
            this.panelGradesHeader.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelGradesHeader.Controls.Add(this.lblGradesTitle);
            this.panelGradesHeader.Controls.Add(this.lblGradesAvg);
            this.panelGradesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGradesHeader.Height = 36;
            this.panelGradesHeader.Name = "panelGradesHeader";
            //
            // lblGradesTitle
            //
            this.lblGradesTitle.AutoSize = true;
            this.lblGradesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGradesTitle.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.lblGradesTitle.Location = new System.Drawing.Point(12, 8);
            this.lblGradesTitle.Name = "lblGradesTitle";
            this.lblGradesTitle.Text = "📊  Успеваемость";
            //
            // lblGradesAvg
            //
            this.lblGradesAvg.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblGradesAvg.AutoSize = true;
            this.lblGradesAvg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGradesAvg.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.lblGradesAvg.Location = new System.Drawing.Point(570, 10);
            this.lblGradesAvg.Name = "lblGradesAvg";
            this.lblGradesAvg.Text = "Средний балл: —";
            //
            // dataGridViewGrades
            //
            this.dataGridViewGrades.AllowUserToAddRows = false;
            this.dataGridViewGrades.AllowUserToDeleteRows = false;
            this.dataGridViewGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrades.BackgroundColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewGrades.ColumnHeadersHeight = 36;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colSubject, this.colSem1, this.colSem2, this.colFinal });
            this.dataGridViewGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGrades.EnableHeadersVisualStyles = false;
            this.dataGridViewGrades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewGrades.GridColor = System.Drawing.Color.FromArgb(40, 44, 68);
            this.dataGridViewGrades.MultiSelect = false;
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersVisible = false;
            this.dataGridViewGrades.RowTemplate.Height = 48;
            this.dataGridViewGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // Styles
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 22, 40);
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGridViewGrades.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 28, 46);
            this.dataGridViewGrades.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewGrades.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(50, 80, 140);
            this.dataGridViewGrades.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewGrades.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.dataGridViewGrades.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 32, 52);
            //
            // colSubject
            //
            this.colSubject.FillWeight = 40F;
            this.colSubject.HeaderText = "Предмет";
            this.colSubject.Name = "colSubject";
            //
            // colSem1
            //
            this.colSem1.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSem1.FillWeight = 20F;
            this.colSem1.HeaderText = "1 семестр";
            this.colSem1.Name = "colSem1";
            //
            // colSem2
            //
            this.colSem2.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSem2.FillWeight = 20F;
            this.colSem2.HeaderText = "2 семестр";
            this.colSem2.Name = "colSem2";
            //
            // colFinal
            //
            this.colFinal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFinal.FillWeight = 20F;
            this.colFinal.HeaderText = "Итог";
            this.colFinal.Name = "colFinal";
            //
            // panelGradesButtons
            //
            this.panelGradesButtons.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.panelGradesButtons.Controls.Add(this.btnAddSubject);
            this.panelGradesButtons.Controls.Add(this.btnDeleteSubject);
            this.panelGradesButtons.Controls.Add(this.btnExcelGrades);
            this.panelGradesButtons.Controls.Add(this.btnPdfGrades);
            this.panelGradesButtons.Controls.Add(this.btnWordGrades);
            this.panelGradesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGradesButtons.Height = 50;
            this.panelGradesButtons.Name = "panelGradesButtons";
            this.panelGradesButtons.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            //
            // btnAddSubject
            //
            this.btnAddSubject.AutoSize = true;
            this.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnAddSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnAddSubject.FlatAppearance.BorderSize = 1;
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSubject.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnAddSubject.Location = new System.Drawing.Point(8, 10);
            this.btnAddSubject.MinimumSize = new System.Drawing.Size(130, 30);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddSubject.Text = "+ Добавить предмет";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            //
            // btnDeleteSubject
            //
            this.btnDeleteSubject.AutoSize = true;
            this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnDeleteSubject.FlatAppearance.BorderSize = 1;
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnDeleteSubject.Location = new System.Drawing.Point(148, 10);
            this.btnDeleteSubject.MinimumSize = new System.Drawing.Size(130, 30);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnDeleteSubject.Text = "🗑 Удалить предмет";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            //
            // btnExcelGrades
            //
            this.btnExcelGrades.AutoSize = true;
            this.btnExcelGrades.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnExcelGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnExcelGrades.FlatAppearance.BorderSize = 1;
            this.btnExcelGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcelGrades.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnExcelGrades.Location = new System.Drawing.Point(390, 10);
            this.btnExcelGrades.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnExcelGrades.Name = "btnExcelGrades";
            this.btnExcelGrades.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnExcelGrades.Text = "⊞ Excel";
            this.btnExcelGrades.UseVisualStyleBackColor = false;
            //
            // btnPdfGrades
            //
            this.btnPdfGrades.AutoSize = true;
            this.btnPdfGrades.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnPdfGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnPdfGrades.FlatAppearance.BorderSize = 1;
            this.btnPdfGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdfGrades.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnPdfGrades.Location = new System.Drawing.Point(480, 10);
            this.btnPdfGrades.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnPdfGrades.Name = "btnPdfGrades";
            this.btnPdfGrades.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnPdfGrades.Text = "⊟ PDF";
            this.btnPdfGrades.UseVisualStyleBackColor = false;
            //
            // btnWordGrades
            //
            this.btnWordGrades.AutoSize = true;
            this.btnWordGrades.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnWordGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnWordGrades.FlatAppearance.BorderSize = 1;
            this.btnWordGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWordGrades.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnWordGrades.Location = new System.Drawing.Point(570, 10);
            this.btnWordGrades.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnWordGrades.Name = "btnWordGrades";
            this.btnWordGrades.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnWordGrades.Text = "⊡ Word";
            this.btnWordGrades.UseVisualStyleBackColor = false;
            //
            // FormStudentCard
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.ClientSize = new System.Drawing.Size(820, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(820, 660);
            this.Name = "FormStudentCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка студента";
            // Events
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            this.dataGridViewGrades.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrades_CellEndEdit);
            this.dataGridViewGrades.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewGrades_RowPrePaint);
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label lblAvgGrade;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPersonal;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.Panel panelPersonalForm;
        private System.Windows.Forms.Label lblPersonalHeader;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.MaskedTextBox txtBirthDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblStatusField;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panelPersonalButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExcelPersonal;
        private System.Windows.Forms.Button btnPdfPersonal;
        private System.Windows.Forms.Button btnWordPersonal;
        private System.Windows.Forms.Panel panelGradesHeader;
        private System.Windows.Forms.Label lblGradesTitle;
        private System.Windows.Forms.Label lblGradesAvg;
        private System.Windows.Forms.DataGridView dataGridViewGrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFinal;
        private System.Windows.Forms.Panel panelGradesButtons;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnExcelGrades;
        private System.Windows.Forms.Button btnPdfGrades;
        private System.Windows.Forms.Button btnWordGrades;
    }
}
