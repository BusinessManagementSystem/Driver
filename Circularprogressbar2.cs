using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sprint_2_draft
{
    public partial class Circularprogressbar2 : UserControl
    {
        double progress;


        public Circularprogressbar2()
        {

            InitializeComponent();
        }




        private void Circularprogressbar2_Paint(object sender, PaintEventArgs e)
        {

            
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen obj_pen = new Pen(Color.Blue);
            Rectangle rect1 = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height / 2 + 20, this.Width - 40, this.Height - 40);
            e.Graphics.DrawPie(obj_pen, rect1, 0, (int)(this.progress * 3.6));
            e.Graphics.FillPie(new SolidBrush(Color.Blue), rect1, 0, (int)(this.progress * 3.6));

            obj_pen = new Pen(Color.White);
            rect1 = new Rectangle(0 - this.Width / 2 + 30, 0 - this.Height / 2 + 30, this.Width - 60, this.Height - 60);
            e.Graphics.DrawPie(obj_pen, rect1, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.White), rect1, 0, 360);
            e.Graphics.RotateTransform(90);

            StringFormat ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(this.progress.ToString() + "%", new Font("Arial", 18), new SolidBrush(Color.Blue), rect1, ft);



        }
        public void UpdateProgress(float progress)
        {
            this.progress = progress;

        }

        private void Circularprogressbar2_Load(object sender, EventArgs e)
        {


            SqlConnection connection = new SqlConnection("Data Source=pyserver.database.windows.net;Initial Catalog=PayrollSystem;Persist Security Info=True;User ID=Admin_123;Password=Password0;TrustServerCertificate=True");

            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from Employee where Earningsalary > 15000;", connection);

            SqlDataReader reader = cmd.ExecuteReader();
            double count = 0;

            while (reader.Read())
            {
                count = count + 1;

            }
            reader.Close();


            SqlCommand cmd1 = new SqlCommand("select * from Employee;", connection);

            SqlDataReader reader1 = cmd1.ExecuteReader();
            double countTotal = 0;

            while (reader1.Read())
            {
                countTotal++;
            }


            double result;
            result = (count / countTotal) * 100;
            progress = result;

            reader1.Close();

        }

    }
}
