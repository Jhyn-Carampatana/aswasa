
namespace MidtermActivity2B
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTitle = new Label();
            lblIdNumber = new Label();
            txtIdNumber = new TextBox();
            lblCourse = new Label();
            txtCourse = new TextBox();
            lblYearLevel = new Label();
            txtYearLevel = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblMiddleName = new Label();
            txtMiddleName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblHomeAddress = new Label();
            txtHomeAddress = new TextBox();
            lblFatherName = new Label();
            txtFatherName = new TextBox();
            lblMotherName = new Label();
            txtMotherName = new TextBox();
            lblDateOfBirth = new Label();
            txtDateOfBirth = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblParentContact = new Label();
            txtParentContact = new TextBox();
            lblSkillsInterests = new Label();
            txtSkillsInterests = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(633, 83);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(149, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(307, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Student Information Form";
            // 
            // lblIdNumber
            // 
            lblIdNumber.AutoSize = true;
            lblIdNumber.Location = new Point(75, 112);
            lblIdNumber.Margin = new Padding(4, 0, 4, 0);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(92, 15);
            lblIdNumber.TabIndex = 1;
            lblIdNumber.Text = "What is your ID?";
            // 
            // txtIdNumber
            // 
            txtIdNumber.BackColor = Color.White;
            txtIdNumber.ForeColor = SystemColors.WindowText;
            txtIdNumber.Location = new Point(308, 104);
            txtIdNumber.Margin = new Padding(4, 3, 4, 3);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(267, 23);
            txtIdNumber.TabIndex = 2;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(75, 139);
            lblCourse.Margin = new Padding(4, 0, 4, 0);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(116, 15);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "What is your course?";
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(308, 139);
            txtCourse.Margin = new Padding(4, 3, 4, 3);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(267, 23);
            txtCourse.TabIndex = 4;
            // 
            // lblYearLevel
            // 
            lblYearLevel.AutoSize = true;
            lblYearLevel.Location = new Point(75, 172);
            lblYearLevel.Margin = new Padding(4, 0, 4, 0);
            lblYearLevel.Name = "lblYearLevel";
            lblYearLevel.Size = new Size(130, 15);
            lblYearLevel.TabIndex = 5;
            lblYearLevel.Text = "What is your year level?";
            // 
            // txtYearLevel
            // 
            txtYearLevel.Location = new Point(308, 172);
            txtYearLevel.Margin = new Padding(4, 3, 4, 3);
            txtYearLevel.Name = "txtYearLevel";
            txtYearLevel.Size = new Size(267, 23);
            txtYearLevel.TabIndex = 6;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(75, 198);
            lblFirstName.Margin = new Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(134, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "What is your first name?";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(308, 198);
            txtFirstName.Margin = new Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(267, 23);
            txtFirstName.TabIndex = 8;
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Location = new Point(75, 228);
            lblMiddleName.Margin = new Padding(4, 0, 4, 0);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(206, 15);
            lblMiddleName.TabIndex = 9;
            lblMiddleName.Text = "What is your middle name? (optional)";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(308, 228);
            txtMiddleName.Margin = new Padding(4, 3, 4, 3);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(267, 23);
            txtMiddleName.TabIndex = 10;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(75, 258);
            lblLastName.Margin = new Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(203, 15);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "What is your last name/family name?";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(308, 258);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(267, 23);
            txtLastName.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(75, 288);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(153, 15);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "What is your email address?";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(308, 288);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(267, 23);
            txtEmail.TabIndex = 14;
            // 
            // lblHomeAddress
            // 
            lblHomeAddress.AutoSize = true;
            lblHomeAddress.Location = new Point(75, 318);
            lblHomeAddress.Margin = new Padding(4, 0, 4, 0);
            lblHomeAddress.Name = "lblHomeAddress";
            lblHomeAddress.Size = new Size(155, 15);
            lblHomeAddress.TabIndex = 15;
            lblHomeAddress.Text = "What is your home address?";
            // 
            // txtHomeAddress
            // 
            txtHomeAddress.Location = new Point(308, 318);
            txtHomeAddress.Margin = new Padding(4, 3, 4, 3);
            txtHomeAddress.Name = "txtHomeAddress";
            txtHomeAddress.Size = new Size(267, 23);
            txtHomeAddress.TabIndex = 16;
            // 
            // lblFatherName
            // 
            lblFatherName.AutoSize = true;
            lblFatherName.Location = new Point(75, 348);
            lblFatherName.Margin = new Padding(4, 0, 4, 0);
            lblFatherName.Name = "lblFatherName";
            lblFatherName.Size = new Size(153, 15);
            lblFatherName.TabIndex = 17;
            lblFatherName.Text = "What is your father's name?";
            // 
            // txtFatherName
            // 
            txtFatherName.Location = new Point(308, 348);
            txtFatherName.Margin = new Padding(4, 3, 4, 3);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.Size = new Size(267, 23);
            txtFatherName.TabIndex = 18;
            // 
            // lblMotherName
            // 
            lblMotherName.AutoSize = true;
            lblMotherName.Location = new Point(75, 378);
            lblMotherName.Margin = new Padding(4, 0, 4, 0);
            lblMotherName.Name = "lblMotherName";
            lblMotherName.Size = new Size(161, 15);
            lblMotherName.TabIndex = 19;
            lblMotherName.Text = "What is your mother's name?";
            // 
            // txtMotherName
            // 
            txtMotherName.Location = new Point(308, 378);
            txtMotherName.Margin = new Padding(4, 3, 4, 3);
            txtMotherName.Name = "txtMotherName";
            txtMotherName.Size = new Size(267, 23);
            txtMotherName.TabIndex = 20;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(75, 408);
            lblDateOfBirth.Margin = new Padding(4, 0, 4, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(146, 15);
            lblDateOfBirth.TabIndex = 21;
            lblDateOfBirth.Text = "What is your date of birth?";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.Location = new Point(308, 408);
            txtDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(267, 23);
            txtDateOfBirth.TabIndex = 22;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(75, 438);
            lblAge.Margin = new Padding(4, 0, 4, 0);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 15);
            lblAge.TabIndex = 23;
            lblAge.Text = "What is your age?";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(308, 438);
            txtAge.Margin = new Padding(4, 3, 4, 3);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(267, 23);
            txtAge.TabIndex = 24;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(75, 468);
            lblPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(160, 15);
            lblPhoneNumber.TabIndex = 25;
            lblPhoneNumber.Text = "What is your phone number?";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(308, 468);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(267, 23);
            txtPhoneNumber.TabIndex = 26;
            // 
            // lblParentContact
            // 
            lblParentContact.AutoSize = true;
            lblParentContact.Location = new Point(75, 498);
            lblParentContact.Margin = new Padding(4, 0, 4, 0);
            lblParentContact.Name = "lblParentContact";
            lblParentContact.Size = new Size(224, 15);
            lblParentContact.TabIndex = 27;
            lblParentContact.Text = "What is your parent contact information?";
            // 
            // txtParentContact
            // 
            txtParentContact.Location = new Point(308, 498);
            txtParentContact.Margin = new Padding(4, 3, 4, 3);
            txtParentContact.Name = "txtParentContact";
            txtParentContact.Size = new Size(267, 23);
            txtParentContact.TabIndex = 28;
            // 
            // lblSkillsInterests
            // 
            lblSkillsInterests.AutoSize = true;
            lblSkillsInterests.Location = new Point(75, 528);
            lblSkillsInterests.Margin = new Padding(4, 0, 4, 0);
            lblSkillsInterests.Name = "lblSkillsInterests";
            lblSkillsInterests.Size = new Size(184, 15);
            lblSkillsInterests.TabIndex = 29;
            lblSkillsInterests.Text = "What are your skills and interests?";
            // 
            // txtSkillsInterests
            // 
            txtSkillsInterests.Location = new Point(308, 528);
            txtSkillsInterests.Margin = new Padding(4, 3, 4, 3);
            txtSkillsInterests.Multiline = true;
            txtSkillsInterests.Name = "txtSkillsInterests";
            txtSkillsInterests.Size = new Size(267, 64);
            txtSkillsInterests.TabIndex = 30;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Green;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(308, 608);
            btnSubmit.Margin = new Padding(4, 3, 4, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(118, 40);
            btnSubmit.TabIndex = 31;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Black;
            btnClear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ControlLightLight;
            btnClear.Location = new Point(456, 608);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(119, 40);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(633, 682);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtSkillsInterests);
            Controls.Add(lblSkillsInterests);
            Controls.Add(txtParentContact);
            Controls.Add(lblParentContact);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtMotherName);
            Controls.Add(lblMotherName);
            Controls.Add(txtFatherName);
            Controls.Add(lblFatherName);
            Controls.Add(txtHomeAddress);
            Controls.Add(lblHomeAddress);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(lblMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtYearLevel);
            Controls.Add(lblYearLevel);
            Controls.Add(txtCourse);
            Controls.Add(lblCourse);
            Controls.Add(txtIdNumber);
            Controls.Add(lblIdNumber);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Information Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Build a string containing all the information
            string studentInfo =
                $"ID Number: {txtIdNumber.Text}\r\n" +
                $"Course: {txtCourse.Text}\r\n" +
                $"Year Level: {txtYearLevel.Text}\r\n" +
                $"Name: {txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}\r\n" +
                $"Email: {txtEmail.Text}\r\n" +
                $"Home Address: {txtHomeAddress.Text}\r\n" +
                $"Father's Name: {txtFatherName.Text}\r\n" +
                $"Mother's Name: {txtMotherName.Text}\r\n" +
                $"Date of Birth: {txtDateOfBirth.Text}\r\n" +
                $"Age: {txtAge.Text}\r\n" +
                $"Phone Number: {txtPhoneNumber.Text}\r\n" +
                $"Parent Contact: {txtParentContact.Text}\r\n" +
                $"Skills/Interests: {txtSkillsInterests.Text}";

            // Display the information in a message box
            MessageBox.Show(studentInfo, "Student Information Summary",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Show the success message after displaying the information
            MessageBox.Show("Student information submitted successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label lblYearLevel;
        private System.Windows.Forms.TextBox txtYearLevel;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.TextBox txtHomeAddress;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblMotherName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblParentContact;
        private System.Windows.Forms.TextBox txtParentContact;
        private System.Windows.Forms.Label lblSkillsInterests;
        private System.Windows.Forms.TextBox txtSkillsInterests;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
    }

    }

