
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.daysButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDateTimePicker.Location = new System.Drawing.Point(75, 77);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.startDateTimePicker.TabIndex = 2;
            this.startDateTimePicker.ValueChanged += new System.EventHandler(this.startDateTimePicker_ValueChanged);
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(75, 151);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(219, 23);
            this.endDateTimePicker.TabIndex = 3;
            // 
            // payrollHoursButton
            // 
            this.payrollHoursButton.BackColor = System.Drawing.Color.LimeGreen;
            this.payrollHoursButton.Location = new System.Drawing.Point(75, 250);
            this.payrollHoursButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payrollHoursButton.Name = "payrollHoursButton";
            this.payrollHoursButton.Size = new System.Drawing.Size(219, 53);
            this.payrollHoursButton.TabIndex = 4;
            this.payrollHoursButton.Text = "Get Payroll Hours";
            this.payrollHoursButton.UseVisualStyleBackColor = false;
            this.payrollHoursButton.Click += new System.EventHandler(this.payrollHoursButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(338, 151);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(146, 22);
            this.addEmployeeButton.TabIndex = 6;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addemployeeButton_Click);
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(526, 153);
            this.removeEmployeeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(146, 22);
            this.removeEmployeeButton.TabIndex = 7;
            this.removeEmployeeButton.Text = "Remove Employee";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.removeEmployeeButton_Click);
            // 
            // adjustBreaksButton
            // 
            this.adjustBreaksButton.Location = new System.Drawing.Point(416, 200);
            this.adjustBreaksButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adjustBreaksButton.Name = "adjustBreaksButton";
            this.adjustBreaksButton.Size = new System.Drawing.Size(168, 22);
            this.adjustBreaksButton.TabIndex = 8;
            this.adjustBreaksButton.Text = "Adjust Employee Breaks";
            this.adjustBreaksButton.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Red;
            this.returnButton.Location = new System.Drawing.Point(402, 250);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(206, 53);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Return to Employee Area";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(134, 60);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(97, 15);
            this.startDateLabel.TabIndex = 10;
            this.startDateLabel.Text = "Payroll Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(134, 120);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(93, 15);
            this.endDateLabel.TabIndex = 11;
            this.endDateLabel.Text = "Payroll End Date";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(375, 63);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 13;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Click += new System.EventHandler(this.firstNameLabel_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(563, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(337, 80);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(147, 23);
            this.firstNameTextBox.TabIndex = 15;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(526, 80);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(147, 23);
            this.lastNameTextBox.TabIndex = 16;
            // 
            // daysButton
            // 
            this.daysButton.Location = new System.Drawing.Point(119, 200);
            this.daysButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.daysButton.Name = "daysButton";
            this.daysButton.Size = new System.Drawing.Size(137, 22);
            this.daysButton.TabIndex = 19;
            this.daysButton.Text = "See Missed Days";
            this.daysButton.UseVisualStyleBackColor = true;
            this.daysButton.Click += new System.EventHandler(this.daysButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Run Payroll";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add/Remove Employee";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daysButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.adjustBreaksButton);
            this.Controls.Add(this.removeEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.payrollHoursButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button daysButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}