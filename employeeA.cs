using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busmngt
{
    public class employeeA:Iemployee
    {
        private string employeename=string.Empty;
        private int employeeage;
        private string employeeposition;

        public employeeA(string name, int age, string position)
        {
            Name = name;
            Age = age;
            Position = position;

        }
        public string Name
        {
            get
            {
                return employeename;
            }
            set
            {
                employeename = value;
            }
        }

        public int Age
        {
            get
            {
                return employeeage;
            }
            set
            {
                employeeage=value;
            }
        }

        public string Position
        {
            get
            {
                return employeeposition;
            }
            set
            {
                employeeposition=value;
            }
        }

        public void Working()
        {
           try
            {
                Console.WriteLine(Name + "is working");
            }
           catch
           {
               Console.WriteLine("Error in employeeA class");
               Console.ReadKey();
               Environment.Exit(0);
           }
        }
    }
}
