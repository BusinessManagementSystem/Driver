using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace sprint_2_draft
{
    public partial class HR_page : Form
    {
        public HR_page()
        {
            Thread t = new Thread(new ThreadStart(Splashstart));
            t.Start();
            Thread.Sleep(1500);
            InitializeComponent();
            t.Abort();

        }
        public void Splashstart()
        {
            Application.Run(new Splash_Screen());
        }

        private void HR_Page_Load(object sender, EventArgs e)
        {
            
        }

        private void HR_Click(object sender, EventArgs e)
        {
            Login_Page frm = new Login_Page();
            frm.Show();
            this.Hide();
        }

        private void Owner_Click(object sender, EventArgs e)
        {
            Login_Page frm = new Login_Page();
            frm.Show();
            this.Hide();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
              Login_Page frm = new Login_Page();
            frm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        }
    }


