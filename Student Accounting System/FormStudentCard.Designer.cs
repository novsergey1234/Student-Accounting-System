using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.lblAvgGrade = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPersonal = new System.Windows.Forms.TabPage();
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
            this.lblSubGroupField = new System.Windows.Forms.Label();
            this.cmbSubGroup = new System.Windows.Forms.ComboBox();
            this.panelPersonalButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcelPersonal = new System.Windows.Forms.Button();
            this.btnPdfPersonal = new System.Windows.Forms.Button();
            this.btnWordPersonal = new System.Windows.Forms.Button();
            this.tabGrades = new System.Windows.Forms.TabPage();
            this.dataGridViewGrades = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGradesHeader = new System.Windows.Forms.Panel();
            this.lblGradesTitle = new System.Windows.Forms.Label();
            this.lblGradesAvg = new System.Windows.Forms.Label();
            this.panelGradesButtons = new System.Windows.Forms.Panel();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnExcelGrades = new System.Windows.Forms.Button();
            this.btnPdfGrades = new System.Windows.Forms.Button();
            this.btnWordGrades = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPersonal.SuspendLayout();
            this.panelPersonalForm.SuspendLayout();
            this.panelPersonalButtons.SuspendLayout();
            this.tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).BeginInit();
            this.panelGradesHeader.SuspendLayout();
            this.panelGradesButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.lblStudentName);
            this.panelHeader.Controls.Add(this.lblGroupName);
            this.panelHeader.Controls.Add(this.lblAvgGrade);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(820, 72);
            this.panelHeader.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnBack.Location = new System.Drawing.Point(12, 22);
            this.btnBack.MinimumSize = new System.Drawing.Size(90, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnBack.Size = new System.Drawing.Size(90, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(110, 12);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(80, 25);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Студент";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGroupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblGroupName.Location = new System.Drawing.Point(112, 42);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(46, 15);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "Группа";
            // 
            // lblAvgGrade
            // 
            this.lblAvgGrade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvgGrade.AutoSize = true;
            this.lblAvgGrade.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAvgGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblAvgGrade.Location = new System.Drawing.Point(1240, 26);
            this.lblAvgGrade.Name = "lblAvgGrade";
            this.lblAvgGrade.Size = new System.Drawing.Size(106, 15);
            this.lblAvgGrade.TabIndex = 3;
            this.lblAvgGrade.Text = "Средний балл: —";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPersonal);
            this.tabControl.Controls.Add(this.tabGrades);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl.ItemSize = new System.Drawing.Size(160, 36);
            this.tabControl.Location = new System.Drawing.Point(0, 72);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(820, 628);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabPersonal
            // 
            this.tabPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.tabPersonal.Controls.Add(this.panelPersonalForm);
            this.tabPersonal.ForeColor = System.Drawing.Color.White;
            this.tabPersonal.Location = new System.Drawing.Point(4, 40);
            this.tabPersonal.Name = "tabPersonal";
            this.tabPersonal.Size = new System.Drawing.Size(812, 584);
            this.tabPersonal.TabIndex = 0;
            this.tabPersonal.Text = "   Личные данные  ";
            // 
            // panelPersonalForm
            // 
            this.panelPersonalForm.AutoScroll = true;
            this.panelPersonalForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
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
            this.panelPersonalForm.Controls.Add(this.lblSubGroupField);
            this.panelPersonalForm.Controls.Add(this.cmbSubGroup);
            this.panelPersonalForm.Controls.Add(this.panelPersonalButtons);
            this.panelPersonalForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPersonalForm.Location = new System.Drawing.Point(0, 0);
            this.panelPersonalForm.Name = "panelPersonalForm";
            this.panelPersonalForm.Padding = new System.Windows.Forms.Padding(16);
            this.panelPersonalForm.Size = new System.Drawing.Size(812, 584);
            this.panelPersonalForm.TabIndex = 0;
            // 
            // lblPersonalHeader
            // 
            this.lblPersonalHeader.AutoSize = true;
            this.lblPersonalHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonalHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblPersonalHeader.Location = new System.Drawing.Point(19, 16);
            this.lblPersonalHeader.Name = "lblPersonalHeader";
            this.lblPersonalHeader.Size = new System.Drawing.Size(150, 19);
            this.lblPersonalHeader.TabIndex = 0;
            this.lblPersonalHeader.Text = "👤  Личные данные";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblLastName.Location = new System.Drawing.Point(20, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 15);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Фамилия";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtLastName.Location = new System.Drawing.Point(16, 64);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(360, 25);
            this.txtLastName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblFirstName.Location = new System.Drawing.Point(397, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(31, 15);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Имя";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtFirstName.Location = new System.Drawing.Point(396, 64);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(360, 25);
            this.txtFirstName.TabIndex = 4;
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblMiddleName.Location = new System.Drawing.Point(19, 110);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(58, 15);
            this.lblMiddleName.TabIndex = 5;
            this.lblMiddleName.Text = "Отчество";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMiddleName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtMiddleName.Location = new System.Drawing.Point(16, 128);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(360, 25);
            this.txtMiddleName.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblBirthDate.Location = new System.Drawing.Point(397, 110);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(157, 15);
            this.lblBirthDate.TabIndex = 7;
            this.lblBirthDate.Text = "Дата рождения (дд.мм.гггг)";
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBirthDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtBirthDate.Location = new System.Drawing.Point(396, 128);
            this.txtBirthDate.Mask = "00.00.0000";
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(360, 25);
            this.txtBirthDate.TabIndex = 8;
            this.txtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblPhone.Location = new System.Drawing.Point(19, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 15);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtPhone.Location = new System.Drawing.Point(16, 192);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(360, 25);
            this.txtPhone.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblEmail.Location = new System.Drawing.Point(397, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtEmail.Location = new System.Drawing.Point(396, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 25);
            this.txtEmail.TabIndex = 12;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblAddress.Location = new System.Drawing.Point(19, 241);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(40, 15);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Адрес";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.txtAddress.Location = new System.Drawing.Point(16, 259);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(764, 25);
            this.txtAddress.TabIndex = 14;
            // 
            // lblStatusField
            // 
            this.lblStatusField.AutoSize = true;
            this.lblStatusField.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatusField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblStatusField.Location = new System.Drawing.Point(19, 302);
            this.lblStatusField.Name = "lblStatusField";
            this.lblStatusField.Size = new System.Drawing.Size(43, 15);
            this.lblStatusField.TabIndex = 15;
            this.lblStatusField.Text = "Статус";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.cmbStatus.Items.AddRange(new object[] {
            "Учится",
            "Академотпуск",
            "Должник"});
            this.cmbStatus.Location = new System.Drawing.Point(16, 320);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(360, 25);
            this.cmbStatus.TabIndex = 16;
            // 
            // lblSubGroupField
            // 
            this.lblSubGroupField.AutoSize = true;
            this.lblSubGroupField.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubGroupField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.lblSubGroupField.Location = new System.Drawing.Point(397, 302);
            this.lblSubGroupField.Name = "lblSubGroupField";
            this.lblSubGroupField.Size = new System.Drawing.Size(70, 15);
            this.lblSubGroupField.TabIndex = 17;
            this.lblSubGroupField.Text = "Подгруппа:";
            // 
            // cmbSubGroup
            // 
            this.cmbSubGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.cmbSubGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSubGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.cmbSubGroup.Location = new System.Drawing.Point(400, 320);
            this.cmbSubGroup.Name = "cmbSubGroup";
            this.cmbSubGroup.Size = new System.Drawing.Size(200, 25);
            this.cmbSubGroup.TabIndex = 18;
            // 
            // panelPersonalButtons
            // 
            this.panelPersonalButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.panelPersonalButtons.Controls.Add(this.btnSave);
            this.panelPersonalButtons.Controls.Add(this.btnCancel);
            this.panelPersonalButtons.Controls.Add(this.btnExcelPersonal);
            this.panelPersonalButtons.Controls.Add(this.btnPdfPersonal);
            this.panelPersonalButtons.Controls.Add(this.btnWordPersonal);
            this.panelPersonalButtons.Location = new System.Drawing.Point(16, 368);
            this.panelPersonalButtons.Name = "panelPersonalButtons";
            this.panelPersonalButtons.Size = new System.Drawing.Size(760, 40);
            this.panelPersonalButtons.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnSave.Location = new System.Drawing.Point(0, 4);
            this.btnSave.MinimumSize = new System.Drawing.Size(110, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "💾 Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnCancel.Location = new System.Drawing.Point(120, 4);
            this.btnCancel.MinimumSize = new System.Drawing.Size(90, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "✕ Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExcelPersonal
            // 
            this.btnExcelPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelPersonal.AutoSize = true;
            this.btnExcelPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnExcelPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnExcelPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcelPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnExcelPersonal.Location = new System.Drawing.Point(950, 4);
            this.btnExcelPersonal.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnExcelPersonal.Name = "btnExcelPersonal";
            this.btnExcelPersonal.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnExcelPersonal.Size = new System.Drawing.Size(80, 30);
            this.btnExcelPersonal.TabIndex = 2;
            this.btnExcelPersonal.Text = "⊞ Excel";
            this.btnExcelPersonal.UseVisualStyleBackColor = false;
            // 
            // btnPdfPersonal
            // 
            this.btnPdfPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdfPersonal.AutoSize = true;
            this.btnPdfPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnPdfPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnPdfPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdfPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnPdfPersonal.Location = new System.Drawing.Point(1040, 4);
            this.btnPdfPersonal.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnPdfPersonal.Name = "btnPdfPersonal";
            this.btnPdfPersonal.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnPdfPersonal.Size = new System.Drawing.Size(80, 30);
            this.btnPdfPersonal.TabIndex = 3;
            this.btnPdfPersonal.Text = "⊟ PDF";
            this.btnPdfPersonal.UseVisualStyleBackColor = false;
            // 
            // btnWordPersonal
            // 
            this.btnWordPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWordPersonal.AutoSize = true;
            this.btnWordPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnWordPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnWordPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordPersonal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWordPersonal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnWordPersonal.Location = new System.Drawing.Point(1130, 4);
            this.btnWordPersonal.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnWordPersonal.Name = "btnWordPersonal";
            this.btnWordPersonal.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnWordPersonal.Size = new System.Drawing.Size(80, 30);
            this.btnWordPersonal.TabIndex = 4;
            this.btnWordPersonal.Text = "⊡ Word";
            this.btnWordPersonal.UseVisualStyleBackColor = false;
            // 
            // tabGrades
            // 
            this.tabGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.tabGrades.Controls.Add(this.dataGridViewGrades);
            this.tabGrades.Controls.Add(this.panelGradesHeader);
            this.tabGrades.Controls.Add(this.panelGradesButtons);
            this.tabGrades.ForeColor = System.Drawing.Color.White;
            this.tabGrades.Location = new System.Drawing.Point(4, 40);
            this.tabGrades.Name = "tabGrades";
            this.tabGrades.Size = new System.Drawing.Size(812, 584);
            this.tabGrades.TabIndex = 1;
            this.tabGrades.Text = "  Оценки  ";
            // 
            // dataGridViewGrades
            // 
            this.dataGridViewGrades.AllowUserToAddRows = false;
            this.dataGridViewGrades.AllowUserToDeleteRows = false;
            this.dataGridViewGrades.AllowUserToResizeColumns = false;
            this.dataGridViewGrades.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.dataGridViewGrades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.dataGridViewGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGrades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGrades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGrades.ColumnHeadersHeight = 36;
            this.dataGridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colSem1,
            this.colSem2,
            this.colFinal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGrades.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGrades.EnableHeadersVisualStyles = false;
            this.dataGridViewGrades.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridViewGrades.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.dataGridViewGrades.Location = new System.Drawing.Point(0, 36);
            this.dataGridViewGrades.MultiSelect = false;
            this.dataGridViewGrades.Name = "dataGridViewGrades";
            this.dataGridViewGrades.RowHeadersVisible = false;
            this.dataGridViewGrades.RowTemplate.Height = 36;
            this.dataGridViewGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrades.Size = new System.Drawing.Size(812, 498);
            this.dataGridViewGrades.TabIndex = 0;
            this.dataGridViewGrades.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrades_CellEndEdit);
            this.dataGridViewGrades.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewGrades_RowPrePaint);
            // 
            // colSubject
            // 
            this.colSubject.FillWeight = 40F;
            this.colSubject.HeaderText = "Предмет";
            this.colSubject.Name = "colSubject";
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
            // panelGradesHeader
            // 
            this.panelGradesHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.panelGradesHeader.Controls.Add(this.lblGradesTitle);
            this.panelGradesHeader.Controls.Add(this.lblGradesAvg);
            this.panelGradesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGradesHeader.Location = new System.Drawing.Point(0, 0);
            this.panelGradesHeader.Name = "panelGradesHeader";
            this.panelGradesHeader.Size = new System.Drawing.Size(812, 36);
            this.panelGradesHeader.TabIndex = 1;
            // 
            // lblGradesTitle
            // 
            this.lblGradesTitle.AutoSize = true;
            this.lblGradesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGradesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblGradesTitle.Location = new System.Drawing.Point(12, 8);
            this.lblGradesTitle.Name = "lblGradesTitle";
            this.lblGradesTitle.Size = new System.Drawing.Size(134, 19);
            this.lblGradesTitle.TabIndex = 0;
            this.lblGradesTitle.Text = "📊  Успеваемость";
            // 
            // lblGradesAvg
            // 
            this.lblGradesAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGradesAvg.AutoSize = true;
            this.lblGradesAvg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGradesAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblGradesAvg.Location = new System.Drawing.Point(1232, 10);
            this.lblGradesAvg.Name = "lblGradesAvg";
            this.lblGradesAvg.Size = new System.Drawing.Size(106, 15);
            this.lblGradesAvg.TabIndex = 1;
            this.lblGradesAvg.Text = "Средний балл: —";
            // 
            // panelGradesButtons
            // 
            this.panelGradesButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.panelGradesButtons.Controls.Add(this.btnAddSubject);
            this.panelGradesButtons.Controls.Add(this.btnDeleteSubject);
            this.panelGradesButtons.Controls.Add(this.btnExcelGrades);
            this.panelGradesButtons.Controls.Add(this.btnPdfGrades);
            this.panelGradesButtons.Controls.Add(this.btnWordGrades);
            this.panelGradesButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGradesButtons.Location = new System.Drawing.Point(0, 534);
            this.panelGradesButtons.Name = "panelGradesButtons";
            this.panelGradesButtons.Padding = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.panelGradesButtons.Size = new System.Drawing.Size(812, 50);
            this.panelGradesButtons.TabIndex = 2;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.AutoSize = true;
            this.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnAddSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnAddSubject.Location = new System.Drawing.Point(16, 20);
            this.btnAddSubject.MinimumSize = new System.Drawing.Size(130, 30);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnAddSubject.Size = new System.Drawing.Size(143, 30);
            this.btnAddSubject.TabIndex = 0;
            this.btnAddSubject.Text = "+ Добавить предмет";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.AutoSize = true;
            this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSubject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnDeleteSubject.Location = new System.Drawing.Point(156, 20);
            this.btnDeleteSubject.MinimumSize = new System.Drawing.Size(130, 30);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnDeleteSubject.Size = new System.Drawing.Size(139, 30);
            this.btnDeleteSubject.TabIndex = 1;
            this.btnDeleteSubject.Text = "🗑 Удалить предмет";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnExcelGrades
            // 
            this.btnExcelGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcelGrades.AutoSize = true;
            this.btnExcelGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnExcelGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcelGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnExcelGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExcelGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnExcelGrades.Location = new System.Drawing.Point(994, 20);
            this.btnExcelGrades.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnExcelGrades.Name = "btnExcelGrades";
            this.btnExcelGrades.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnExcelGrades.Size = new System.Drawing.Size(80, 30);
            this.btnExcelGrades.TabIndex = 2;
            this.btnExcelGrades.Text = "⊞ Excel";
            this.btnExcelGrades.UseVisualStyleBackColor = false;
            // 
            // btnPdfGrades
            // 
            this.btnPdfGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdfGrades.AutoSize = true;
            this.btnPdfGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnPdfGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdfGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnPdfGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPdfGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnPdfGrades.Location = new System.Drawing.Point(1084, 20);
            this.btnPdfGrades.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnPdfGrades.Name = "btnPdfGrades";
            this.btnPdfGrades.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnPdfGrades.Size = new System.Drawing.Size(80, 30);
            this.btnPdfGrades.TabIndex = 3;
            this.btnPdfGrades.Text = "⊟ PDF";
            this.btnPdfGrades.UseVisualStyleBackColor = false;
            // 
            // btnWordGrades
            // 
            this.btnWordGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWordGrades.AutoSize = true;
            this.btnWordGrades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(72)))));
            this.btnWordGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWordGrades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.btnWordGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordGrades.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWordGrades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btnWordGrades.Location = new System.Drawing.Point(1174, 20);
            this.btnWordGrades.MinimumSize = new System.Drawing.Size(80, 30);
            this.btnWordGrades.Name = "btnWordGrades";
            this.btnWordGrades.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.btnWordGrades.Size = new System.Drawing.Size(80, 30);
            this.btnWordGrades.TabIndex = 4;
            this.btnWordGrades.Text = "⊡ Word";
            this.btnWordGrades.UseVisualStyleBackColor = false;
            // 
            // FormStudentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(820, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MinimumSize = new System.Drawing.Size(820, 660);
            this.Name = "FormStudentCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточка студента";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPersonal.ResumeLayout(false);
            this.panelPersonalForm.ResumeLayout(false);
            this.panelPersonalForm.PerformLayout();
            this.panelPersonalButtons.ResumeLayout(false);
            this.panelPersonalButtons.PerformLayout();
            this.tabGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrades)).EndInit();
            this.panelGradesHeader.ResumeLayout(false);
            this.panelGradesHeader.PerformLayout();
            this.panelGradesButtons.ResumeLayout(false);
            this.panelGradesButtons.PerformLayout();
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
        private System.Windows.Forms.Label lblSubGroupField;
        private System.Windows.Forms.ComboBox cmbSubGroup;
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
