
namespace TimeManagerCSharp
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.signOutButton = new System.Windows.Forms.Button();
            this.requestButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.employeeWrittenInput = new System.Windows.Forms.TextBox();
            this.employeeInstructLabel = new System.Windows.Forms.Label();
            this.adminDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 20;
            this.employeeListBox.Location = new System.Drawing.Point(48, 62);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(266, 244);
            this.employeeListBox.TabIndex = 0;
            this.employeeListBox.SelectedIndexChanged += new System.EventHandler(this.employeeListBox_SelectedIndexChanged);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.Control;
            this.signInButton.Location = new System.Drawing.Point(49, 365);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(94, 29);
            this.signInButton.TabIndex = 1;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signOutButton
            // 
            this.signOutButton.Location = new System.Drawing.Point(221, 364);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(94, 29);
            this.signOutButton.TabIndex = 2;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(48, 412);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(267, 29);
            this.requestButton.TabIndex = 3;
            this.requestButton.Text = "Request Time Adjustment";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(507, 412);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(149, 29);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "Admin Area";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(459, 364);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(246, 27);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.Text = "Enter Admin Password Here";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(417, 33);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(351, 285);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // employeeWrittenInput
            // 
            this.employeeWrittenInput.Location = new System.Drawing.Point(50, 312);
            this.employeeWrittenInput.Name = "employeeWrittenInput";
            this.employeeWrittenInput.Size = new System.Drawing.Size(265, 27);
            this.employeeWrittenInput.TabIndex = 8;
            this.employeeWrittenInput.Text = "type your name here";
            this.employeeWrittenInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeInstructLabel
            // 
            this.employeeInstructLabel.AutoSize = true;
            this.employeeInstructLabel.Location = new System.Drawing.Point(50, 33);
            this.employeeInstructLabel.Name = "employeeInstructLabel";
            this.employeeInstructLabel.Size = new System.Drawing.Size(258, 20);
            this.employeeInstructLabel.TabIndex = 9;
            this.employeeInstructLabel.Text = "Click your name  and type your name ";
            this.employeeInstructLabel.Click += new System.EventHandler(this.employeeInstructLabel_Click);
            // 
            // adminDescriptionLabel
            // 
            this.adminDescriptionLabel.AutoSize = true;
            this.adminDescriptionLabel.Location = new System.Drawing.Point(493, 331);
            this.adminDescriptionLabel.Name = "adminDescriptionLabel";
            this.adminDescriptionLabel.Size = new System.Drawing.Size(192, 20);
            this.adminDescriptionLabel.TabIndex = 10;
            this.adminDescriptionLabel.Text = "Enter Admin Password Here";
            this.adminDescriptionLabel.Click += new System.EventHandler(this.adminDescriptionLabel_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 469);
            this.Controls.Add(this.adminDescriptionLabel);
            this.Controls.Add(this.employeeInstructLabel);
            this.Controls.Add(this.employeeWrittenInput);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.employeeListBox);
            this.Name = "MainMenu";
            this.Text = "Time Manager - Employee Area";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox employeeWrittenInput;
        private System.Windows.Forms.Label employeeInstructLabel;
        private System.Windows.Forms.Label adminDescriptionLabel;
    }
}

