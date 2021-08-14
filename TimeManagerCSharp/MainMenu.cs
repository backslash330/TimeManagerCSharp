using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TimeManagerCSharp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // employee list box
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.nslogo;
            // clear and connect to database
            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = backslash330; password = UrsaMinor; persistsecurityinfo = True; database = timemanager");


            // populate listbox with active employee names from employees table            
            try
            {

                conn.Open();

                string SQL = "SELECT FirstName FROM employees";
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employeeListBox.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // make sure name has been picked
            if (employeeListBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select a name");
            }
            else
            {

            // Retrieve and format date and time 
                string boxSelect = employeeListBox.SelectedItem.ToString();
                DateTime now = DateTime.Now;
                string nowFormat = now.ToString("yyyy - MM - dd hh: mm:ss");
                string timeFormat = now.ToLongTimeString();   // display format:  11:45:44 AM
                string dateFormat = now.ToShortDateString();  // display format:  5/22/2010

                // Retrieve EmployeeID
                // clear and connect to database
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                string EmployeeID = "";

                // populate listbox with active employee names from employees table            
                try
                {

                    conn.Open();

                    string SQLTemplate = "SELECT EmployeeID FROM employees WHERE FirstName = '{0}'";
                    string data = boxSelect;
                    string SQL = string.Format(SQLTemplate, data);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        EmployeeID = reader.GetString(0);
                    }
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();

                // ensure name is not already logged in
                try
                {

                    conn.Open();

                    string SQLTemplate = "SELECT * FROM signin WHERE EmployeeID ='{0}' and Date ='{1}'";
                    string SQL = string.Format(SQLTemplate, EmployeeID, dateFormat);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        System.Windows.Forms.MessageBox.Show("Already Signed In!");
                        return;
                    }


                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();

                // Insert Date, Time and ID into signin Table of TimeManager
                try
                {

                    conn.Open();

                    string SQLTemplate = "INSERT INTO signin(EmployeeID, Date, Time) VALUES ('{0}', '{1}', '{2}')";
                    string SQL = string.Format(SQLTemplate, EmployeeID, dateFormat, timeFormat);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
               System.Windows.Forms.MessageBox.Show("Login Successful");
              
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            // make sure name has been picked
            if (employeeListBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select a name");
            }
            else
            {

                // Retrieve and format date and time 
                string boxSelect = employeeListBox.SelectedItem.ToString();
                DateTime now = DateTime.Now;
                string nowFormat = now.ToString("yyyy - MM - dd hh: mm:ss");
                string timeFormat = now.ToLongTimeString();   // display format:  11:45:44 AM
                string dateFormat = now.ToShortDateString();  // display format:  5/22/2010

                // Retrieve EmployeeID
                // clear and connect to database
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                string EmployeeID = "";

                // populate listbox with active employee names from employees table            
                try
                {

                    conn.Open();

                    string SQLTemplate = "SELECT EmployeeID FROM employees WHERE FirstName = '{0}'";
                    string data = boxSelect;
                    string SQL = string.Format(SQLTemplate, data);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        EmployeeID = reader.GetString(0);
                    }
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();

                // ensure name is not already logged in
                try
                {

                    conn.Open();

                    string SQLTemplate = "SELECT * FROM signout WHERE EmployeeID ='{0}' and Date ='{1}'";
                    string SQL = string.Format(SQLTemplate, EmployeeID, dateFormat);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        System.Windows.Forms.MessageBox.Show("Already Signed In!");
                        return;
                    }


                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();

                // Insert Date, Time and ID into signout Table of TimeManager
                try
                {

                    conn.Open();

                    string SQLTemplate = "INSERT INTO signout(EmployeeID, Date, Time) VALUES ('{0}', '{1}', '{2}')";
                    string SQL = string.Format(SQLTemplate, EmployeeID, dateFormat, timeFormat);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
                System.Windows.Forms.MessageBox.Show("Login Successful");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RequestForm f3 = new RequestForm();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string correctPassword = "test";
            string inputPassword = textBox1.Text;
            if (inputPassword == correctPassword)
            {
                AdminMenu f2 = new AdminMenu();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect Password");
            }
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
