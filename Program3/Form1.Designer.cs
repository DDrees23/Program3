
namespace Program3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loanTextBox = new System.Windows.Forms.TextBox();
            this.CreditTextBox = new System.Windows.Forms.TextBox();
            this.loanComboBox = new System.Windows.Forms.ComboBox();
            this.interestButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loanOutputLabel = new System.Windows.Forms.Label();
            this.creditOutputLabel = new System.Windows.Forms.Label();
            this.paymentOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Credit Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loan Amount:";
            // 
            // loanTextBox
            // 
            this.loanTextBox.Location = new System.Drawing.Point(152, 119);
            this.loanTextBox.Name = "loanTextBox";
            this.loanTextBox.Size = new System.Drawing.Size(121, 20);
            this.loanTextBox.TabIndex = 3;
            // 
            // CreditTextBox
            // 
            this.CreditTextBox.Location = new System.Drawing.Point(152, 86);
            this.CreditTextBox.Name = "CreditTextBox";
            this.CreditTextBox.Size = new System.Drawing.Size(121, 20);
            this.CreditTextBox.TabIndex = 4;
            // 
            // loanComboBox
            // 
            this.loanComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.loanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loanComboBox.FormattingEnabled = true;
            this.loanComboBox.Items.AddRange(new object[] {
            "Home",
            "Auto",
            "Unsecured"});
            this.loanComboBox.Location = new System.Drawing.Point(152, 52);
            this.loanComboBox.Name = "loanComboBox";
            this.loanComboBox.Size = new System.Drawing.Size(121, 21);
            this.loanComboBox.TabIndex = 5;
            // 
            // interestButton
            // 
            this.interestButton.Location = new System.Drawing.Point(103, 168);
            this.interestButton.Name = "interestButton";
            this.interestButton.Size = new System.Drawing.Size(105, 36);
            this.interestButton.TabIndex = 6;
            this.interestButton.Text = "Calculate Interest";
            this.interestButton.UseVisualStyleBackColor = true;
            this.interestButton.Click += new System.EventHandler(this.interestButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loan Interest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Credit Rating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Down Payment";
            // 
            // loanOutputLabel
            // 
            this.loanOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loanOutputLabel.Location = new System.Drawing.Point(173, 220);
            this.loanOutputLabel.Name = "loanOutputLabel";
            this.loanOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.loanOutputLabel.TabIndex = 10;
            // 
            // creditOutputLabel
            // 
            this.creditOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditOutputLabel.Location = new System.Drawing.Point(173, 256);
            this.creditOutputLabel.Name = "creditOutputLabel";
            this.creditOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.creditOutputLabel.TabIndex = 11;
            // 
            // paymentOutputLabel
            // 
            this.paymentOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentOutputLabel.Location = new System.Drawing.Point(173, 289);
            this.paymentOutputLabel.Name = "paymentOutputLabel";
            this.paymentOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.paymentOutputLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 336);
            this.Controls.Add(this.paymentOutputLabel);
            this.Controls.Add(this.creditOutputLabel);
            this.Controls.Add(this.loanOutputLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.interestButton);
            this.Controls.Add(this.loanComboBox);
            this.Controls.Add(this.CreditTextBox);
            this.Controls.Add(this.loanTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Loan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loanTextBox;
        private System.Windows.Forms.TextBox CreditTextBox;
        private System.Windows.Forms.ComboBox loanComboBox;
        private System.Windows.Forms.Button interestButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label loanOutputLabel;
        private System.Windows.Forms.Label creditOutputLabel;
        private System.Windows.Forms.Label paymentOutputLabel;
    }
}

