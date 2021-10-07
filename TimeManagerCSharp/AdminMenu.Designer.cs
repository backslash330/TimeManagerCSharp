
namespace TimeManagerCSharp
{
    partial class AdminMenu
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
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payrollHoursButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.adjustBreaksButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.thirtyMinRadioButton = new System.Windows.Forms.RadioButton();
            this.oneHourRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(85, 87);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.startDateTimePicker.TabIndex = 2;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(85, 238);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(250, 27);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // payrollHoursButton
            // 
            this.payrollHoursButton.BackColor = System.Drawing.Color.LimeGreen;
            this.payrollHoursButton.Location = new System.Drawing.Point(85, 342);
            this.payrollHoursButton.Name = "payrollHoursButton";
            this.payrollHoursButton.Size = new System.Drawing.Size(250, 71);
            this.payrollHoursButton.TabIndex = 4;
            this.payrollHoursButton.Text = "Get Payroll Hours";
            this.payrollHoursButton.UseVisualStyleBackColor = false;
            this.payrollHoursButton.Click += new System.EventHandler(this.payrollHoursButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(384, 239);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(167, 29);
            this.addEmployeeButton.TabIndex = 6;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addemployeeButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(601, 239);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(167, 29);
            this.removeEmployeeButton.TabIndex = 7;
            this.removeEmployeeButton.Text = "Remove Employee";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // adjustBreaksButton
            // 
            this.adjustBreaksButton.Location = new System.Drawing.Point(478, 288);
            this.adjustBreaksButton.Name = "adjustBreaksButton";
            this.adjustBreaksButton.Size = new System.Drawing.Size(192, 29);
            this.adjustBreaksButton.TabIndex = 8;
            this.adjustBreaksButton.Text = "Adjust Employee Breaks";
            this.adjustBreaksButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Red;
            this.returnButton.Location = new System.Drawing.Point(457, 342);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(235, 71);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return to Employee Area";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(147, 41);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(124, 20);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "Payroll Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(147, 159);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(118, 20);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "Payroll End Date";
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(551, 41);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(61, 20);
            this.optionsLabel.TabIndex = 12;
            this.optionsLabel.Text = "Options";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(427, 92);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 20);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(642, 92);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(79, 20);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(384, 115);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(167, 27);
            this.firstNameTextBox.TabIndex = 15;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(600, 115);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(167, 27);
            this.lastNameTextBox.TabIndex = 16;
            // 
            // thirtyMinRadioButton
            // 
            this.thirtyMinRadioButton.AutoSize = true;
            this.thirtyMinRadioButton.Location = new System.Drawing.Point(384, 177);
            this.thirtyMinRadioButton.Name = "thirtyMinRadioButton";
            this.thirtyMinRadioButton.Size = new System.Drawing.Size(189, 24);
            this.thirtyMinRadioButton.TabIndex = 17;
            this.thirtyMinRadioButton.Text = "30 Minute Unpaid Break";
            this.thirtyMinRadioButton.UseVisualStyleBackColor = true;
            // 
            // oneHourRadioButton
            // 
            this.oneHourRadioButton.AutoSize = true;
            this.oneHourRadioButton.Location = new System.Drawing.Point(599, 177);
            this.oneHourRadioButton.Name = "oneHourRadioButton";
            this.oneHourRadioButton.Size = new System.Drawing.Size(168, 24);
            this.oneHourRadioButton.TabIndex = 18;
            this.oneHourRadioButton.Text = "1 Hour Unpaid Break";
            this.oneHourRadioButton.UseVisualStyleBackColor = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.oneHourRadioButton);
            this.Controls.Add(this.thirtyMinRadioButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.adjustBreaksButton);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.payrollHoursButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Name = "AdminMenu";
            this.Text = "Time Manager - Admin Area";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button payrollHoursButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.Button adjustBreaksButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.RadioButton thirtyMinRadioButton;
        private System.Windows.Forms.RadioButton oneHourRadioButton;
    }
}