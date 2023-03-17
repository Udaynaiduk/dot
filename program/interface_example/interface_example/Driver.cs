using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example
{
    internal class Driver
    {
        public void Driving(Icar c)
        {
            c.Acceleration();
            c.Breaking();
            c.GearChange();
        }
    }
}
