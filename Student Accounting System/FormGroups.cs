using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormGroups : Form
    {
        private List<Group> _allGroups;

        public FormGroups()
        {
            InitializeComponent();
            _allGroups = DataStore.Groups;
            LoadGroups(_allGroups);
            UpdateStats();
        }

        private void LoadGroups(List<Group> groups)
        {
            dataGridViewGroups.Rows.Clear();
            foreach (var g in groups)
            {
                int count = g.Students.Count;
                double avg = count > 0 ? g.Students.Average(s => s.AverageGrade) : 0;
                dataGridViewGroups.Rows.Add(g.Name, g.SubGroup, count, avg > 0 ? avg.ToString("F2") : "—");
            }
            lblTotalGroups.Text = groups.Count.ToString();
            int totalStudents = groups.Sum(g => g.Students.Count);
            lblTotalStudents.Text = totalStudents.ToString();
            double globalAvg = groups.SelectMany(g => g.Students).Any()
                ? groups.SelectMany(g => g.Students).Average(s => s.AverageGrade)
                : 0;
            lblAvgGrade.Text = globalAvg > 0 ? globalAvg.ToString("F2") : "—";
        }

        private void UpdateStats()
        {
            int totalGroups = _allGroups.Count;
            int totalStudents = _allGroups.Sum(g => g.Students.Count);
            double avg = _allGroups.SelectMany(g => g.Students).Any()
                ? _allGroups.SelectMany(g => g.Students).Average(s => s.AverageGrade)
                : 0;
            lblTotalGroups.Text = totalGroups.ToString();
            lblTotalStudents.Text = totalStudents.ToString();
            lblAvgGrade.Text = avg > 0 ? avg.ToString("F2") : "—";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(query))
            {
                LoadGroups(_allGroups);
                return;
            }
            var filtered = _allGroups
                .Where(g => g.Name.ToLower().Contains(query) || g.SubGroup.ToLower().Contains(query))
                .ToList();
            LoadGroups(filtered);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnSearch_Click(sender, e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text)) LoadGroups(_allGroups);
        }

        private void dataGridViewGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenSelectedGroup();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenSelectedGroup();
        }

        private void OpenSelectedGroup()
        {
            if (dataGridViewGroups.SelectedRows.Count == 0) return;
            int idx = dataGridViewGroups.SelectedRows[0].Index;
            string query = txtSearch.Text.Trim().ToLower();
            List<Group> current = string.IsNullOrEmpty(query)
                ? _allGroups
                : _allGroups.Where(g => g.Name.ToLower().Contains(query) || g.SubGroup.ToLower().Contains(query)).ToList();
            if (idx < 0 || idx >= current.Count) return;
            var group = current[idx];
            var form = new FormStudents(group);
            form.Show();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var dlg = new FormGroupEdit(null);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _allGroups.Add(dlg.ResultGroup);
                LoadGroups(_allGroups);
                UpdateStats();
            }
        }

        private void btnEditGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0) return;
            int idx = dataGridViewGroups.SelectedRows[0].Index;
            if (idx < 0 || idx >= _allGroups.Count) return;
            var group = _allGroups[idx];
            var dlg = new FormGroupEdit(group);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadGroups(_allGroups);
                UpdateStats();
            }
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0) return;
            int idx = dataGridViewGroups.SelectedRows[0].Index;
            if (idx < 0 || idx >= _allGroups.Count) return;
            var group = _allGroups[idx];
            var result = MessageBox.Show(
                $"Удалить группу {group.Name}-{group.SubGroup}?",
                "Подтверждение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _allGroups.RemoveAt(idx);
                LoadGroups(_allGroups);
                UpdateStats();
            }
        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewGroups.Columns["colOpen"].Index)
                OpenSelectedGroup();
        }

        private void dataGridViewGroups_SelectionChanged(object sender, EventArgs e)
        {
            bool hasSelection = dataGridViewGroups.SelectedRows.Count > 0;
            btnEditGroup.Enabled = hasSelection;
            btnDeleteGroup.Enabled = hasSelection;
            btnOpen.Enabled = hasSelection;
        }
    }
}
