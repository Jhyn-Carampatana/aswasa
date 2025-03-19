using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form if needed
        }

        private void button0_Click(object sender, EventArgs e)
        {
            EnterNumber("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnterNumber("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterNumber("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnterNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnterNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EnterNumber("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EnterNumber("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EnterNumber("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EnterNumber("9");
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            if (!displayTextBox.Text.Contains("."))
            {
                EnterNumber(".");
            }
        }

        private void EnterNumber(string number)
        {
            if (displayTextBox.Text == "0" || isOperationPerformed)
            {
                displayTextBox.Clear();
                isOperationPerformed = false;
            }

            displayTextBox.Text += number;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation("×");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation("÷");
        }

        private void PerformOperation(string op)
        {
            if (!isOperationPerformed)
            {
                if (operation != "")
                {
                    // If there's already an operation, calculate it first
                    buttonEquals_Click(null, null);
                }
                firstNumber = double.Parse(displayTextBox.Text);
                operation = op;
                isOperationPerformed = true;
            }
            else
            {
                // Change operation if needed
                operation = op;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                double secondNumber = double.Parse(displayTextBox.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "×":
                        result = firstNumber * secondNumber;
                        break;
                    case "÷":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        return;
                }

                // Format result to avoid unnecessary decimal places
                displayTextBox.Text = result.ToString();
                operation = "";
                isOperationPerformed = false;
                firstNumber = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // DEL button - delete last character
            if (displayTextBox.Text.Length > 0)
            {
                displayTextBox.Text = displayTextBox.Text.Remove(displayTextBox.Text.Length - 1);
            }

            if (displayTextBox.Text == "")
            {
                displayTextBox.Text = "0";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationPerformed = false;
        }
    }
}
