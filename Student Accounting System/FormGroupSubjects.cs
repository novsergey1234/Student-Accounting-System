using System;
using System.Linq;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormGroupSubjects : Form
    {
        private readonly Group _group;

        public FormGroupSubjects(Group group)
        {
            InitializeComponent();
            _group = group;
            lblHeaderTitle.Text = $"Предметы группы {group.FullName}";
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            dataGridViewSubjects.Rows.Clear();
            foreach (var gs in _group.GroupSubjects)
            {
                dataGridViewSubjects.Rows.Add(gs.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название предмета:", "Добавить предмет", "");
            if (string.IsNullOrWhiteSpace(name)) return;

            var gs = new GroupSubject
            {
                Id = DataStore.NextGroupSubjectId(),
                GroupId = _group.Id,
                Name = name.Trim()
            };

            DatabaseService.SaveGroupSubject(gs, _group.Id);
            _group.GroupSubjects.Add(gs);
            LoadSubjects();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count == 0) return;
            int idx = dataGridViewSubjects.SelectedRows[0].Index;
            if (idx < 0 || idx >= _group.GroupSubjects.Count) return;

            var gs = _group.GroupSubjects[idx];
            if (MessageBox.Show($"Удалить предмет «{gs.Name}»?\nЭто удалит оценки по этому предмету у всех студентов группы.",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DatabaseService.DeleteGroupSubject(gs.Id);
                LoadSubjects();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
