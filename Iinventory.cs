using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busmngt
{
    interface Iinventory
    {
        string item { get; set; }
        string vendor { get; set; }
        int number { get; set; }
        int amount { get; set;}
        void receivedBy(Iemployee staff);
    }
}
