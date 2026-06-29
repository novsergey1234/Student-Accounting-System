using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormGradeSheet : Form
    {
        private readonly Group _group;

        public FormGradeSheet(Group group)
        {
            InitializeComponent();
            _group = group;
            lblGroupTitle.Text = $"Группа {group.FullName} — Ведомость оценок";
            LoadSubjectsCombo();
        }

        private void LoadSubjectsCombo()
        {
            cmbSubject.Items.Clear();
            foreach (var gs in _group.GroupSubjects)
                cmbSubject.Items.Add(gs);

            if (cmbSubject.Items.Count > 0)
                cmbSubject.SelectedIndex = 0;
        }

        private GroupSubject _currentSubject;

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedItem is GroupSubject gs)
            {
                _currentSubject = gs;
                LoadGrades();
            }
        }

        private void LoadGrades()
        {
            if (_currentSubject == null) return;

            dataGridViewGrades.Rows.Clear();
            int index = 0;
            foreach (var student in _group.Students)
            {
                var subject = student.Subjects.FirstOrDefault(s => s.GroupSubjectId == _currentSubject.Id);
                if (subject != null)
                {
                    dataGridViewGrades.Rows.Add(
                        student.FullName,
                        subject.Semester1Grade > 0 ? subject.Semester1Grade.ToString() : "",
                        subject.Semester2Grade > 0 ? subject.Semester2Grade.ToString() : "",
                        subject.FinalGrade > 0 ? subject.FinalGrade.ToString() : "");

                    dataGridViewGrades.Rows[index].Tag = subject;
                }
                else
                {
                    dataGridViewGrades.Rows.Add(student.FullName, "", "", "");
                    dataGridViewGrades.Rows[index].Tag = null;
                }
                index++;
            }
            UpdateAvgGrade();
        }

        private void UpdateAvgGrade()
        {
            var grades = _group.Students
                .SelectMany(s => s.Subjects)
                .Where(s => s.GroupSubjectId == (_currentSubject?.Id ?? -1) && s.FinalGrade > 0)
                .Select(s => (double)s.FinalGrade)
                .ToList();

            double avg = grades.Any() ? grades.Average() : 0;
            lblAvgGrade.Text = avg > 0 ? $"Средний балл: {avg:F2}" : "Средний балл: —";
        }

        private void dataGridViewGrades_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewGrades.Rows.Count) return;

            var row = dataGridViewGrades.Rows[e.RowIndex];
            var subject = row.Tag as Subject;
            if (subject == null) return;

            bool changed = false;

            if (TryParseGradeCell(row.Cells["colSem1"], out int s1))
            {
                subject.Semester1Grade = s1;
                changed = true;
            }
            if (TryParseGradeCell(row.Cells["colSem2"], out int s2))
            {
                subject.Semester2Grade = s2;
                changed = true;
            }

            if (e.ColumnIndex != dataGridViewGrades.Columns["colFinal"].Index)
            {
                if (subject.Semester1Grade > 0 && subject.Semester2Grade > 0)
                {
                    subject.FinalGrade = (int)Math.Round((subject.Semester1Grade + subject.Semester2Grade) / 2.0);
                    row.Cells["colFinal"].Value = subject.FinalGrade > 0 ? subject.FinalGrade.ToString() : "";
                    changed = true;
                }
            }
            else if (TryParseGradeCell(row.Cells["colFinal"], out int fin))
            {
                subject.FinalGrade = fin;
                changed = true;
            }

            if (changed)
            {
                DatabaseService.UpdateSubject(subject);
                UpdateAvgGrade();
                ColorGradeCell(row.Cells["colFinal"], subject.FinalGrade);
            }
        }

        private void ColorGradeCell(DataGridViewCell cell, int grade)
        {
            if (grade >= 5)
                cell.Style.ForeColor = Color.FromArgb(76, 175, 80);
            else if (grade >= 4)
                cell.Style.ForeColor = Color.FromArgb(255, 193, 7);
            else if (grade >= 3)
                cell.Style.ForeColor = Color.FromArgb(255, 152, 0);
            else if (grade > 0)
                cell.Style.ForeColor = Color.FromArgb(244, 67, 54);
            else
                cell.Style.ForeColor = Color.White;
        }

        private bool TryParseGradeCell(DataGridViewCell cell, out int value)
        {
            value = 0;
            string text = (cell.Value?.ToString() ?? "").Trim();
            return int.TryParse(text, out value) && value >= 0 && value <= 5;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
