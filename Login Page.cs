using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace sprint_2_draft
{
    public partial class Login_Page : Form
    {

       
        public Login_Page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void Login_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection connection = new SqlConnection("Data Source=pyserver.database.windows.net;Initial Catalog=PayrollSystem;Persist Security Info=True;User ID=Admin_123;Password=Password0;TrustServerCertificate=True");
        
                SqlCommand cmd = new SqlCommand("select role from Login where [username] ='" + this.textBox1.Text + "'and [password]= '" + this.textBox2.Text + "' ;", connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int count = 0;
                
               
               
                while (reader.Read())
                {
                    count = count + 1;
                  
                }
                if (count == 1 && textBox1.Text.ToString().Equals("Admin"))
                {
                    MessageBox.Show("User is Admin!");
                    this.Hide();
                    DashBoard1 frm = new DashBoard1();
                    frm.Show();
                }

                else if (count == 1 && textBox1.Text.ToString().Equals("HR"))
                {
                    MessageBox.Show("User is HR!");
                    this.Hide();
                    HR_page frm = new HR_page();
                    frm.Show();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Invalid Username or Password");

                }
                else
                {
                    MessageBox.Show("An Employee just logged In");
                    this.Hide();
                    payroll frm = new payroll();
                    frm.Show();
                }
                  
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

         

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Here_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register_Here frm = new Register_Here();
            frm.Show();
        }

        private void Previous_page_Click(object sender, EventArgs e)
        {
            this.Hide();
            Splash_Screen frm = new Splash_Screen();
            frm.Show();
            
        }
    }
}
