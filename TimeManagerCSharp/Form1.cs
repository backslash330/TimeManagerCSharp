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

            // load columns in dataGrid
            this.dataGridView1.Columns.Add("EmployeeID", "EmployeeID");
            this.dataGridView1.Columns.Add("Name", "Name");
            this.dataGridView1.Columns.Add("Amount of Hours Worked", "Amount of Hours Worked");
            this.dataGridView1.Columns.Add("Days Worked", "Days Worked");
            this.dataGridView1.Columns.Add("Days with Partial Logins", "Days with Partial Logins");
            this.dataGridView1.Columns.Add("Estimated Breaks", "Estimated Breaks");
            this.dataGridView1.Columns.Add("Estimated Billable Hours", "Estimated Billable Hours");

            // Initalize Variables
            int daycount = 0;
            int partialDaycount = 0;
            int row = 0;
            int cell = 0;
            int daycountRow = 0;
            string shiftStartTime = "";
            string shiftEndTime = "";
            TimeSpan totalHoursWorked = new TimeSpan();
            TimeSpan fourHourTS = new TimeSpan(4, 0, 0);
            TimeSpan eightHourTS = new TimeSpan(8, 0, 0);
            TimeSpan breakTotal = new TimeSpan();
            TimeSpan thirtyMinuteBreak = new TimeSpan(0, 3, 0);
            TimeSpan oneHourBeak = new TimeSpan(1, 0, 0);
            TimeSpan billabeHours = new TimeSpan();
            

            //grab employeids
            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
            conn.Open();

            // Add EmployeeIDs to a List
            string SQL = "select EmployeeID from employees;";
            List<string> EmployeeID = new List<string>(10);
            MySqlCommand cmd = new MySqlCommand(SQL, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EmployeeID.Add(reader.GetString(0));
            }
            reader.Close();

            // Loop through IDs In EmployeeID List
            foreach (var id in EmployeeID)
            {
                // Ensure reader is closed
                reader.Close();


                // Populate dataGrid with appropriate rows
                this.dataGridView1.Rows.Add(id);


                // Populate cells with appropriate names
                string SQLTemplate = " Select FirstName from employees where EmployeeID = {0}";
                SQL = string.Format(SQLTemplate, id);
                cmd = new MySqlCommand(SQL, conn);
                reader = cmd.ExecuteReader();
                cell = 1;
                while (reader.Read())
                {
                        string name = reader.GetString(0);
                        this.dataGridView1.Rows[row].Cells[cell].Value = name;
                        row = ++(row);

                }
                reader.Close();

                // set daycount to zero
                daycount = 0;
                partialDaycount = 0;
                totalHoursWorked = TimeSpan.Zero;
                breakTotal = TimeSpan.Zero;
                billabeHours = TimeSpan.Zero;

                // Loop through each selected day
                for (var day = selectedStartDateTime.Date; day.Date <= selectedEndDateTime.Date; day = day.AddDays(1))
                {
                    // Check in employee logged in on given day
                    reader.Close();
                    SQLTemplate = "SELECT time FROM signin WHERE EmployeeID ='{0}' and Date = '{1}'";
                    SQL = string.Format(SQLTemplate, id, day.ToShortDateString());
                    cmd = new MySqlCommand(SQL, conn);
                    reader = cmd.ExecuteReader();
                    shiftStartTime = "";


                    // else, continue to see if the employee logged out on the given day
                    while (reader.Read())
                    {
                            shiftStartTime = reader.GetString(0);
                    }

                    reader.Close();
                    SQLTemplate = "SELECT time FROM signout WHERE EmployeeID ='{0}' and Date = '{1}'";
                    SQL = string.Format(SQLTemplate, id, day.ToShortDateString());
                    cmd = new MySqlCommand(SQL, conn);
                    reader = cmd.ExecuteReader();
                    shiftEndTime = "";
  
                    // else, contine to calcuate the employees working hours
                    while (reader.Read())
                    {
                        shiftEndTime = reader.GetString(0);
                    }
                    reader.Close();

                    // check if the login/logout was incomplete or the employee did not work that day
                    if (string.IsNullOrEmpty(shiftStartTime) || string.IsNullOrEmpty(shiftEndTime))
                    {
                        if (string.IsNullOrEmpty(shiftStartTime) && string.IsNullOrEmpty(shiftEndTime))
                        {
                            continue;
                        }
                        else
                        {
                            partialDaycount = ++(partialDaycount);
                            continue;
                        }
                    }

                    // convert strings to datetime objects and calculate working hours 
                    string shiftStartTimeString = startDate + " " + shiftStartTime;
                    var startDateTime = DateTime.Parse(shiftStartTimeString);
                    string shiftEndTimeString = startDate + " " + shiftEndTime;
                    var endDateTime = DateTime.Parse(shiftEndTimeString);
                    TimeSpan hoursWorkedToday = endDateTime.Subtract(startDateTime);
                    totalHoursWorked = totalHoursWorked.Add(hoursWorkedToday);


                    //increment the daycount timer 00:00:00
                    daycount = ++daycount;
                    string daycountString1 = daycount.ToString();

                    // Error between these two lines 
                    MessageBox.Show(hoursWorkedToday.ToString());
                    MessageBox.Show(totalHoursWorked.ToString());


                    if (TimeSpan.Compare(hoursWorkedToday, fourHourTS) <= 0)
                    {
                        continue;
                    }
                    else if (TimeSpan.Compare(hoursWorkedToday, eightHourTS) <= 0)
                    {
                        breakTotal = breakTotal.Add(thirtyMinuteBreak);
                    }
                    else if (TimeSpan.Compare(hoursWorkedToday, eightHourTS) < 0)
                    {
                        breakTotal = breakTotal.Add(oneHourBeak);
                    }
                    else
                    {
                        MessageBox.Show("lunchbreak calculation Error");
                    }

                    billabeHours = hoursWorkedToday.Subtract(breakTotal);

                    hoursWorkedToday = TimeSpan.Zero;
                }



                this.dataGridView1.Rows[daycountRow].Cells[2].Value = totalHoursWorked.ToString();
                this.dataGridView1.Rows[daycountRow].Cells[3].Value = daycount.ToString();
                this.dataGridView1.Rows[daycountRow].Cells[4].Value = partialDaycount.ToString();
                this.dataGridView1.Rows[daycountRow].Cells[5].Value = breakTotal.ToString();
                this.dataGridView1.Rows[daycountRow].Cells[6].Value = billabeHours.ToString();
                daycountRow = ++(daycountRow);
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu f2 = new AdminMenu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
