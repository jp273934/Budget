namespace ParrisBudget
{
    partial class FormNewBudget
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MortgageTextBox = new System.Windows.Forms.TextBox();
            this.RentExpenseTextBox = new System.Windows.Forms.TextBox();
            this.RentIncomeTextBox = new System.Windows.Forms.TextBox();
            this.JeremysIncomeTextBox = new System.Windows.Forms.TextBox();
            this.AndreasIncomeTextBox = new System.Windows.Forms.TextBox();
            this.Mortgage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.ExpenseTotalLabel = new System.Windows.Forms.Label();
            this.IncomeTotalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MortgageTextBox);
            this.groupBox1.Controls.Add(this.RentExpenseTextBox);
            this.groupBox1.Controls.Add(this.RentIncomeTextBox);
            this.groupBox1.Controls.Add(this.JeremysIncomeTextBox);
            this.groupBox1.Controls.Add(this.AndreasIncomeTextBox);
            this.groupBox1.Controls.Add(this.Mortgage);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Budget";
            // 
            // MortgageTextBox
            // 
            this.MortgageTextBox.Location = new System.Drawing.Point(99, 108);
            this.MortgageTextBox.Name = "MortgageTextBox";
            this.MortgageTextBox.Size = new System.Drawing.Size(100, 20);
            this.MortgageTextBox.TabIndex = 9;
            this.MortgageTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RentExpenseTextBox
            // 
            this.RentExpenseTextBox.Location = new System.Drawing.Point(99, 85);
            this.RentExpenseTextBox.Name = "RentExpenseTextBox";
            this.RentExpenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentExpenseTextBox.TabIndex = 8;
            this.RentExpenseTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RentIncomeTextBox
            // 
            this.RentIncomeTextBox.Location = new System.Drawing.Point(99, 63);
            this.RentIncomeTextBox.Name = "RentIncomeTextBox";
            this.RentIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.RentIncomeTextBox.TabIndex = 7;
            this.RentIncomeTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // JeremysIncomeTextBox
            // 
            this.JeremysIncomeTextBox.Location = new System.Drawing.Point(99, 41);
            this.JeremysIncomeTextBox.Name = "JeremysIncomeTextBox";
            this.JeremysIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.JeremysIncomeTextBox.TabIndex = 6;
            this.JeremysIncomeTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // AndreasIncomeTextBox
            // 
            this.AndreasIncomeTextBox.Location = new System.Drawing.Point(99, 17);
            this.AndreasIncomeTextBox.Name = "AndreasIncomeTextBox";
            this.AndreasIncomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AndreasIncomeTextBox.TabIndex = 5;
            this.AndreasIncomeTextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // Mortgage
            // 
            this.Mortgage.AutoSize = true;
            this.Mortgage.Location = new System.Drawing.Point(40, 111);
            this.Mortgage.Name = "Mortgage";
            this.Mortgage.Size = new System.Drawing.Size(52, 13);
            this.Mortgage.TabIndex = 4;
            this.Mortgage.Text = "Mortgage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rent Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rent Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jeremy\'s Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Andrea\'s Income";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(260, 170);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(117, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(402, 170);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(117, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BalanceLabel);
            this.groupBox2.Controls.Add(this.ExpenseTotalLabel);
            this.groupBox2.Controls.Add(this.IncomeTotalLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(260, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totals";
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Location = new System.Drawing.Point(95, 63);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(13, 13);
            this.BalanceLabel.TabIndex = 5;
            this.BalanceLabel.Text = "0";
            // 
            // ExpenseTotalLabel
            // 
            this.ExpenseTotalLabel.AutoSize = true;
            this.ExpenseTotalLabel.Location = new System.Drawing.Point(95, 41);
            this.ExpenseTotalLabel.Name = "ExpenseTotalLabel";
            this.ExpenseTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.ExpenseTotalLabel.TabIndex = 4;
            this.ExpenseTotalLabel.Text = "0";
            // 
            // IncomeTotalLabel
            // 
            this.IncomeTotalLabel.AutoSize = true;
            this.IncomeTotalLabel.Location = new System.Drawing.Point(95, 19);
            this.IncomeTotalLabel.Name = "IncomeTotalLabel";
            this.IncomeTotalLabel.Size = new System.Drawing.Size(13, 13);
            this.IncomeTotalLabel.TabIndex = 3;
            this.IncomeTotalLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Balance  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Expense Total  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Income Total  ";
            // 
            // FormNewBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 210);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNewBudget";
            this.Text = "New Budget";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Mortgage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MortgageTextBox;
        private System.Windows.Forms.TextBox RentExpenseTextBox;
        private System.Windows.Forms.TextBox RentIncomeTextBox;
        private System.Windows.Forms.TextBox JeremysIncomeTextBox;
        private System.Windows.Forms.TextBox AndreasIncomeTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label ExpenseTotalLabel;
        private System.Windows.Forms.Label IncomeTotalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}