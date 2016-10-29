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
    public partial class Dashboard3 : Form
    {
        public Dashboard3()
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

        private void DSS3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already on Dashboard 3");
        }

        private void DSS2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard2 ds2 = new Dashboard2();
            ds2.Show();
        }

        private void DSS1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard1 ds1 = new DashBoard1();
            ds1.Show();
        }

        private void Dashboard3_Load(object sender, EventArgs e)
        {

        }

      
    }
}
