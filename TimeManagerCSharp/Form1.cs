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
            OnLoad();
        }
        
        protected override void OnLoad(EventArgs)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=timemanagmentdatabase");
            try
            {
                conn.Open();

                string SQL = "SELECT FirstName from employees ";
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    {
                    ListBox1.Items.Add
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

        // employee list box
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
