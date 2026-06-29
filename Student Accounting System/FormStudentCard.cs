using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormStudentCard : Form
    {
        private readonly Student _student;
        private readonly Group _group;

        public FormStudentCard(Student student, Group group)
        {
            InitializeComponent();
            txtBirthDate.Culture = CultureInfo.InvariantCulture;
            _student = student;
            _group = group;
            
            // Populate subgroup dropdown
            if (group != null && group.SubGroups.Count > 0)
            {
                foreach (var sg in group.SubGroups)
                    cmbSubGroup.Items.Add(sg);
            }
            
            LoadStudentData();
            LoadGrades();
        }

        private void LoadStudentData()
        {
            lblStudentName.Text = _student.FullName;
            lblGroupName.Text = $"Группа {_group.FullName}";
            double avg = _student.AverageGrade;
            lblAvgGrade.Text = $"Средний балл {(avg > 0 ? avg.ToString("F2") : "—")}";

            txtLastName.Text = _student.LastName;
            txtFirstName.Text = _student.FirstName;
            txtMiddleName.Text = _student.MiddleName;
            txtBirthDate.Text = _student.BirthDate == DateTime.MinValue
                ? ""
                : _student.BirthDate.ToString("dd.MM.yyyy");
            txtPhone.Text = _student.Phone;
            txtEmail.Text = _student.Email;
            txtAddress.Text = _student.Address;
            cmbStatus.SelectedIndex = (int)_student.Status;
            
            // Set subgroup if exists
            if (!string.IsNullOrEmpty(_student.SubGroup) && cmbSubGroup.Items.Contains(_student.SubGroup))
                cmbSubGroup.SelectedItem = _student.SubGroup;
            else if (cmbSubGroup.Items.Count > 0)
                cmbSubGroup.SelectedIndex = 0;
        }

        private void LoadGrades()
        {
            dataGridViewGrades.Rows.Clear();
            foreach (var sub in _student.Subjects)
            {
                dataGridViewGrades.Rows.Add(
                    sub.Name,
                    sub.Semester1Grade,
                    sub.Semester2Grade,
                    sub.FinalGrade > 0 ? $"● {sub.FinalGrade}" : "—");
            }
            UpdateGradesAvg();
        }

        private void UpdateGradesAvg()
        {
            double avg = _student.AverageGrade;
            lblGradesAvg.Text = $"Средний балл: {(avg > 0 ? avg.ToString("F2") : "—")}";
            lblAvgGrade.Text = $"Средний балл {(avg > 0 ? avg.ToString("F2") : "—")}";
        }

        private void dataGridViewGrades_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _student.Subjects.Count) return;
            var sub = _student.Subjects[e.RowIndex];
            var finalCell = dataGridViewGrades.Rows[e.RowIndex].Cells["colFinal"];
            if (sub.FinalGrade >= 5)
                finalCell.Style.ForeColor = Color.FromArgb(76, 175, 80);
            else if (sub.FinalGrade >= 4)
                finalCell.Style.ForeColor = Color.FromArgb(255, 193, 7);
            else if (sub.FinalGrade >= 3)
                finalCell.Style.ForeColor = Color.FromArgb(255, 152, 0);
            else if (sub.FinalGrade > 0)
                finalCell.Style.ForeColor = Color.FromArgb(244, 67, 54);
        }

        private void dataGridViewGrades_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _student.Subjects.Count) return;
            var sub = _student.Subjects[e.RowIndex];
            var row = dataGridViewGrades.Rows[e.RowIndex];

            bool sem1Changed = false, sem2Changed = false;
            if (TryParseGradeCell(row.Cells["colSem1"], out int s1))
            {
                sub.Semester1Grade = s1;
                sem1Changed = true;
            }
            if (TryParseGradeCell(row.Cells["colSem2"], out int s2))
            {
                sub.Semester2Grade = s2;
                sem2Changed = true;
            }
            
            // Автоматически рассчитываем итоговую оценку, если изменились семестровые
            if ((sem1Changed || sem2Changed) && e.ColumnIndex != dataGridViewGrades.Columns["colFinal"].Index)
            {
                if (sub.Semester1Grade > 0 && sub.Semester2Grade > 0)
                {
                    // Округляем среднее арифметическое до ближайшего целого
                    sub.FinalGrade = (int)Math.Round((sub.Semester1Grade + sub.Semester2Grade) / 2.0);
                    row.Cells["colFinal"].Value = $"● {sub.FinalGrade}";
                }
            }
            else if (TryParseGradeCell(row.Cells["colFinal"], out int fin))
            {
                // Если пользователь вручную изменил итоговую оценку, используем её
                sub.FinalGrade = fin;
            }

            DatabaseService.UpdateSubject(sub);
            UpdateGradesAvg();
            dataGridViewGrades.InvalidateRow(e.RowIndex);
        }

        private bool TryParseGradeCell(DataGridViewCell cell, out int value)
        {
            value = 0;
            string text = (cell.Value?.ToString() ?? "").Replace("●", "").Trim();
            return int.TryParse(text, out value) && value >= 0 && value <= 5;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _student.LastName = txtLastName.Text.Trim();
            _student.FirstName = txtFirstName.Text.Trim();
            _student.MiddleName = txtMiddleName.Text.Trim();

            if (DateTime.TryParseExact(txtBirthDate.Text, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime bd))
                _student.BirthDate = bd;

            _student.Phone = txtPhone.Text.Trim();
            _student.Email = txtEmail.Text.Trim();
            _student.Address = txtAddress.Text.Trim();
            _student.Status = (StudentStatus)cmbStatus.SelectedIndex;
            _student.SubGroup = cmbSubGroup.SelectedItem?.ToString() ?? "";

            lblStudentName.Text = _student.FullName;

            DatabaseService.UpdateStudent(_student);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            string name = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите название предмета:", "Добавить предмет", "");
            if (string.IsNullOrWhiteSpace(name)) return;

            var newSubject = new Subject
            {
                Id = DataStore.NextSubjectId(),
                Name = name.Trim(),
                Semester1Grade = 0,
                Semester2Grade = 0,
                FinalGrade = 0
            };
            _student.Subjects.Add(newSubject);
            DatabaseService.SaveSubject(newSubject, _student.Id);
            LoadGrades();
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dataGridViewGrades.SelectedRows.Count == 0) return;
            int idx = dataGridViewGrades.SelectedRows[0].Index;
            if (idx < 0 || idx >= _student.Subjects.Count) return;

            var sub = _student.Subjects[idx];
            if (MessageBox.Show($"Удалить предмет «{sub.Name}»?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DatabaseService.DeleteSubject(sub.Id);
                _student.Subjects.RemoveAt(idx);
                LoadGrades();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tab = (TabControl)sender;
            var page = tab.TabPages[e.Index];
            var rect = tab.GetTabRect(e.Index);
            bool selected = (tab.SelectedIndex == e.Index);

            Color backColor = selected ? Color.FromArgb(26, 28, 46) : Color.FromArgb(18, 20, 36);
            Color foreColor = selected ? Color.White : Color.FromArgb(140, 140, 170);

            using (var brush = new SolidBrush(backColor))
                e.Graphics.FillRectangle(brush, rect);

            if (selected)
            {
                using (var pen = new Pen(Color.FromArgb(80, 120, 200), 2))
                    e.Graphics.DrawLine(pen, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
            }

            var sf = new System.Drawing.StringFormat
            {
                Alignment = System.Drawing.StringAlignment.Center,
                LineAlignment = System.Drawing.StringAlignment.Center
            };
            using (var brush = new SolidBrush(foreColor))
                e.Graphics.DrawString(page.Text,
                    new Font("Segoe UI", 9F, selected ? FontStyle.Bold : FontStyle.Regular),
                    brush, rect, sf);
        }
    }
}
