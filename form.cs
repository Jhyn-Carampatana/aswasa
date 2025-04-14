using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SemiFinalActivity2
{
    public partial class StudentForm : Form
    {
        private const string FILE_PATH = "student_record.txt";
        private DataTable studentTable;
        private bool isEditMode = false;
        private int selectedRowIndex = -1;

        public StudentForm()
        {
            InitializeComponent();
            // Set the DateTimePicker to show only date (no time)
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "yyyy/MM/dd";
            dtpBirthday.MaxDate = DateTime.Today;
            dtpBirthday.Value = DateTime.Today;

            // Initialize DataTable
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            studentTable = new DataTable();
            studentTable.Columns.Add("ID Number", typeof(string));
            studentTable.Columns.Add("First Name", typeof(string));
            studentTable.Columns.Add("Last Name", typeof(string));
            studentTable.Columns.Add("Middle Name", typeof(string));
            studentTable.Columns.Add("Course", typeof(string));
            studentTable.Columns.Add("Year Level", typeof(string));
            studentTable.Columns.Add("Birthday", typeof(string));
        }

        private void LoadStudentData()
        {
            studentTable.Clear();
            if (File.Exists(FILE_PATH))
            {
                try
                {
                    string[] lines = File.ReadAllLines(FILE_PATH);
                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] data = line.Split('|');
                            if (data.Length == 7)
                            {
                                studentTable.Rows.Add(data);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dgvStudents.DataSource = studentTable;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate all fields before saving
            if (ValidateFields())
            {
                try
                {
                    // Check if ID already exists (except when in edit mode)
                    if (!isEditMode && IDExists(txtIDNumber.Text))
                    {
                        MessageBox.Show("A student with this ID number already exists!", "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDNumber.Focus();
                        return;
                    }

                    // Format the data
                    string studentData = $"{txtIDNumber.Text}|{txtFirstName.Text}|{txtLastName.Text}|{txtMiddleName.Text}|{txtCourse.Text}|{txtYearLevel.Text}|{dtpBirthday.Value.ToString("yyyy/MM/dd")}";

                    // Save to file (append mode)
                    if (!isEditMode)
                    {
                        using (StreamWriter writer = new StreamWriter(FILE_PATH, true))
                        {
                            writer.WriteLine(studentData);
                        }
                        MessageBox.Show("Student record saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        UpdateRecordInFile(txtIDNumber.Text, studentData);
                        isEditMode = false;
                        btnSave.Text = "Save";
                        MessageBox.Show("Student record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    ClearFields();
                    LoadStudentData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IDExists(string idNumber)
        {
            if (File.Exists(FILE_PATH))
            {
                string[] lines = File.ReadAllLines(FILE_PATH);
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] data = line.Split('|');
                        if (data.Length > 0 && data[0] == idNumber)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void UpdateRecordInFile(string idNumber, string newData)
        {
            if (File.Exists(FILE_PATH))
            {
                List<string> lines = File.ReadAllLines(FILE_PATH).ToList();
                bool recordFound = false;

                for (int i = 0; i < lines.Count; i++)
                {
                    if (!string.IsNullOrWhiteSpace(lines[i]))
                    {
                        string[] data = lines[i].Split('|');
                        if (data.Length > 0 && data[0] == idNumber)
                        {
                            lines[i] = newData;
                            recordFound = true;
                            break;
                        }
                    }
                }

                if (recordFound)
                {
                    File.WriteAllLines(FILE_PATH, lines);
                }
                else
                {
                    throw new Exception("Record not found for update");
                }
            }
        }

        private bool ValidateFields()
        {
            // ID Number validation (numbers only)
            if (string.IsNullOrWhiteSpace(txtIDNumber.Text) || !Regex.IsMatch(txtIDNumber.Text, @"^\d+$"))
            {
                MessageBox.Show("ID Number must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDNumber.Focus();
                return false;
            }

            // First Name validation (not empty)
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // Last Name validation (not empty)
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // Course validation (no numbers or special characters)
            if (string.IsNullOrWhiteSpace(txtCourse.Text) || !Regex.IsMatch(txtCourse.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Course must contain only letters and spaces!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return false;
            }

            // Year Level validation (numbers only)
            if (string.IsNullOrWhiteSpace(txtYearLevel.Text) || !Regex.IsMatch(txtYearLevel.Text, @"^\d+$"))
            {
                MessageBox.Show("Year Level must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYearLevel.Focus();
                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            txtIDNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();
            dtpBirthday.Value = DateTime.Today;
            txtIDNumber.Focus();

            // Reset edit mode
            isEditMode = false;
            btnSave.Text = "Save";
            selectedRowIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, spaces and control characters
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];

                txtIDNumber.Text = row.Cells["ID Number"].Value.ToString();
                txtFirstName.Text = row.Cells["First Name"].Value.ToString();
                txtLastName.Text = row.Cells["Last Name"].Value.ToString();
                txtMiddleName.Text = row.Cells["Middle Name"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();
                txtYearLevel.Text = row.Cells["Year Level"].Value.ToString();

                string birthdayString = row.Cells["Birthday"].Value.ToString();
                if (DateTime.TryParse(birthdayString, out DateTime birthday))
                {
                    dtpBirthday.Value = birthday;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1)
            {
                MessageBox.Show("Please select a student record to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Enable edit mode
            isEditMode = true;
            btnSave.Text = "Save Changes";
            txtIDNumber.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex == -1)
            {
                MessageBox.Show("Please select a student record to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string idNumber = dgvStudents.Rows[selectedRowIndex].Cells["ID Number"].Value.ToString();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete student with ID {idNumber}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteRecord(idNumber);
                LoadStudentData();
                ClearFields();
            }
        }

        private void DeleteRecord(string idNumber)
        {
            try
            {
                if (File.Exists(FILE_PATH))
                {
                    List<string> lines = File.ReadAllLines(FILE_PATH).ToList();
                    List<string> newLines = new List<string>();

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            string[] data = line.Split('|');
                            if (data.Length > 0 && data[0] != idNumber)
                            {
                                newLines.Add(line);
                            }
                        }
                    }

                    File.WriteAllLines(FILE_PATH, newLines);
                    MessageBox.Show("Student record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchId))
            {
                LoadStudentData();  // Reload all data if search box is empty
                return;
            }

            // Filter the data
            DataTable filteredTable = studentTable.Clone();  // Create empty table with same schema

            foreach (DataRow row in studentTable.Rows)
            {
                string idNumber = row["ID Number"].ToString();
                if (idNumber.Contains(searchId))
                {
                    filteredTable.ImportRow(row);
                }
            }

            dgvStudents.
