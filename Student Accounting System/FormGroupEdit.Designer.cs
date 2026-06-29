namespace Student_Accounting_System
{
    partial class FormGroupEdit
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
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSubGroup = new System.Windows.Forms.Label();
            this.txtSubGroup = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(420, 48);
            //
            // lblHeaderTitle
            //
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(16, 13);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(65, 20);
            this.lblHeaderTitle.Text = "Группа";
            //
            // lblName
            //
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblName.Location = new System.Drawing.Point(16, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 15);
            this.lblName.Text = "Название группы (напр. ИС-21):";
            //
            // txtName
            //
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtName.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtName.Location = new System.Drawing.Point(16, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(388, 28);
            //
            // lblSubGroup
            //
            this.lblSubGroup.AutoSize = true;
            this.lblSubGroup.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubGroup.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.lblSubGroup.Location = new System.Drawing.Point(16, 122);
            this.lblSubGroup.Name = "lblSubGroup";
            this.lblSubGroup.Size = new System.Drawing.Size(130, 15);
            this.lblSubGroup.Text = "Подгруппа (напр. А):";
            //
            // txtSubGroup
            //
            this.txtSubGroup.BackColor = System.Drawing.Color.FromArgb(32, 34, 54);
            this.txtSubGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubGroup.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.txtSubGroup.Location = new System.Drawing.Point(16, 140);
            this.txtSubGroup.Name = "txtSubGroup";
            this.txtSubGroup.Size = new System.Drawing.Size(388, 28);
            //
            // panelButtons
            //
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(18, 20, 36);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 186);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.panelButtons.Size = new System.Drawing.Size(420, 52);
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnSave.FlatAppearance.BorderSize = 1;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnSave.Location = new System.Drawing.Point(16, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 32);
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            //
            // btnCancel
            //
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(42, 46, 72);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 64, 96);
            this.btnCancel.FlatAppearance.BorderSize = 1;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(180, 180, 210);
            this.btnCancel.Location = new System.Drawing.Point(156, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 32);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            //
            // FormGroupEdit
            //
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(22, 24, 40);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(420, 238);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSubGroup);
            this.Controls.Add(this.txtSubGroup);
            this.Controls.Add(this.panelButtons);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGroupEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Группа";
            // Events
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSubGroup;
        private System.Windows.Forms.TextBox txtSubGroup;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
