using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormStudents : Form
    {
        private readonly Group _group;
        private List<Student> _filtered;

        public FormStudents(Group group)
        {
            InitializeComponent();
            _group = group;
            lblGroupTitle.Text = $"Группа {group.FullName}";
            LoadStudents(group.Students);
        }

        private void LoadStudents(List<Student> students)
        {
            _filtered = students;
            dataGridViewStudents.Rows.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                var s = students[i];
                double avg = s.AverageGrade;
                dataGridViewStudents.Rows.Add(
                    i + 1,
                    s.LastName,
                    s.FirstName,
                    s.MiddleName,
                    s.SubGroup ?? "",
                    avg > 0 ? avg.ToString("F2") : "—",
                    s.StatusLabel);
            }
            UpdateFooter(students);
            UpdateAvgLabel(students);
            lblStudentCount.Text = $"{_group.Students.Count} студентов";
        }

        private void UpdateAvgLabel(List<Student> students)
        {
            double avg = students.Any() ? students.Average(s => s.AverageGrade) : 0;
            lblAvgGrade.Text = avg > 0 ? avg.ToString("F2") : "—";
        }

        private void UpdateFooter(List<Student> students)
        {
            lblTotal.Text = students.Count.ToString();
            lblExcellent.Text = students.Count(s => s.AverageGrade >= 4.5).ToString();
            lblDebtors.Text = students.Count(s => s.Status == StudentStatus.Debtor).ToString();
        }

        private void dataGridViewStudents_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _filtered.Count) return;
            var student = _filtered[e.RowIndex];
            var row = dataGridViewStudents.Rows[e.RowIndex];

            // Color status cell
            var statusCell = row.Cells["colStatus"];
            switch (student.Status)
            {
                case StudentStatus.Active:
                    statusCell.Style.ForeColor = Color.FromArgb(76, 175, 80);
                    break;
                case StudentStatus.Academic:
                    statusCell.Style.ForeColor = Color.FromArgb(255, 152, 0);
                    break;
                case StudentStatus.Debtor:
                    statusCell.Style.ForeColor = Color.FromArgb(244, 67, 54);
                    break;
            }

            // Color avg grade
            var avgCell = row.Cells["colAvgGrade"];
            double avg = student.AverageGrade;
            if (avg >= 4.5) avgCell.Style.ForeColor = Color.FromArgb(76, 175, 80);
            else if (avg >= 3.5) avgCell.Style.ForeColor = Color.FromArgb(255, 193, 7);
            else avgCell.Style.ForeColor = Color.FromArgb(244, 67, 54);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            int field = cmbSearchField.SelectedIndex;

            if (string.IsNullOrEmpty(query))
            {
                LoadStudents(_group.Students);
                return;
            }

            var result = _group.Students.Where(s =>
            {
                switch (field)
                {
                    case 1: return s.LastName.ToLower().Contains(query);
                    case 2: return s.FirstName.ToLower().Contains(query);
                    case 3: return s.MiddleName.ToLower().Contains(query);
                    default:
                        return s.LastName.ToLower().Contains(query)
                            || s.FirstName.ToLower().Contains(query)
                            || s.MiddleName.ToLower().Contains(query);
                }
            }).ToList();

            LoadStudents(result);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) LoadStudents(_group.Students);
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        {
            bool has = dataGridViewStudents.SelectedRows.Count > 0;
            btnEditStudent.Enabled = has;
            btnDeleteStudent.Enabled = has;
        }

        private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) OpenStudentCard(e.RowIndex);
        }

        private void OpenStudentCard(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex >= _filtered.Count) return;
            var student = _filtered[rowIndex];
            var form = new FormStudentCard(student, _group);
            form.FormClosed += (s, e) => LoadStudents(_group.Students);
            form.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var dlg = new FormStudentEdit(null, _group);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _group.Students.Add(dlg.ResultStudent);
                DatabaseService.SaveStudent(dlg.ResultStudent, _group.Id);
                LoadStudents(_group.Students);
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0) return;
            int idx = dataGridViewStudents.SelectedRows[0].Index;
            if (idx < 0 || idx >= _filtered.Count) return;
            var student = _filtered[idx];
            var dlg = new FormStudentEdit(student, _group);
            if (dlg.ShowDialog() == DialogResult.OK)
                LoadStudents(_group.Students);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count == 0) return;
            int idx = dataGridViewStudents.SelectedRows[0].Index;
            if (idx < 0 || idx >= _filtered.Count) return;
            var student = _filtered[idx];
            var result = MessageBox.Show(
                $"Удалить студента {student.FullName}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DatabaseService.DeleteStudent(student.Id);
                _group.Students.Remove(student);
                LoadStudents(_group.Students);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
