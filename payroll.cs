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
    public partial class payroll : Form
    {
        
        public payroll()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void payroll_Load(object sender, System.EventArgs e)
        {
            DateTime todayDate = DateTime.Today;
            DateTime twoWeeksAgo = todayDate.AddDays(-14);

            this.dateTimePicker1.Value = twoWeeksAgo;

        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            // Get the starting date
            DateTime dteStart = this.dateTimePicker1.Value;

            // Find out if the user selected a day that is not Monday
            if (dteStart.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("The date you selected in invalid\n" +
                    "The time period should start on a Monday");

                this.dateTimePicker1.Focus();
            }

        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            // Get the starting date
            DateTime dteStart = this.dateTimePicker2.Value;
            // Get the ending date
            DateTime dteEnd = this.dateTimePicker2.Value;

            // Make sure the first day of the period is Monday
            if (dteStart.DayOfWeek != DayOfWeek.Monday)
            {
                MessageBox.Show("The starting date you selected in invalid\n" +
                    "The time period should start on a Monday");

                this.dateTimePicker2.Focus();
            }

            // Find the number of days that separate the start and end
            TimeSpan timeDifference = dteEnd.Subtract(dteStart);
            double fourteenDaysLater = timeDifference.Days;

            if ((dteEnd.DayOfWeek != DayOfWeek.Sunday) || (fourteenDaysLater != 13))
            {
                MessageBox.Show("The ending date you selected in invalid\n" +
                    "The time period should span 2 weeks and end on a Sunday");

                this.dateTimePicker2.Focus();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double monday1 = 0.00, tuesday1 = 0.00, wednesday1 = 0.00, thursday1 = 0.00,
       friday1 = 0.00, saturday1 = 0.00, sunday1 = 0.00,
                  monday2 = 0.00, tuesday2 = 0.00, wednesday2 = 0.00, thursday2 = 0.00,
           friday2 = 0.00, saturday2 = 0.00, sunday2 = 0.00;
            double totalHoursWeek1, totalHoursWeek2;

            double regHours1 = 0.00, regHours2 = 0.00, ovtHours1 = 0.00, ovtHours2 = 0.00;
            double regAmount1 = 0.00, regAmount2 = 0.00, ovtAmount1 = 0.00, ovtAmount2 = 0.00;
            double regularHours, overtimeHours;
            double regularAmount, overtimeAmount, totalEarnings;

            double hourlySalary = 25.00;

            // Retrieve the hourly salary
            try
            {
                hourlySalary = double.Parse(this.label2.Text);
            }
            catch (FormatException)
            {
                //MessageBox.Show("The value you typed for the salary is invalid \n" +
                  //              "Please try again");
               // this.label2.Focus();
            }

            // Retrieve the value of each day worked
            try
            {
                monday1 = double.Parse(this.Monday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Monday1.Focus();
            }
            try
            {
                tuesday1 = double.Parse(this.Tuesday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Tuesday1.Focus();
            }
            try
            {
                wednesday1 = double.Parse(this.Wednesday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Wednesday1.Focus();
            }
            try
            {
                thursday1 = double.Parse(this.Thursday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Thursday1.Focus();
            }
            try
            {
                friday1 = double.Parse(this.Friday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Friday1.Focus();
            }
            try
            {
                saturday1 = double.Parse(this.Saturday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Saturday1.Focus();
            }
            try
            {
                sunday1 = double.Parse(this.Sunday1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Sunday1.Focus();
            }
            try
            {
                monday2 = double.Parse(this.Monday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Monday2.Focus();
            }
            try
            {
                tuesday2 = double.Parse(this.Tuesday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Tuesday2.Focus();
            }
            try
            {
                wednesday2 = double.Parse(this.Wednesday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Wednesday2.Focus();
            }
            try
            {
                thursday2 = double.Parse(this.Thursday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Thursday2.Focus();
            }
            try
            {
                friday2 = double.Parse(this.Friday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Friday2.Focus();
            }
            try
            {
                saturday2 = double.Parse(this.Saturday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Saturday2.Focus();
            }
            try
            {
                sunday2 = double.Parse(this.Sunday2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You typed an invalid value\n" +
                    "Please try again");
                this.Sunday2.Focus();
            }

            // Calculate the total number of hours for each week
            totalHoursWeek1 = monday1 + tuesday1 + wednesday1 + thursday1 +
                              friday1 + saturday1 + sunday1;
            totalHoursWeek2 = monday2 + tuesday2 + wednesday2 + thursday2 +
                              friday2 + saturday2 + sunday2;

            // The overtime is paid time and half
            double ovtSalary = hourlySalary * 1.5;

            // If the employee worked under 40 hours, there is no overtime
            if (totalHoursWeek1 < 40)
            {
                regHours1 = totalHoursWeek1;
                regAmount1 = hourlySalary * regHours1;
                ovtHours1 = 0.00;
                ovtAmount1 = 0.00;
            } // If the employee worked over 40 hours, calculate the overtime
            else if (totalHoursWeek1 >= 40)
            {
                regHours1 = 40;
                regAmount1 = hourlySalary * 40;
                ovtHours1 = totalHoursWeek1 - 40;
                ovtAmount1 = ovtHours1 * ovtSalary;
            }

            if (totalHoursWeek2 < 40)
            {
                regHours2 = totalHoursWeek2;
                regAmount2 = hourlySalary * regHours2;
                ovtHours2 = 0.00;
                ovtAmount2 = 0.00;
            }
            else if (totalHoursWeek2 >= 40)
            {
                regHours2 = 40;
                regAmount2 = hourlySalary * 40;
                ovtHours2 = totalHoursWeek2 - 40;
                ovtAmount2 = ovtHours2 * ovtSalary;
            }

            regularHours = regHours1 + regHours2;
            overtimeHours = ovtHours1 + ovtHours2;
            regularAmount = regAmount1 + regAmount2;
            overtimeAmount = ovtAmount1 + ovtAmount2;
            totalEarnings = regularAmount + overtimeAmount;

            this.RegularHours.Text = regularHours.ToString("F");
            this.OvertimeHours.Text = overtimeHours.ToString("F");
            this.RegularAmount.Text = regularAmount.ToString("F");
            this.OvertimeAmount.Text = overtimeAmount.ToString("F");

            this.TotalEarningsAmount.Text = totalEarnings.ToString("F");

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page frm = new Login_Page();
            frm.Show();
        }

    }
}
