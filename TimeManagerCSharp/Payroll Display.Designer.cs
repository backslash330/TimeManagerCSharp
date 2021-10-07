
namespace TimeManagerCSharp
{
    partial class PayrollDisplay
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminReturnButton = new System.Windows.Forms.Button();
            this.employeeReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(726, 305);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(177, 22);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(50, 20);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "label1";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(483, 22);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(50, 20);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "to";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // adminReturnButton
            // 
            this.adminReturnButton.Location = new System.Drawing.Point(186, 395);
            this.adminReturnButton.Name = "adminReturnButton";
            this.adminReturnButton.Size = new System.Drawing.Size(169, 29);
            this.adminReturnButton.TabIndex = 4;
            this.adminReturnButton.Text = "Return to Admin Area";
            this.adminReturnButton.UseVisualStyleBackColor = true;
            this.adminReturnButton.Click += new System.EventHandler(this.adminReturnButton_Click);
            // 
            // employeeReturnButton
            // 
            this.employeeReturnButton.Location = new System.Drawing.Point(418, 395);
            this.employeeReturnButton.Name = "employeeReturnButton";
            this.employeeReturnButton.Size = new System.Drawing.Size(169, 29);
            this.employeeReturnButton.TabIndex = 5;
            this.employeeReturnButton.Text = "Return to Employee Area";
            this.employeeReturnButton.UseVisualStyleBackColor = true;
            this.employeeReturnButton.Click += new System.EventHandler(this.employeeReturnButton_Click);
            // 
            // PayrollDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeReturnButton);
            this.Controls.Add(this.adminReturnButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PayrollDisplay";
            this.Text = "Payroll Display";
            this.Load += new System.EventHandler(this.PayrollDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button adminReturnButton;
        private System.Windows.Forms.Button employeeReturnButton;
    }
}