using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        // Variables to track calculation state
        private bool isNewCalculation = true;
        private string lastOperation = "";
        private double memory = 0;
        
        public Form1()
        {
            InitializeComponent();
            
            // Set form properties
            this.Text = "Modern Calculator";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(350, 450);
            this.BackColor = Color.FromArgb(45, 45, 45);
            
            // Style the textbox
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.ReadOnly = true;
            textBox1.BackColor = Color.FromArgb(30, 30, 30);
            textBox1.ForeColor = Color.White;
            textBox1.Dock = DockStyle.Top;
            textBox1.Height = 60;
            
            // Create button panel
            Panel buttonPanel = new Panel();
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Padding = new Padding(10);
            
            // Create and style all buttons
            StyleAllButtons();
            
            // Add controls to form
            this.Controls.Add(buttonPanel);
            this.Controls.Add(textBox1);
        }
        
        private void StyleAllButtons()
        {
            // Style number buttons
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    
                    // Style for number buttons
                    if (btn.Name.StartsWith("button") && btn.Name.Length == 7)
                    {
                        StyleButton(btn, Color.FromArgb(60, 60, 60), Color.White);
                    }
                    // Style for operation buttons
                    else if (btn.Name.Contains("Add") || btn.Name.Contains("Minus") || 
                             btn.Name.Contains("Divide") || btn.Name.Contains("Multiply"))
                    {
                        StyleButton(btn, Color.FromArgb(80, 80, 80), Color.FromArgb(255, 165, 0));
                    }
                    // Style for equals button
                    else if (btn.Name.Contains("Equals"))
                    {
                        StyleButton(btn, Color.FromArgb(255, 165, 0), Color.White);
                    }
                    // Style for clear and backspace
                    else if (btn.Name.Contains("Clear") || btn.Name == "button10")
                    {
                        StyleButton(btn, Color.FromArgb(180, 60, 60), Color.White);
                    }
                    // Style for decimal
                    else if (btn.Name.Contains("Decimal"))
                    {
                        StyleButton(btn, Color.FromArgb(60, 60, 60), Color.White);
                    }
                }
            }
        }
        
        private void StyleButton(Button btn, Color backColor, Color foreColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = foreColor;
            btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn.Size = new Size(70, 50);
            btn.Margin = new Padding(5);
            btn.UseVisualStyleBackColor = false;
            btn.TabStop = false;
            
            // Add hover effect
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(
                    Math.Min(backColor.R + 20, 255),
                    Math.Min(backColor.G + 20, 255),
                    Math.Min(backColor.B + 20, 255));
            };
            
            btn.MouseLeave += (s, e) => {
                btn.BackColor = backColor;
            };
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add animation effect when form loads
            this.Opacity = 0;
            Timer fadeIn = new Timer();
            fadeIn.Interval = 10;
            fadeIn.Tick += (s, args) => {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeIn.Stop();
            };
            fadeIn.Start();
        }
        
        private void setLabelTextByNumber(Int32 number)
        {
            if (isNewCalculation)
            {
                textBox1.Text = number.ToString();
                isNewCalculation = false;
            }
            else
            {
                textBox1.Text += number.ToString();
            }
        }
        
        private void setLabelTextByCharacter(Char c)
        {
            textBox1.Text += c.ToString();
            isNewCalculation = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(1);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(2);
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(3);
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(4);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(5);
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(6);
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(7);
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(8);
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(9);
        }
        
        private void button0_Click(object sender, EventArgs e)
        {
            setLabelTextByNumber(0);
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            setLabelTextByCharacter('+');
        }
        
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            setLabelTextByCharacter('-');
        }
        
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            setLabelTextByCharacter('/');
        }
        
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            setLabelTextByCharacter('*');
        }
        
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            setLabelTextByCharacter('.');
        }
        
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                if (string.IsNullOrWhiteSpace(expression))
                {
                    textBox1.Text = "Syntax Error";
                    return;
                }
                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");
                textBox1.Text = result.ToString();
                isNewCalculation = true;
            }
            catch (Exception)
            {
                textBox1.Text = "Syntax Error";
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            isNewCalculation = true;
        }
    }
}
