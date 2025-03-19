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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void setLabelTextByNumber(Int32 number)
        {
            textBox1.Text += number.ToString();
        }

        private void setLabelTextByCharacter(Char c)
        {
            textBox1.Text += c.ToString();
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
        }
    }
}
