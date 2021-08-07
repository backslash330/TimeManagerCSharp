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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //capture text input
            string body = richTextBox1.Text;
            System.Windows.Forms.MessageBox.Show(body);


            //capture time 
            DateTime now = DateTime.Now;
            string nowFormat = now.ToString("yyyy - MM - dd hh: mm:ss");
            string subject = string.Format("TimeManager Adjustment Request {0}", nowFormat);

            var fromAddress = new MailAddress(", "From Name");
            var toAddress = new MailAddress("", "To Name");
            const string fromPassword = "";

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
                smtp.Send(message);
            }

        }    
    }
}
