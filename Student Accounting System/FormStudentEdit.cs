using System;
using System.Globalization;
using System.Windows.Forms;

namespace Student_Accounting_System
{
    public partial class FormStudentEdit : Form
    {
        public Student ResultStudent { get; private set; }
        private readonly Student _existing;

        public FormStudentEdit(Student existing)
        {
            InitializeComponent();
            _existing = existing;

            if (existing != null)
            {
                this.Text = "Редактировать студента";
                txtLastName.Text = existing.LastName;
                txtFirstName.Text = existing.FirstName;
                txtMiddleName.Text = existing.MiddleName;
                txtBirthDate.Text = existing.BirthDate == DateTime.MinValue
                    ? ""
                    : existing.BirthDate.ToString("dd.MM.yyyy");
                txtPhone.Text = existing.Phone;
                txtEmail.Text = existing.Email;
                txtAddress.Text = existing.Address;
                cmbStatus.SelectedIndex = (int)existing.Status;
            }
            else
            {
                this.Text = "Добавить студента";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Фамилия и Имя обязательны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime birthDate = DateTime.MinValue;
            if (!string.IsNullOrWhiteSpace(txtBirthDate.Text.Replace(".", "").Trim()))
                DateTime.TryParseExact(txtBirthDate.Text, "dd.MM.yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);

            if (_existing != null)
            {
                _existing.LastName = txtLastName.Text.Trim();
                _existing.FirstName = txtFirstName.Text.Trim();
                _existing.MiddleName = txtMiddleName.Text.Trim();
                _existing.BirthDate = birthDate;
                _existing.Phone = txtPhone.Text.Trim();
                _existing.Email = txtEmail.Text.Trim();
                _existing.Address = txtAddress.Text.Trim();
                _existing.Status = (StudentStatus)cmbStatus.SelectedIndex;
                ResultStudent = _existing;
            }
            else
            {
                ResultStudent = new Student
                {
                    Id = DataStore.NextStudentId(),
                    LastName = txtLastName.Text.Trim(),
                    FirstName = txtFirstName.Text.Trim(),
                    MiddleName = txtMiddleName.Text.Trim(),
                    BirthDate = birthDate,
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Status = (StudentStatus)cmbStatus.SelectedIndex
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
