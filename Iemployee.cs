using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busmngt
{
    public interface Iemployee
    {
        string Name { get; set; }
        int Age { get; set; }
        string Position { get; set; }
        void Working();
    }
}
