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
    public partial class HR_page : Form
       
    {
        SqlConnection connection = new SqlConnection("Data Source=pyserver.database.windows.net;Initial Catalog=PayrollSystem;Persist Security Info=True;User ID=Admin_123;Password=Password0;TrustServerCertificate=True");
        public HR_page()
        {
            InitializeComponent();
        }

        private void HR_page_Load(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee (id, firstname, lastname, DOB, department, phonenumber,zipcode) values ('" + textBox10.Text + "', '" + textBox1.Text + "',  '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "' ); ", connection);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Information is now Saved");
              
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeactivateEmployee_CheckedChanged(object sender, EventArgs e)
        {
             try
            {
                 MessageBox.Show("Please enter employee ID number and First Name");
                 textBox2.Enabled=false;
                 textBox3.Enabled=false; 
                 textBox4.Enabled=false; 
                 textBox5.Enabled=false; 
                 textBox6.Enabled=false; 
                 string temp=Convert.ToString(textBox10.Text);
               if (temp!=" ")
                 connection.Open();
                SqlCommand cmd = new SqlCommand("delete from Employee where id= '" + textBox10.Text + "' and firstname='" + textBox1.Text + "'); ", connection);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Information is now Deactivated");
              
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Previous_Screen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page frm = new Login_Page();
            frm.Show();
        }
    }
}
