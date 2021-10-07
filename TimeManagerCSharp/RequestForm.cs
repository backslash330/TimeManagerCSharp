using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

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

            //capture text input
            string body = requestTextBox.Text;


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

        }

        private void returnButton_Click(object sender, EventArgs e)
        {

            // close RequestForm and open MainMenu
            MainMenu f1 = new MainMenu();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
