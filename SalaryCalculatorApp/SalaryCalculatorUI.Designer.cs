namespace SalaryCalculatorApp
{
    partial class SalaryCalculatorUI
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.basicSalaryTextBox = new System.Windows.Forms.TextBox();
            this.houseRantTextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowTextBox = new System.Windows.Forms.TextBox();
            this.showSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emlpoyee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Basic Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "% of basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "% of basic";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(148, 36);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // basicSalaryTextBox
            // 
            this.basicSalaryTextBox.Location = new System.Drawing.Point(148, 65);
            this.basicSalaryTextBox.Name = "basicSalaryTextBox";
            this.basicSalaryTextBox.Size = new System.Drawing.Size(135, 20);
            this.basicSalaryTextBox.TabIndex = 1;
            // 
            // houseRantTextBox
            // 
            this.houseRantTextBox.Location = new System.Drawing.Point(148, 90);
            this.houseRantTextBox.Name = "houseRantTextBox";
            this.houseRantTextBox.Size = new System.Drawing.Size(135, 20);
            this.houseRantTextBox.TabIndex = 1;
            // 
            // medicalAllowTextBox
            // 
            this.medicalAllowTextBox.Location = new System.Drawing.Point(148, 121);
            this.medicalAllowTextBox.Name = "medicalAllowTextBox";
            this.medicalAllowTextBox.Size = new System.Drawing.Size(135, 20);
            this.medicalAllowTextBox.TabIndex = 1;
            // 
            // showSalaryButton
            // 
            this.showSalaryButton.Location = new System.Drawing.Point(148, 152);
            this.showSalaryButton.Name = "showSalaryButton";
            this.showSalaryButton.Size = new System.Drawing.Size(156, 27);
            this.showSalaryButton.TabIndex = 2;
            this.showSalaryButton.Text = "Show Me Salary";
            this.showSalaryButton.UseVisualStyleBackColor = true;
            this.showSalaryButton.Click += new System.EventHandler(this.showSalaryButton_Click);
            // 
            // SalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 238);
            this.Controls.Add(this.showSalaryButton);
            this.Controls.Add(this.medicalAllowTextBox);
            this.Controls.Add(this.houseRantTextBox);
            this.Controls.Add(this.basicSalaryTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorUI";
            this.Text = "SalaryCalculatorUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox basicSalaryTextBox;
        private System.Windows.Forms.TextBox houseRantTextBox;
        private System.Windows.Forms.TextBox medicalAllowTextBox;
        private System.Windows.Forms.Button showSalaryButton;
    }
}

