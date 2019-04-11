namespace Program2
{
    partial class program2Form
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
            this.creditHoursLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.creditHoursTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.checkRegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creditHoursLabel
            // 
            this.creditHoursLabel.AutoSize = true;
            this.creditHoursLabel.Location = new System.Drawing.Point(12, 28);
            this.creditHoursLabel.Name = "creditHoursLabel";
            this.creditHoursLabel.Size = new System.Drawing.Size(226, 13);
            this.creditHoursLabel.TabIndex = 0;
            this.creditHoursLabel.Text = "Enter credit hours completed prior to Fall 2016:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(98, 55);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(140, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Enter first letter of last name:";
            // 
            // creditHoursTextBox
            // 
            this.creditHoursTextBox.Location = new System.Drawing.Point(244, 25);
            this.creditHoursTextBox.Name = "creditHoursTextBox";
            this.creditHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.creditHoursTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(244, 52);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // checkRegistrationButton
            // 
            this.checkRegistrationButton.Location = new System.Drawing.Point(107, 101);
            this.checkRegistrationButton.Name = "checkRegistrationButton";
            this.checkRegistrationButton.Size = new System.Drawing.Size(131, 23);
            this.checkRegistrationButton.TabIndex = 4;
            this.checkRegistrationButton.Text = "Check Registration Date";
            this.checkRegistrationButton.UseVisualStyleBackColor = true;
            this.checkRegistrationButton.Click += new System.EventHandler(this.checkRegistrationButton_Click);
            // 
            // program2Form
            // 
            this.AcceptButton = this.checkRegistrationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 163);
            this.Controls.Add(this.checkRegistrationButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.creditHoursTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.creditHoursLabel);
            this.Name = "program2Form";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditHoursLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox creditHoursTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button checkRegistrationButton;
    }
}

