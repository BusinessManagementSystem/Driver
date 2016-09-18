using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busmngt
{
    public class inventoryB:Iinventory
    {
        private string itemname = string.Empty;
        private string vendorname;
        private int num;
        private int price;

        public inventoryB(string itemn, string vendorn, int n, int p)
        {
            item = itemn;
            vendor = vendorn;
            number = n;
            amount = p;
        }

        public string item
        {
            get
            {
                return itemname; ;
            }
            set
            {
                itemname=value;
            }
        }

        public string vendor
        {
            get
            {
                return vendorname;
            }
            set
            {
                vendorname=value;
            }
        }

        public int number
        {
            get
            {
               return num;
            }
            set
            {
                num=value;
            }
        }

        public int amount
        {
            get
            {
                return price;
            }
            set
            {
                price=value;
            }
        }

        public void receivedBy(Iemployee staff)
        {
            try
            {
                if (staff.Position == "manager")
                    staff.Working();
                else
                    Console.WriteLine("staff is not a manager");
            }
            catch
            {
                Console.WriteLine("error in Receivedby");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
