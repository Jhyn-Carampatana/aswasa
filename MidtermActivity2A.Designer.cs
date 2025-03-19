namespace MidterActivity2A
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.TextBox txtRuleNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRuleDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;

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
            lblTitle = new Label();
            lblInstruction = new Label();
            txtRuleNumber = new TextBox();
            btnSearch = new Button();
            txtRuleDisplay = new TextBox();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(33, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Laboratory Rules and Regulations";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.BackColor = SystemColors.GrayText;
            lblInstruction.Font = new Font("Arial", 12F);
            lblInstruction.ForeColor = SystemColors.ButtonFace;
            lblInstruction.Location = new Point(12, 67);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(200, 25);
            lblInstruction.TabIndex = 1;
            lblInstruction.Text = "Enter a rule number (1-12):";
            // 
            // txtRuleNumber
            // 
            txtRuleNumber.BackColor = Color.LightGray;
            txtRuleNumber.Font = new Font("Arial", 12F);
            txtRuleNumber.ForeColor = Color.Black;
            txtRuleNumber.Location = new Point(229, 67);
            txtRuleNumber.MaxLength = 2;
            txtRuleNumber.Name = "txtRuleNumber";
            txtRuleNumber.Size = new Size(146, 26);
            txtRuleNumber.TabIndex = 2;
            txtRuleNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(402, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Display Rule";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtRuleDisplay
            // 
            txtRuleDisplay.BackColor = SystemColors.AppWorkspace;
            txtRuleDisplay.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRuleDisplay.ForeColor = SystemColors.InfoText;
            txtRuleDisplay.Location = new Point(46, 111);
            txtRuleDisplay.Multiline = true;
            txtRuleDisplay.Name = "txtRuleDisplay";
            txtRuleDisplay.ReadOnly = true;
            txtRuleDisplay.ScrollBars = ScrollBars.Vertical;
            txtRuleDisplay.Size = new Size(449, 102);
            txtRuleDisplay.TabIndex = 4;
            txtRuleDisplay.TextChanged += txtRuleDisplay_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(137, 233);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(324, 233);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(558, 365);
            Controls.Add(lblTitle);
            Controls.Add(lblInstruction);
            Controls.Add(txtRuleNumber);
            Controls.Add(btnSearch);
            Controls.Add(txtRuleDisplay);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Laboratory Rules and Regulations";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }

    #endregion
}
