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
    public partial class Dashboard2 : Form
    {
        public Dashboard2()
        {
            InitializeComponent();
        }

        private void Previous_Screen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page frm = new Login_Page();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void DSS2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Dashboard 2");
        }

        private void DSS3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard3 ds3 = new Dashboard3();
            ds3.Show();
        }

        private void Dashboard2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollSystemDataSet.Employee);


        }

        private void DSS1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard1 ds1 = new DashBoard1();
            ds1.Show();
        }

        private void circularprogressbar1_Load(object sender, EventArgs e)
        {
            
        }

       

       

        
    }
}
