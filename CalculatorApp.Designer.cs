namespace CalculatorApp
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            displayTextBox = new TextBox();
            expressionLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonDecimal = new Button();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            buttonSign = new Button();
            buttonEquals = new Button();
            buttonClear = new Button();
            buttonBackspace = new Button();
            textBox1 = new TextBox();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // displayTextBox
            // 
            displayTextBox.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayTextBox.Location = new Point(52, 16);
            displayTextBox.Margin = new Padding(4, 3, 4, 3);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.Size = new Size(293, 38);
            displayTextBox.TabIndex = 0;
            displayTextBox.Text = "0";
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // expressionLabel
            // 
            expressionLabel.AutoSize = true;
            expressionLabel.Location = new Point(14, 16);
            expressionLabel.Margin = new Padding(4, 0, 4, 0);
            expressionLabel.Name = "expressionLabel";
            expressionLabel.Size = new Size(0, 15);
            expressionLabel.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(15, 222);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(70, 60);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += NumberButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(92, 222);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(70, 60);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += NumberButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Blue;
            button3.Location = new Point(169, 222);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(70, 60);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += NumberButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Blue;
            button4.Location = new Point(14, 141);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(70, 58);
            button4.TabIndex = 2;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += NumberButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Blue;
            button5.Location = new Point(91, 141);
            button5.Margin = new Padding(4, 3, 4, 3);
            button5.Name = "button5";
            button5.Size = new Size(70, 58);
            button5.TabIndex = 2;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += NumberButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.Blue;
            button6.Location = new Point(168, 141);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(70, 58);
            button6.TabIndex = 2;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += NumberButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.Blue;
            button9.Location = new Point(168, 60);
            button9.Margin = new Padding(4, 3, 4, 3);
            button9.Name = "button9";
            button9.Size = new Size(70, 58);
            button9.TabIndex = 2;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += NumberButton_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button0.ForeColor = Color.Blue;
            button0.Location = new Point(90, 306);
            button0.Margin = new Padding(4, 3, 4, 3);
            button0.Name = "button0";
            button0.Size = new Size(70, 58);
            button0.TabIndex = 2;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += NumberButton_Click;
            // 
            // buttonDecimal
            // 
            buttonDecimal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDecimal.Location = new Point(168, 306);
            buttonDecimal.Margin = new Padding(4, 3, 4, 3);
            buttonDecimal.Name = "buttonDecimal";
            buttonDecimal.Size = new Size(70, 58);
            buttonDecimal.TabIndex = 2;
            buttonDecimal.Text = ".";
            buttonDecimal.UseVisualStyleBackColor = true;
            buttonDecimal.Click += DecimalButton_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(245, 306);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(70, 58);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += OperatorButton_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubtract.Location = new Point(245, 220);
            buttonSubtract.Margin = new Padding(4, 3, 4, 3);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(70, 60);
            buttonSubtract.TabIndex = 2;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += OperatorButton_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMultiply.Location = new Point(245, 141);
            buttonMultiply.Margin = new Padding(4, 3, 4, 3);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(70, 58);
            buttonMultiply.TabIndex = 2;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += OperatorButton_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDivide.Location = new Point(245, 60);
            buttonDivide.Margin = new Padding(4, 3, 4, 3);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(70, 58);
            buttonDivide.TabIndex = 2;
            buttonDivide.Text = "/";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += OperatorButton_Click;
            // 
            // buttonSign
            // 
            buttonSign.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSign.Location = new Point(323, 61);
            buttonSign.Margin = new Padding(4, 3, 4, 3);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(70, 58);
            buttonSign.TabIndex = 2;
            buttonSign.Text = "+/-";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += SignButton_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = Color.RoyalBlue;
            buttonEquals.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEquals.ForeColor = Color.White;
            buttonEquals.Location = new Point(323, 222);
            buttonEquals.Margin = new Padding(4, 3, 4, 3);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(70, 137);
            buttonEquals.TabIndex = 2;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            buttonEquals.Click += EqualsButton_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Red;
            buttonClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(13, 306);
            buttonClear.Margin = new Padding(4, 3, 4, 3);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(70, 58);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += ClearButton_Click;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBackspace.Location = new Point(323, 141);
            buttonBackspace.Margin = new Padding(4, 3, 4, 3);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(70, 58);
            buttonBackspace.TabIndex = 2;
            buttonBackspace.Text = "←";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += BackspaceButton_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(52, 16);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(293, 38);
            textBox1.TabIndex = 0;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = Color.Blue;
            button10.Location = new Point(15, 60);
            button10.Margin = new Padding(4, 3, 4, 3);
            button10.Name = "button10";
            button10.Size = new Size(70, 58);
            button10.TabIndex = 2;
            button10.Text = "7";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NumberButton_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = Color.Blue;
            button11.Location = new Point(91, 60);
            button11.Margin = new Padding(4, 3, 4, 3);
            button11.Name = "button11";
            button11.Size = new Size(70, 58);
            button11.TabIndex = 2;
            button11.Text = "8";
            button11.UseVisualStyleBackColor = true;
            button11.Click += NumberButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 376);
            Controls.Add(buttonBackspace);
            Controls.Add(buttonEquals);
            Controls.Add(buttonSign);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDecimal);
            Controls.Add(buttonClear);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(expressionLabel);
            Controls.Add(textBox1);
            Controls.Add(displayTextBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CalculatorForm";
            Text = "Calculator";
            Load += CalculatorForm_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Label expressionLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBackspace;
        private TextBox textBox1;
        private Button button10;
        private Button button11;
    }
}
