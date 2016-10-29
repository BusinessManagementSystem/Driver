using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprint_2_draft
{
    public partial class DashBoard1 : Form
    {
        public DashBoard1()
        {
            InitializeComponent();
        }

        private void Employee_Count_by_Age_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'payrollSystemDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.payrollSystemDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Previous_Screen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page frm = new Login_Page();
            frm.Show();
        }

        private void DSS3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard3 ds3 = new Dashboard3();
            ds3.Show();
        }

        private void DSS2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard2 ds2 = new Dashboard2();
            ds2.Show();
        }

        private void DSS1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Dashboard 1");
        }
    }
}
