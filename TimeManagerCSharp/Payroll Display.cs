using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
namespace TimeManagerCSharp
{
    public partial class PayrollDisplay : Form
    {
        private DataGridView payrollDGV = new DataGridView();
        public PayrollDisplay(string startDate, string endDate)
        {
            // initialize labels to user requested dates
            InitializeComponent();
            startDateLabel.Text = startDate;
            endDateLabel.Text = endDate;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PayrollDisplay_Load(object sender, EventArgs e)
        {
            //turn start date into variable
            string startDate = startDateLabel.Text;
            string endDate = endDateLabel.Text;
            var selectedStartDateTime = DateTime.Parse(startDate);
            var selectedEndDateTime = DateTime.Parse(endDate);

            // clear and connect to database
            MySqlConnection.ClearAllPools();
            MySqlConnection conn_load = new MySqlConnection("server = localhost; user id = backslash330; password = UrsaMinor; persistsecurityinfo = True; database = timemanager");

            try
            {

                // populate tabs with active employee names from employees table            
                conn_load.Open();
                string sql_load = "SELECT FirstName FROM employees";
                MySqlCommand cmd_load = new MySqlCommand(sql_load, conn_load);
                MySqlDataReader reader_load = cmd_load.ExecuteReader();
                int i = 2;
                var key = "";
                while (reader_load.Read())
                {
                    key = "tabPage" + i.ToString();

                    tabControl1.TabPages.Add(key, reader_load.GetString(0));
                    i++;
                }
                reader_load.Close();


                // loop through employee tabs and populate with tables
                foreach (TabPage tp in tabControl1.TabPages)
                {
                    if(tp.Name == "tabPage1")
                    {
                        continue;
                    }
                    else
                    {
                        // create table view and add columns
                        DataGridView dgvDynamic = new DataGridView();
                        dgvDynamic.Width = 650;
                        dgvDynamic.Height = 210;
                        tp.Controls.Add(dgvDynamic);
                        dgvDynamic.Columns.Add("date", "date");
                        dgvDynamic.Columns.Add("signin", "signin");
                        dgvDynamic.Columns.Add("signout", "signout");


                        //determine the needed number or rows and add them to the table
                        int dynamicRow = 0;
                        for (var day = selectedStartDateTime.Date; day.Date <= selectedEndDateTime.Date; day = day.AddDays(1))
                        {
                            dynamicRow += 1;
                        }
                        dgvDynamic.Rows.Add(dynamicRow);

                        // for each day, find the loggin and logout time and then populate the table
                        dynamicRow = 0;
                        for (var day = selectedStartDateTime.Date; day.Date <= selectedEndDateTime.Date; day = day.AddDays(1))
                        {
                            // set date for each row
                            dgvDynamic.Rows[dynamicRow].Cells[0].Value = day.ToString("ddd MMMM dd, yyyy");
                            //set signin time for each row
                            var SQLTemplateDynamic = "select EmployeeID from employees where firstname = '{0}'";
                            string SQLDynamic = string.Format(SQLTemplateDynamic, tp.Text);
                            var cmdDynamic = new MySqlCommand(SQLDynamic, conn_load);
                            var readerDynamic = cmdDynamic.ExecuteReader();
                            var id = "";
                            while (readerDynamic.Read())
                            {
                                id = readerDynamic.GetString(0);
                            }
                            readerDynamic.Close();

                            //set signin time for each row
                            SQLTemplateDynamic = "SELECT time FROM signin WHERE employeeID ='{0}' and Date = '{1}'";
                            SQLDynamic = string.Format(SQLTemplateDynamic, id, day.ToShortDateString());
                            cmdDynamic = new MySqlCommand(SQLDynamic, conn_load);
                            readerDynamic = cmdDynamic.ExecuteReader();
                            var signinTime = "";
                            while (readerDynamic.Read())
                            {
                                signinTime = readerDynamic.GetString(0);

                            }
                            if (signinTime == "")
                            {
                                signinTime = "no signin time";
                            }
                            readerDynamic.Close();
                            dgvDynamic.Rows[dynamicRow].Cells[1].Value = signinTime;


                            //set signout time for each row
                            SQLTemplateDynamic = "SELECT time FROM signout WHERE employeeID ='{0}' and Date = '{1}'";
                            SQLDynamic = string.Format(SQLTemplateDynamic, id, day.ToShortDateString());
                            cmdDynamic = new MySqlCommand(SQLDynamic, conn_load);
                            readerDynamic = cmdDynamic.ExecuteReader();
                            var signoutTime = "";
                            while (readerDynamic.Read())
                            {
                                signoutTime = readerDynamic.GetString(0);

                            }
                            if (signoutTime == "")
                            {
                                signoutTime = "no signout time";
                            }
                            readerDynamic.Close();
                            dgvDynamic.Rows[dynamicRow].Cells[2].Value = signoutTime;




                            //move to next row in table
                            dynamicRow += 1;
                        }



                    }

                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn_load.Close();
            Console.WriteLine("Done.");

            // add a table to the first tab (totals)
            DataGridView dgv = new DataGridView();
            dgv.Width = 650;
            dgv.Height = 210;
            tabPage1.Controls.Add(dgv);
            
            //populate with appropriate columns
            dgv.Columns.Add("EmployeeID", "EmployeeID");
            dgv.Columns.Add("Name", "Name");
            dgv.Columns.Add("Amount of Hours Worked", "Amount of Hours Worked");
            dgv.Columns.Add("Days Worked", "Days Worked");
            dgv.Columns.Add("Days with Partial Logins", "Days with Partial Logins");
            dgv.Columns.Add("Estimated Breaks", "Estimated Breaks");
            dgv.Columns.Add("Estimated Billable Hours", "Estimated Billable Hours");

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
            TimeSpan billablehours = new TimeSpan();


            //grab employeids
            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
            conn.Open();

            // Add EmployeeIDs to a List
            string SQL = "select EmployeeID from employees;";
            List<string> EmployeeID = new List<string>(20);
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
                dgv.Rows.Add(id);


                // Populate cells with appropriate names
                string SQLTemplate = " Select FirstName from employees where EmployeeID = {0}";
                SQL = string.Format(SQLTemplate, id);
                cmd = new MySqlCommand(SQL, conn);
                reader = cmd.ExecuteReader();
                cell = 1;
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    dgv.Rows[row].Cells[cell].Value = name;
                    row = ++(row);

                }
                reader.Close();

                // set daycount to zero
                daycount = 0;
                partialDaycount = 0;
                totalHoursWorked = TimeSpan.Zero;
                breakTotal = TimeSpan.Zero;
                billablehours = TimeSpan.Zero;

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

                    if (string.IsNullOrEmpty(shiftStartTime)){
                        continue;
                    }
                    else
                    {

                    }
                    reader.Close();

                    // get  revelant signout time from signout and store it
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
                    if (string.IsNullOrEmpty(shiftEndTime))
                    {
                        partialDaycount = ++(partialDaycount);
                        continue;   /// BUG LOCATED HERE?
                    }
                    else
                    {



                        // convert strings to datetime objects and calculate working hours 
                        string shiftStartTimeString = startDate + " " + shiftStartTime;
                        var startDateTime = DateTime.Parse(shiftStartTimeString);
                        string shiftEndTimeString = startDate + " " + shiftEndTime;
                        var endDateTime = DateTime.Parse(shiftEndTimeString);
                        TimeSpan hoursWorkedToday = endDateTime.Subtract(startDateTime);
                        totalHoursWorked = totalHoursWorked.Add(hoursWorkedToday);


                        //increment the daycount timer 00:00:00
                        daycount = ++daycount;

                        // Error between these two lines 


                        // calculate the breaks taken that day
                        if (TimeSpan.Compare(hoursWorkedToday, fourHourTS) <= 0)
                        {

                        }
                        else if (TimeSpan.Compare(hoursWorkedToday, eightHourTS) < 0)
                        {
                            breakTotal = breakTotal.Add(thirtyMinuteBreak);
                        }
                        else if (TimeSpan.Compare(hoursWorkedToday, eightHourTS) >= 0)
                        {
                            breakTotal = breakTotal.Add(oneHourBeak);
                        }
                        else
                        {
                        }

                        // reset time span
                        hoursWorkedToday = TimeSpan.Zero;


                    }

                }
                billablehours = totalHoursWorked.Subtract(breakTotal);
                // write given employees totals to a row and then move to the next row
                dgv.Rows[daycountRow].Cells[2].Value = (int)totalHoursWorked.TotalHours + totalHoursWorked.ToString(@"\:mm\:ss");
                dgv.Rows[daycountRow].Cells[3].Value = daycount.ToString();
                dgv.Rows[daycountRow].Cells[4].Value = partialDaycount.ToString();
                dgv.Rows[daycountRow].Cells[5].Value = breakTotal.TotalHours.ToString();
                dgv.Rows[daycountRow].Cells[6].Value = billablehours.TotalHours.ToString();
                daycountRow = ++(daycountRow);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void adminReturnButton_Click(object sender, EventArgs e)
        {
            // Close PayrollDisplay and open AdminMenu
            AdminMenu f2 = new AdminMenu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void employeeReturnButton_Click(object sender, EventArgs e)
        {
            // Close PayrollDisplay and open AdminMenu
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
      

    }
}
