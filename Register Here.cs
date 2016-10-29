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
    public partial class Register_Here : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=pyserver.database.windows.net;Initial Catalog=PayrollSystem;Persist Security Info=True;User ID=Admin_123;Password=Password0;TrustServerCertificate=True");
        
        public Register_Here()
        {
            InitializeComponent();
          

        }

        private void previous_screen2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page frm = new Login_Page();
            frm.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
               
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into Login (ID, username,  [password]) values ('" + textBox10.Text + "', '" + textBox5.Text + "',  '" + textBox3.Text + "' ); ", connection);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is Saved");
              
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
