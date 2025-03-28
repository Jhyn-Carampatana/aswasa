using System;
using System.Text;
using System.Windows.Forms;
namespace HealthSurvey
{
    public partial class HealthSurvey : Form
    {
        private object numGoalWeight;

        public HealthSurvey()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine("Health Survey Summary:");
            summary.AppendLine($"Name: {txtFirstName.Text} {txtLastName.Text}");
            summary.AppendLine($"Email: {txtEmail.Text}");
            summary.AppendLine($"Phone: {txtPhone.Text}");
            summary.AppendLine($"Address: {txtAddress.Text}");
            summary.AppendLine($"Birthdate: {dtpBirthdate.Value.ToShortDateString()}");
            summary.AppendLine($"Age: {numAge.Value}");
            summary.AppendLine($"Gender: {(rbMale.Checked ? "Male" : "Female")}");
            // Medical Conditions
            summary.AppendLine("Medical Conditions:");
            if (chkBP.Checked) summary.AppendLine("- High Blood Pressure");
            if (chkDiabetes1.Checked) summary.AppendLine("- Diabetes Type 1");
            if (chkDiabetes2.Checked) summary.AppendLine("- Diabetes Type 2");
            if (chkGout.Checked) summary.AppendLine("- Gout");
            // Medications
            summary.AppendLine("Medications:");
            bool hasMedications = false;
            if (chkDiabetes1.Checked)
            {
                summary.AppendLine("- Diabetes Medication");
                hasMedications = true;
            }
            if (chkBP.Checked)
            {
                summary.AppendLine("- High Blood Pressure Medication");
                hasMedications = true;
            }
            if (chkDiabetes2.Checked)
            {
                summary.AppendLine("- High Cholesterol Medication");
                hasMedications = true;
            }
            if (!hasMedications)
            {
                summary.AppendLine("- None");
            }
            // BMI
            summary.AppendLine($"Height: {numHeight.Value} cm");
            summary.AppendLine($"Weight: {numWeight.Value} kg");
            summary.AppendLine($"Current BMI: {numCurrentBMI.Value}");
            summary.AppendLine($"Target BMI: {numTargetBMI.Value}");
            // Sleep
            summary.AppendLine($"Bedtime: {txtBedtime.Text}");
            summary.AppendLine($"Wake-up Time: {txtWakeTime.Text}");
            summary.AppendLine($"Sleep Hours: {numSleepHours.Value}");
            summary.AppendLine($"Wake up Rested: {(rbRestedYes.Checked ? "Yes" : "No")}");
            // Stress
            summary.AppendLine($"Work: {txtWork.Text}");
            summary.AppendLine($"Enjoy Work: {(rbEnjoyWorkYes.Checked ? "Yes" : "No")}");
            summary.AppendLine($"Stress Level: {numStress.Value}");
            // Eating Habits
            summary.AppendLine($"First Meal: {txtFirstMeal.Text}");
            summary.AppendLine($"Last Meal: {txtLastMeal.Text}");
            summary.AppendLine($"Meals per Day: {numMealsPerDay.Value}");
            // Exercise & Weight
            summary.AppendLine($"Current Weight: {numWeight.Value} kg");
            summary.AppendLine($"Exercise Frequency: {(cmbExercise.SelectedItem?.ToString() ?? "Not Selected")}");
            summary.AppendLine($"Smoking: {(cmbSmoking.SelectedItem?.ToString() ?? "Not Selected")}");
            rtbSummary.Text = summary.ToString();
        }
    }
}
