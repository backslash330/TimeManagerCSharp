using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeManagerCSharp
{
    public partial class PayrollDisplay : Form
    {
        private DataGridView payrollDGV = new DataGridView();
        public PayrollDisplay(string startDate, string endDate)
        {
            InitializeComponent();
            label1.Text = startDate;
            label2.Text = endDate;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PayrollDisplay_Load(object sender, EventArgs e)
        {
            //turn start date into variable
            string startDate = label1.Text;
            string endDate = label2.Text;
            var selectedStartDateTime = DateTime.Parse(startDate);
            var selectedEndDateTime = DateTime.Parse(endDate);
            // System.Windows.Forms.MessageBox.Show(startDate);
            // format 2021-08-25 same as sql

            this.dataGridView1.Columns.Add("EmployeeID", "EmployeeID");
            this.dataGridView1.Columns.Add("Name", "Name");
            this.dataGridView1.Columns.Add("Amount of Hours Worked", "Amount of Hours Worked");
            this.dataGridView1.Columns.Add("Days Worked", "Days Worked");
            this.dataGridView1.Columns.Add("Estiamted Breaks", "Estimated Breaks");
            this.dataGridView1.Columns.Add("Estiamted Billable Hours", "Estimated Billable Hours");

            //grab employeids
            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
            conn.Open();

            string SQL = "select EmployeeID from employees;";
            List<string> EmployeeID = new List<string>(10);
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmployeeID.Add(reader.GetString(0));
            }
            reader.Close();

            foreach (var id in EmployeeID)
            {
                for (var day = selectedStartDateTime.Date; day.Date <= selectedEndDateTime.Date; day = day.AddDays(1))
                {
                    string SQLTemplate = "SELECT time FROM signin WHERE EmployeeID ='{0}' and Date = '{1}'";
                    SQL = string.Format(SQLTemplate, id, startDate);
                    cmd = new MySqlCommand(SQL, conn);
                    reader = cmd.ExecuteReader();
                    string shiftStartTime = "";

                    while (reader.Read())
                    {
                        shiftStartTime = reader.GetString(0);
                    }

                    reader.Close();

                    SQLTemplate = "SELECT time FROM signout WHERE EmployeeID ='{0}' and Date = '{1}'";
                    SQL = string.Format(SQLTemplate, id, startDate);
                    cmd = new MySqlCommand(SQL, conn);
                    reader = cmd.ExecuteReader();
                    string shiftEndTime = "";

                    while (reader.Read())
                    {
                        shiftEndTime = reader.GetString(0);
                    }
                    reader.Close();

                    string shiftStartTimeString = startDate + " " + shiftStartTime;

                    var startDateTime = DateTime.Parse(shiftStartTimeString);

                    string shiftEndTimeString = startDate + " " + shiftEndTime;

                    var endDateTime = DateTime.Parse(shiftEndTimeString);

                    System.TimeSpan difference = endDateTime.Subtract(startDateTime);

                    string hoursWorked = difference.ToString();

                    System.Windows.Forms.MessageBox.Show(shiftStartTimeString);
                    System.Windows.Forms.MessageBox.Show(shiftEndTimeString);
                    System.Windows.Forms.MessageBox.Show(hoursWorked);
                }
            }


            for (var day = selectedStartDateTime.Date; day.Date <= selectedEndDateTime.Date; day = day.AddDays(1))
            {
                System.Windows.Forms.MessageBox.Show(day.ToShortDateString());
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
