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
    public partial class MissedMenu : Form
    {
        public MissedMenu(string startDate, string endDate)
        {
            InitializeComponent();
            label1.Text = startDate;
            label2.Text = endDate;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close PayrollDisplay and open AdminMenu
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void MissedMenu_Load(object sender, EventArgs e)
        {
            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
            DataTable dt = new DataTable();
            BindingSource bs = new BindingSource();
            var table = dt;

   
            conn.Open();
           
            string startDate = label1.Text;
            string endDate = label2.Text;
            var selectedStartDateTime = DateTime.Parse(startDate);
            var selectedEndDateTime = DateTime.Parse(endDate);
            for (var day = selectedStartDateTime.Date; day.Date <= selectedEndDateTime.Date; day = day.AddDays(1))
            {
                string SQLTemplate = "select employees.firstname, misseddays.date, misseddays.signinTime , misseddays.signoutTime, misseddays.notes from misseddays join employees where employees.EmployeeID = misseddays.employeeID and date = '{0}' order by employees.firstname; ";
                var SQL = string.Format(SQLTemplate, day.ToShortDateString());
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                table.Load(cmd.ExecuteReader());

                bs.DataSource = table;
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = bs;
            }

                // Add EmployeeIDs to a List



            }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close PayrollDisplay and open AdminMenu
            AdminMenu f2 = new AdminMenu();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
