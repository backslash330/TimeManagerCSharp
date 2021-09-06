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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Must Enter a First Name!");
                return;
            }
            else if (textBox2.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Must Enter a Last Name!");
                return;
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                System.Windows.Forms.MessageBox.Show("Must Choose a Break Option");
                return;
            }

            else
            {
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                try
                {

                    conn.Open();
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;


                    string SQLTemplate = "SELECT * FROM employees WHERE Firstname like '{0}' And LastName like '{1}'";
                    string SQL = string.Format(SQLTemplate, firstName, lastName);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        System.Windows.Forms.MessageBox.Show("There is already an Employee with this Name");
                        return;
                    }
                    else
                    {
                        reader.Close();
                        string SQLTemplate2 = "INSERT into employees(FirstName, LastName) VALUES('{0}', '{1}')";
                        string SQL2 = string.Format(SQLTemplate2, firstName, lastName);
                        Console.WriteLine(SQLTemplate2);
                        MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();
                        reader2.Close();
                        System.Windows.Forms.MessageBox.Show("Employee Succefully Added!");
                    }


                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Must Enter a First Name!");
                return;
            }
            else if (textBox2.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Must Enter a Last Name!");
                return;
            }

            else
            {
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                try
                {

                    conn.Open();
                    string firstName = textBox1.Text;
                    string lastName = textBox2.Text;


                    string SQLTemplate = "SELECT * FROM employees WHERE Firstname like '{0}' And LastName like '{1}'";
                    string SQL = string.Format(SQLTemplate, firstName, lastName);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == false)
                    {
                        System.Windows.Forms.MessageBox.Show("Employee Does Not Exist");
                        return;
                    }
                    else
                    {
                        reader.Close();
                        string SQLTemplate2 = "DELETE FROM employees WHERE Firstname = '{0}' And LastName = '{1}'";
                        string SQL2 = string.Format(SQLTemplate2, firstName, lastName);
                        Console.WriteLine(SQLTemplate2);
                        MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();
                        reader2.Close();
                        System.Windows.Forms.MessageBox.Show("Employee Succefully Deleted!");
                    }


                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nstartDate = dateTimePicker1.Text;
            string nendDate = dateTimePicker2.Text;
            PayrollDisplay f4 = new PayrollDisplay(nstartDate, nendDate);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
