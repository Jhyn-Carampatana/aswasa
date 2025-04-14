using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace SemiFinalActivity2
{
    public partial class StudentForm : Form
    {
        // Define a data table to store student records
        private DataTable dtStudents;
        private bool isEditMode = false;
        private string selectedID = string.Empty;

        // File path for saving/loading student data
        private readonly string dataFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "StudentRecords.csv");

        public StudentForm()
        {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Initialize the DataTable with appropriate columns
            InitializeDataTable();

            // Load data from file if exists
            LoadDataFromFile();

            // Set default year level
            if (cbYearLevel.Items.Count > 0)
                cbYearLevel.SelectedIndex = 0;

            // Disable update and delete buttons initially
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            // Update status
            UpdateStatus($"Total Records: {dtStudents.Rows.Count}");
        }

        private void InitializeDataTable()
        {
            dtStudents = new DataTable();

            // Add columns
            dtStudents.Columns.Add("ID", typeof(string));
            dtStudents.Columns.Add("FirstName", typeof(string));
            dtStudents.Columns.Add("LastName", typeof(string));
            dtStudents.Columns.Add("MiddleName", typeof(string));
            dtStudents.Columns.Add("Course", typeof(string));
            dtStudents.Columns.Add("YearLevel", typeof(string));
            dtStudents.Columns.Add("Birthday", typeof(DateTime));

            // Set DataGridView data source
            dgvStudents.DataSource = dtStudents;

            // Format column headers
            if (dgvStudents.Columns.Count > 0)
            {
                dgvStudents.Columns["ID"].HeaderText = "ID Number";
                dgvStudents.Columns["FirstName"].HeaderText = "First Name";
                dgvStudents.Columns["LastName"].HeaderText = "Last Name";
                dgvStudents.Columns["MiddleName"].HeaderText = "Middle Name";
                dgvStudents.Columns["Course"].HeaderText = "Course";
                dgvStudents.Columns["YearLevel"].HeaderText = "Year Level";
                dgvStudents.Columns["Birthday"].HeaderText = "Birthday";
                dgvStudents.Columns["Birthday"].DefaultCellStyle.Format = "yyyy/MM/dd";
            }
        }

        private void LoadDataFromFile()
        {
            try
            {
                if (File.Exists(dataFilePath))
                {
                    string[] lines = File.ReadAllLines(dataFilePath);

                    // Skip header line if exists
                    for (int i = (lines[0].StartsWith("ID,") ? 1 : 0); i < lines.Length; i++)
                    {
                        string[] data = lines[i].Split(',');
                        if (data.Length >= 7)
                        {
                            DataRow row = dtStudents.NewRow();
                            row["ID"] = data[0];
                            row["FirstName"] = data[1];
                            row["LastName"] = data[2];
                            row["MiddleName"] = data[3];
                            row["Course"] = data[4];
                            row["YearLevel"] = data[5];

                            if (DateTime.TryParse(data[6], out DateTime birthday))
                                row["Birthday"] = birthday;
                            else
                                row["Birthday"] = DateTime.Today;

                            dtStudents.Rows.Add(row);
                        }
                    }

                    UpdateStatus($"Loaded {dtStudents.Rows.Count} records from file");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Data Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDataToFile()
        {
            try
            {
                List<string> lines = new List<string>();

                // Add header
                lines.Add("ID,FirstName,LastName,MiddleName,Course,YearLevel,Birthday");

                // Add data rows
                foreach (DataRow row in dtStudents.Rows)
                {
                    string line = string.Format("{0},{1},{2},{3},{4},{5},{6}",
                        row["ID"],
                        row["FirstName"],
                        row["LastName"],
                        row["MiddleName"],
                        row["Course"],
                        row["YearLevel"],
                        ((DateTime)row["Birthday"]).ToString("yyyy/MM/dd")
                    );
                    lines.Add(line);
                }

                // Write to file
                File.WriteAllLines(dataFilePath, lines);
                UpdateStatus($"Data saved to file. Total records: {dtStudents.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}", "Data Save Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Check if ID already exists
                if (IDExists(txtIDNumber.Text) && !isEditMode)
                {
                    MessageBox.Show("ID Number already exists. Please use a different ID.",
                        "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIDNumber.Focus();
                    return;
                }

                if (isEditMode)
                {
                    // Update existing record
                    UpdateRecord();
                }
                else
                {
                    // Add new record
                    AddNewRecord();
                }

                // Save data to file
                SaveDataToFile();

                // Clear form fields
                ClearFields();

                // Reset edit mode
                isEditMode = false;
                selectedID = string.Empty;
                btnSave.Text = "Save";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private bool ValidateInput()
        {
            // Check ID Number
            if (string.IsNullOrWhiteSpace(txtIDNumber.Text))
            {
                MessageBox.Show("ID Number is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDNumber.Focus();
                return false;
            }

            // Check First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // Check Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // Check Course
            if (string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Course is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCourse.Focus();
                return false;
            }

            // Check Year Level
            if (cbYearLevel.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Year Level!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbYearLevel.Focus();
                return false;
            }

            return true;
        }

        private bool IDExists(string id)
        {
            DataRow[] rows = dtStudents.Select($"ID = '{id}'");
            return rows.Length > 0;
        }

        private void AddNewRecord()
        {
            try
            {
                DataRow row = dtStudents.NewRow();
                row["ID"] = txtIDNumber.Text;
                row["FirstName"] = txtFirstName.Text;
                row["LastName"] = txtLastName.Text;
                row["MiddleName"] = txtMiddleName.Text;
                row["Course"] = txtCourse.Text;
                row["YearLevel"] = cbYearLevel.SelectedItem.ToString();
                row["Birthday"] = dtpBirthday.Value;

                dtStudents.Rows.Add(row);
                UpdateStatus($"New student record added. Total records: {dtStudents.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}", "Add Record Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecord()
        {
            try
            {
                DataRow[] rows = dtStudents.Select($"ID = '{selectedID}'");
                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    row["ID"] = txtIDNumber.Text;
                    row["FirstName"] = txtFirstName.Text;
                    row["LastName"] = txtLastName.Text;
                    row["MiddleName"] = txtMiddleName.Text;
                    row["Course"] = txtCourse.Text;
                    row["YearLevel"] = cbYearLevel.SelectedItem.ToString();
                    row["Birthday"] = dtpBirthday.Value;

                    UpdateStatus("Student record updated successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating record: {ex.Message}", "Update Record Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                isEditMode = true;
                selectedID = dgvStudents.SelectedRows[0].Cells["ID"].Value.ToString();

                // Load selected data to form
                LoadSelectedRecord();

                btnSave.Text = "Save Changes";
                UpdateStatus("Editing record - click Save Changes when done");
            }
            else
            {
                MessageBox.Show("Please select a record to update", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadSelectedRecord()
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStudents.SelectedRows[0];

                txtIDNumber.Text = row.Cells["ID"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtMiddleName.Text = row.Cells["MiddleName"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();

                string yearLevel = row.Cells["YearLevel"].Value.ToString();
                for (int i = 0; i < cbYearLevel.Items.Count; i++)
                {
                    if (cbYearLevel.Items[i].ToString() == yearLevel)
                    {
                        cbYearLevel.SelectedIndex = i;
                        break;
                    }
                }

                dtpBirthday.Value = Convert.ToDateTime(row.Cells["Birthday"].Value);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                string id = dgvStudents.SelectedRows[0].Cells["ID"].Value.ToString();
                string name = $"{dgvStudents.SelectedRows[0].Cells["FirstName"].Value} {dgvStudents.SelectedRows[0].Cells["LastName"].Value}";

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the record of {name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteRecord(id);
                    SaveDataToFile();
                    ClearFields();
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteRecord(string id)
        {
            try
            {
                DataRow[] rows = dtStudents.Select($"ID = '{id}'");
                if (rows.Length > 0)
                {
                    rows[0].Delete();
                    dtStudents.AcceptChanges();
                    UpdateStatus($"Record deleted. Total records: {dtStudents.Rows.Count}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}", "Delete Record Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            isEditMode = false;
            selectedID = string.Empty;
            btnSave.Text = "Save";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            UpdateStatus("Form cleared");
        }

        private void ClearFields()
        {
            txtIDNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtCourse.Clear();
            if (cbYearLevel.Items.Count > 0)
                cbYearLevel.SelectedIndex = 0;
            dtpBirthday.Value = new DateTime(2000, 1, 1);
            txtIDNumber.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudent();
        }

        private void SearchStudent()
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an ID to search", "Empty Search",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSearch.Focus();
                return;
            }

            DataView dv = dtStudents.DefaultView;
            dv.RowFilter = $"ID = '{searchText}'";

            if (dv.Count > 0)
            {
                dgvStudents.DataSource = dv.ToTable();
                UpdateStatus($"Found {dv.Count} matching record(s)");
            }
            else
            {
                MessageBox.Show("No record found with the specified ID", "No Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvStudents.DataSource = dtStudents; // Show all records again
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            dgvStudents.DataSource = dtStudents; // Show all records
            UpdateStatus($"Showing all records. Total records: {dtStudents.Rows.Count}");
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Make sure a valid row is clicked
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                selectedID = dgvStudents.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                UpdateStatus($"Selected student ID: {selectedID}");
            }
        }

        private void UpdateStatus(string message)
        {
            statusLabel.Text = message;
        }

        // Input validation for ID Number (only numbers)
        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Input validation for Course (only letters and spaces)
        private void txtCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Input validation for Search (only numbers)
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // If Enter key is pressed, perform search
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchStudent();
            }
        }
    }
}
