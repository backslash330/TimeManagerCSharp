using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;using MySql.Data.MySqlClient;

namespace TimeManagerCSharp
{
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RequestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void requestInstructLabel_Click(object sender, EventArgs e)
        {

        }

        private void requestTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

            // make sure name has been picked
            if (employeeListBox.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Please Select a name");
            }
            else
            {

                // Ensure name selected matches name inputted
                string boxSelect = employeeListBox.SelectedItem.ToString();
                string boxSelectConfirmation = employeeListBox.SelectedItem.ToString().ToLower().Trim();
                string writtenConfirmation = employeeWrittenInput.Text.ToLower().Trim();
                if (boxSelectConfirmation != writtenConfirmation)
                {
                    System.Windows.Forms.MessageBox.Show("ERROR:Selected name and written name do not match. Submission unsuccessful");
                    return;
                }

                // Retrieve EmployeeID
                // clear and connect to database
                MySqlConnection.ClearAllPools();
                MySqlConnection conn = new MySqlConnection("server=localhost;user id=backslash330;password=UrsaMinor;persistsecurityinfo=True;database=timemanager");
                string EmployeeID = "";

                // find employeeIDs for relative names         
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

                // Insert Date, SigninTime, SignoutTime, Notes and ID into misseddays Table of TimeManager
                try
                {
                    string notes = richTextBox1.Text;
                    string date = dateTimePicker.Text;
                    string startTime = startDateTimePicker.Text;
                    string endTime = endDateTimePicker.Text;
                   

                    conn.Open();

                    string SQLTemplate = "INSERT INTO misseddays(EmployeeID, date, signinTime, signoutTime, notes) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                    string SQL = string.Format(SQLTemplate, EmployeeID, date, startTime, endTime, notes);
                    MySqlCommand cmd = new MySqlCommand(SQL, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
                System.Windows.Forms.MessageBox.Show("Submission succesful, management will review your Form.");

            }


















            /* PREVIOUS SUBMIT BUTTON FUNCTIONALITY

            //capture text input FIX THIS 
            string body = "ERROR";


            //capture time 
            DateTime now = DateTime.Now;
            string nowFormat = now.ToString("yyyy - MM - dd hh: mm:ss");
            string subject = string.Format("TimeManager Adjustment Request {0}", nowFormat);

            // Configure sneder and recipient
            var fromAddress = new MailAddress("n.almeida3300@gmail.com", "North Star Support");
            var toAddress = new MailAddress("northstarautomotives@gmail.com", "North Star Auto");
            const string fromPassword = "OrionsBelt";
            

            // Configure the message details
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                // Send Message
                smtp.Send(message);
            }
            // Inform the user that there message sent 
            MessageBox.Show("Message Successfully Sent");
            */
        }

        private void returnButton_Click(object sender, EventArgs e)
        {

            // close RequestForm and open MainMenu
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

            // clear and connect to database
            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = backslash330; password = UrsaMinor; persistsecurityinfo = True; database = timemanager");
            MySqlConnection conn2 = new MySqlConnection("server = 192.168.56.1; user id = backslash330; password = UrsaMinor; persistsecurityinfo = True; database = timemanager");

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
