using System;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormGroupEdit : Form
    {
        public Group ResultGroup { get; private set; }
        private readonly Group _existing;

        public FormGroupEdit(Group existing)
        {
            InitializeComponent();
            _existing = existing;

            if (existing != null)
            {
                this.Text = "Редактировать группу";
                txtName.Text = existing.Name;
                txtSubGroup.Text = existing.SubGroup;
            }
            else
            {
                this.Text = "Добавить группу";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSubGroup.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_existing != null)
            {
                _existing.Name = txtName.Text.Trim();
                _existing.SubGroup = txtSubGroup.Text.Trim();
                ResultGroup = _existing;
            }
            else
            {
                ResultGroup = new Group
                {
                    Id = DataStore.NextGroupId(),
                    Name = txtName.Text.Trim(),
                    SubGroup = txtSubGroup.Text.Trim()
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
