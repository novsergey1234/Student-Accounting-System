using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormAttendance : Form
    {
        private readonly Group _group;
        private bool _isSummaryMode;
        private DateTime _currentDate;
        private readonly Dictionary<int, AttendanceRecord> _recordsByStudent;

        public FormAttendance(Group group)
        {
            InitializeComponent();
            _group = group;
            _recordsByStudent = new Dictionary<int, AttendanceRecord>();
            lblGroupTitle.Text = $"Группа {group.FullName} — Посещаемость";
            _currentDate = DateTime.Today;
            dateTimePicker.Value = _currentDate;
            LoadAttendanceForDate(_currentDate);
        }

        private void LoadAttendanceForDate(DateTime date)
        {
            if (_isSummaryMode) return;

            _recordsByStudent.Clear();
            var records = DatabaseService.GetAttendanceForDate(_group.Id, date);
            foreach (var r in records)
                _recordsByStudent[r.StudentId] = r;

            dataGridViewAttendance.Rows.Clear();
            for (int i = 0; i < _group.Students.Count; i++)
            {
                var s = _group.Students[i];
                var rec = _recordsByStudent.ContainsKey(s.Id) ? _recordsByStudent[s.Id] : null;
                int rowIdx = dataGridViewAttendance.Rows.Add(
                    i + 1,
                    s.FullName,
                    rec?.IsAbsent1 ?? false,
                    rec?.IsAbsent2 ?? false,
                    rec?.IsAbsent3 ?? false,
                    rec?.IsAbsent4 ?? false,
                    rec?.IsAbsent5 ?? false);
                dataGridViewAttendance.Rows[rowIdx].Tag = s;
            }
        }

        private int GetPairIndexFromColumn(int columnIndex)
        {
            return columnIndex - 2;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _currentDate = dateTimePicker.Value.Date;
            if (!_isSummaryMode)
                LoadAttendanceForDate(_currentDate);
        }

        private void dataGridViewAttendance_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (_isSummaryMode) return;
            if (dataGridViewAttendance.CurrentCell == null) return;
            int col = dataGridViewAttendance.CurrentCell.ColumnIndex;
            if (col >= 2 && col <= 6 && dataGridViewAttendance.IsCurrentCellDirty)
                dataGridViewAttendance.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewAttendance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (_isSummaryMode) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 2 || e.ColumnIndex > 6) return;

            var row = dataGridViewAttendance.Rows[e.RowIndex];
            var student = row.Tag as Student;
            if (student == null) return;

            var cell = row.Cells[e.ColumnIndex];
            bool isChecked = cell.Value is bool b && b;

            if (!_recordsByStudent.ContainsKey(student.Id))
            {
                _recordsByStudent[student.Id] = new AttendanceRecord
                {
                    StudentId = student.Id,
                    Date = _currentDate
                };
            }

            var rec = _recordsByStudent[student.Id];
            int pairIdx = GetPairIndexFromColumn(e.ColumnIndex);
            switch (pairIdx)
            {
                case 0: rec.IsAbsent1 = isChecked; break;
                case 1: rec.IsAbsent2 = isChecked; break;
                case 2: rec.IsAbsent3 = isChecked; break;
                case 3: rec.IsAbsent4 = isChecked; break;
                case 4: rec.IsAbsent5 = isChecked; break;
            }

            DatabaseService.SaveAttendance(rec);
        }

        private void btnToggleMode_Click(object sender, EventArgs e)
        {
            _isSummaryMode = !_isSummaryMode;
            if (_isSummaryMode)
            {
                btnToggleMode.Text = "📋 Посещаемость";
                dateTimePicker.Visible = false;
                LoadSummary();
            }
            else
            {
                btnToggleMode.Text = "📊 Итоги";
                dateTimePicker.Visible = true;
                RestoreAttendanceColumns();
                LoadAttendanceForDate(_currentDate);
            }
        }

        private void RestoreAttendanceColumns()
        {
            dataGridViewAttendance.Columns.Clear();
            dataGridViewAttendance.Columns.Add(colNum);
            dataGridViewAttendance.Columns.Add(colStudent);
            dataGridViewAttendance.Columns.Add(colPair1);
            dataGridViewAttendance.Columns.Add(colPair2);
            dataGridViewAttendance.Columns.Add(colPair3);
            dataGridViewAttendance.Columns.Add(colPair4);
            dataGridViewAttendance.Columns.Add(colPair5);
        }

        private void LoadSummary()
        {
            dataGridViewAttendance.Columns.Clear();

            var allRecords = DatabaseService.GetAllAttendanceForGroup(_group.Id);

            DateTime semStart, semEnd;

            if (allRecords.Count == 0)
            {
                var now = DateTime.Today;
                int year = now.Month >= 9 ? now.Year : now.Year - 1;
                semStart = new DateTime(year, 9, 1);
                semEnd = new DateTime(year + 1, 8, 31);
            }
            else
            {
                var minDate = allRecords.Min(r => r.Date);
                var maxDate = allRecords.Max(r => r.Date);
                int startYear = minDate.Month >= 9 ? minDate.Year : minDate.Year - 1;
                int endYear = maxDate.Month >= 9 ? maxDate.Year : maxDate.Year - 1;
                semStart = new DateTime(startYear, 9, 1);
                semEnd = new DateTime(endYear + 1, 8, 31);
            }

            var week1Start = GetMondayOfWeek(semStart);
            var allWeeks = new List<DateTime>();
            var monday = week1Start;
            while (monday <= semEnd)
            {
                allWeeks.Add(monday);
                monday = monday.AddDays(7);
            }

            var colStudentSummary = new DataGridViewTextBoxColumn
            {
                HeaderText = "ФИО",
                ReadOnly = true,
                Frozen = true,
                FillWeight = 30F,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(26, 28, 46),
                    SelectionBackColor = Color.FromArgb(50, 80, 140),
                    SelectionForeColor = Color.White
                }
            };
            dataGridViewAttendance.Columns.Add(colStudentSummary);

            var colTotal = new DataGridViewTextBoxColumn
            {
                HeaderText = "Итого часов",
                ReadOnly = true,
                Frozen = true,
                FillWeight = 14F,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.FromArgb(76, 175, 80),
                    BackColor = Color.FromArgb(26, 28, 46),
                    SelectionBackColor = Color.FromArgb(50, 80, 140),
                    SelectionForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold)
                }
            };
            dataGridViewAttendance.Columns.Add(colTotal);

            for (int i = 0; i < allWeeks.Count; i++)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    HeaderText = $"Нед. {i + 1}",
                    ReadOnly = true,
                    FillWeight = 8F,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        ForeColor = Color.White,
                        BackColor = Color.FromArgb(26, 28, 46),
                        SelectionBackColor = Color.FromArgb(50, 80, 140),
                        SelectionForeColor = Color.White
                    }
                };
                dataGridViewAttendance.Columns.Add(col);
            }

            foreach (var student in _group.Students)
            {
                var studentRecords = allRecords.Where(r => r.StudentId == student.Id).ToList();
                int totalHours = 0;
                var weekValues = new string[allWeeks.Count];
                for (int w = 0; w < allWeeks.Count; w++)
                {
                    var weekStart = allWeeks[w];
                    var weekEnd = weekStart.AddDays(6);
                    int weekHours = studentRecords
                        .Where(r => r.Date >= weekStart && r.Date <= weekEnd)
                        .Sum(r => r.AbsenceHours);
                    weekValues[w] = weekHours > 0 ? weekHours.ToString() : "";
                    totalHours += weekHours;
                }

                var rowValues = new object[2 + allWeeks.Count];
                rowValues[0] = student.FullName;
                rowValues[1] = totalHours > 0 ? totalHours.ToString() : "0";
                Array.Copy(weekValues, 0, rowValues, 2, allWeeks.Count);

                int rowIdx = dataGridViewAttendance.Rows.Add(rowValues);
                dataGridViewAttendance.Rows[rowIdx].Tag = student;
            }

            dataGridViewAttendance.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(150, 150, 180);
        }

        private static DateTime GetMondayOfWeek(DateTime date)
        {
            int dow = (int)date.DayOfWeek;
            int diff = dow == 0 ? -6 : 1 - dow;
            return date.AddDays(diff);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
