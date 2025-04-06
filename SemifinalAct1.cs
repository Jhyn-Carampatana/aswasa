using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Carampatana_SemifinalActivity1
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Set date format for the date time picker
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "yyyy/MM/dd";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all inputs before saving
            if (ValidateInputs())
            {
                SaveStudentRecord();
                MessageBox.Show("Student record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
        }

        private bool ValidateInputs()
        {
            // Validate ID Number (numbers only)
            if (string.IsNullOrWhiteSpace(txtIdNo.Text) || !Regex.IsMatch(txtIdNo.Text, @"^\d+$"))
            {
                MessageBox.Show("ID Number must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdNo.Focus();
                return false;
            }

            // Validate First Name (no special characters)
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || !Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("First Name must not contain special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return false;
            }

            // Validate Last Name (no special characters)
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || !Regex.IsMatch(txtLastName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Last Name must not contain special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastName.Focus();
                return false;
            }

            // Validate Middle Name (no special characters)
            if (!string.IsNullOrWhiteSpace(txtMiddleName.Text) && !Regex.IsMatch(txtMiddleName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Middle Name must not contain special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMiddleName.Focus();
                return false;
            }

            // Validate Course (no special characters)
            if (string.IsNullOrWhiteSpace(txtCourse.Text) || !Regex.IsMatch(txtCourse.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Course must not contain special characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourse.Focus();
                return false;
            }

            // Validate Year Level (numbers only)
            if (string.IsNullOrWhiteSpace(txtYearLevel.Text) || !Regex.IsMatch(txtYearLevel.Text, @"^\d+$"))
            {
                MessageBox.Show("Year Level must contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearLevel.Focus();
                return false;
            }

            return true;
        }

        private void SaveStudentRecord()
        {
            try
            {
                string filePath = "student_record.txt";
                bool fileExists = File.Exists(filePath);

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Add header if file is new
                    if (!fileExists)
                    {
                        writer.WriteLine("ID No,First Name,Last Name,Middle Name,Course,Year Level,Birthday");
                    }

                    // Format data as comma-separated values
                    string record = $"{txtIdNo.Text},{txtFirstName.Text},{txtLastName.Text},{txtMiddleName.Text},{txtCourse.Text},{txtYearLevel.Text},{dtpBirthday.Value.ToString("yyyy/MM/dd")}";
                    writer.WriteLine(record);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtIdNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();
            dtpBirthday.Value = DateTime.Now;
            txtIdNo.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
