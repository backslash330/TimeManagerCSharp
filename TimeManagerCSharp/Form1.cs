using System;
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
    public partial class Form1 : Form
    {
        public Form1()
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

            MySqlConnection.ClearAllPools();
            MySqlConnection conn = new MySqlConnection("persistsecurityinfo=True;server=localhost;user id=backslash330;database=timemanager");
            
            try
            {
                employeeListBox.Items.Add("TEST");
                employeeListBox.Items.Add("TEST");

                conn.Open();
                employeeListBox.Items.Add("TEST");

                string SQL = "SELECT FirstName from employees ";
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employeeListBox.Items.Add("This is a test");
                    employeeListBox.Items.Add("This is a test");
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
            
        }
    }
}
