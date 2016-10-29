using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint_2_draft
{
    interface Ipayroll
    {
        string employeeName { get; set; }
        string startDate { get; }
        string endDate { get; }
        double regularHours { get; }
        double overtimeHours { get; }
        string totalEarnings { get; }


    }
}
