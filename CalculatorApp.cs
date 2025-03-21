using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        private string currentInput = "";
        private string currentExpression = "";
        private bool operatorClicked = false;
        private bool decimalPointAdded = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            // If 0 is pressed and followed with a non-zero digit, only display the non-zero digit
            if (currentInput == "0" && buttonText != ".")
            {
                currentInput = buttonText;
            }
            else
            {
                currentInput += buttonText;
            }

            operatorClicked = false;
            displayTextBox.Text = currentInput;
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operatorSymbol = button.Text;

            // Only add operator if there's input or existing expression
            if (!string.IsNullOrEmpty(currentInput) || !string.IsNullOrEmpty(currentExpression))
            {
                // If an operator was just clicked, replace it
                if (operatorClicked && !string.IsNullOrEmpty(currentExpression))
                {
                    currentExpression = currentExpression.Substring(0, currentExpression.Length - 1) + operatorSymbol;
                }
                else
                {
                    // Add current input to expression with operator
                    currentExpression += currentInput + operatorSymbol;
                    currentInput = "";
                }

                operatorClicked = true;
                decimalPointAdded = false;
                expressionLabel.Text = currentExpression;
                displayTextBox.Text = "0";
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            // Only add decimal point if not already added
            if (!decimalPointAdded)
            {
                // If no input yet, start with "0."
                if (string.IsNullOrEmpty(currentInput))
                {
                    currentInput = "0.";
                }
                else
                {
                    currentInput += ".";
                }

                decimalPointAdded = true;
                displayTextBox.Text = currentInput;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput) || !string.IsNullOrEmpty(currentExpression))
            {
                string fullExpression = currentExpression + currentInput;

                // Remove trailing operator if present
                if (operatorClicked)
                {
                    fullExpression = fullExpression.Substring(0, fullExpression.Length - 1);
                }

                try
                {
                    // Evaluate the expression following MDAS order
                    DataTable dt = new DataTable();
                    var result = dt.Compute(fullExpression, "");

                    // Display result
                    displayTextBox.Text = result.ToString();
                    expressionLabel.Text = fullExpression + "=";

                    // Reset for new calculation
                    currentInput = result.ToString();
                    currentExpression = "";
                    operatorClicked = false;
                    decimalPointAdded = currentInput.Contains(".");
                }
                catch (Exception ex)
                {
                    displayTextBox.Text = "Error";
                    currentInput = "";
                    currentExpression = "";
                    operatorClicked = false;
                    decimalPointAdded = false;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear everything
            currentInput = "";
            currentExpression = "";
            operatorClicked = false;
            decimalPointAdded = false;
            displayTextBox.Text = "0";
            expressionLabel.Text = "";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            // Delete the rightmost digit
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Check if we're removing a decimal point
                if (currentInput.EndsWith("."))
                {
                    decimalPointAdded = false;
                }

                currentInput = currentInput.Substring(0, currentInput.Length - 1);

                // If all digits are removed, display 0
                if (string.IsNullOrEmpty(currentInput))
                {
                    displayTextBox.Text = "0";
                }
                else
                {
                    displayTextBox.Text = currentInput;
                }
            }
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Toggle between positive and negative
                if (currentInput.StartsWith("-"))
                {
                    currentInput = currentInput.Substring(1);
                }
                else
                {
                    currentInput = "-" + currentInput;
                }

                displayTextBox.Text = currentInput;
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
