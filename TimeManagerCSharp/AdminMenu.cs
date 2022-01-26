using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TimeManagerCSharp
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void payrollHoursButton_Click(object sender, EventArgs e)
        {
            // intialize variables to pass to PayrollDisplay
            string nstartDate = startDateTimePicker.Text;
            string nendDate = endDateTimePicker.Text;

            //Open PayrollDisplay, pass variables and close AdminMenu
            PayrollDisplay f4 = new PayrollDisplay(nstartDate, nendDate);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            // Close AdminMenu and open MainMenu
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addemployeeButton_Click(object sender, EventArgs e)
        {
            // Make sure a first name has been entered
            if (firstNameTextBox.Text == "")
            {
                MessageBox.Show("Must Enter a First Name!");
                return;
            }

            // Make sure a last name has been entered
            else if (lastNameTextBox.Text == "")
            {
                MessageBox.Show("Must Enter a Last Name!");
                return;
            }

            // if those conditions are correct, add or remove the employee
            else
            {
                // Open connection to MySQL server
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                try
                {
                    //open sql connection
                    conn.Open();

                    // initialize variables
                    string firstName = firstNameTextBox.Text;
                    string lastName = lastNameTextBox.Text;

                    // create SQL statement and execute it 
                    string SQLTemplate = "SELECT * FROM employees WHERE Firstname like '{0}' And LastName like '{1}'";
                    string SQL = string.Format(SQLTemplate, firstName, lastName);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Make sure that an employee with the same name does not already exist
                    if (reader.Read() == true)
                    {
                        MessageBox.Show("There is already an Employee with this Name");
                        return;
                    }
                    else
                    {
                        // Add employee to table
                        reader.Close();
                        string SQLTemplate2 = "INSERT into employees(FirstName, LastName) VALUES('{0}', '{1}')";
                        string SQL2 = string.Format(SQLTemplate2, firstName, lastName);
                        Console.WriteLine(SQLTemplate2);
                        MySqlCommand cmd2 = new MySqlCommand(SQL2, conn);
                        MySqlDataReader reader2 = cmd2.ExecuteReader();
                        reader2.Close();

                        // Inform user that the process has been successful
                        MessageBox.Show("Employee Succefully Added!");
                    }


                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            // Make sure a first name has been entered
            if (firstNameTextBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Must Enter a First Name!");
                return;
            }

            // Make sure a last name has been entered
            else if (lastNameTextBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Must Enter a Last Name!");
                return;
            }

            // if those conditions are correct, add or remove the employee
            else
            {
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                try
                {
                    // Open connection to MySQL server
                    conn.Open();

                    // initialize variables
                    string firstName = firstNameTextBox.Text;
                    string lastName = lastNameTextBox.Text;

                    // create SQL statement and execute it 
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
                        //drop employee from employees
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

        private void daysButton_Click(object sender, EventArgs e)
        {
            // intialize variables to pass to PayrollDisplay
            string nstartDate = startDateTimePicker.Text;
            string nendDate = endDateTimePicker.Text;

            //Open PayrollDisplay, pass variables and close AdminMenu
            MissedMenu f4 = new MissedMenu(nstartDate, nendDate);
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
