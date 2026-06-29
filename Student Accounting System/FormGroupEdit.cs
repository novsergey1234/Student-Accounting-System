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
                txtSubGroup.Text = string.Join(", ", existing.SubGroups);
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

            // Parse subgroups from comma-separated string
            var subGroups = new System.Collections.Generic.List<string>();
            foreach (var sg in txtSubGroup.Text.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries))
            {
                var trimmed = sg.Trim();
                if (!string.IsNullOrEmpty(trimmed))
                    subGroups.Add(trimmed);
            }

            if (subGroups.Count == 0)
            {
                MessageBox.Show("Укажите хотя бы одну подгруппу (например: А, Б).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_existing != null)
            {
                _existing.Name = txtName.Text.Trim();
                _existing.SubGroups = subGroups;
                ResultGroup = _existing;
                DatabaseService.UpdateGroup(_existing);
            }
            else
            {
                ResultGroup = new Group
                {
                    Id = DataStore.NextGroupId(),
                    Name = txtName.Text.Trim(),
                    SubGroups = subGroups
                };
                // Note: SaveGroup will be called from FormGroups when added to list
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
