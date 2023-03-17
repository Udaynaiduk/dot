using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example
{
    internal class Honda : Icar
    {
        public void Acceleration()
        {
            Console.WriteLine("Honda is moving");
        }
        public void GearChange()
        {
            Console.WriteLine("Honda is gear change");
        }
        public void Breaking()
        {
            Console.WriteLine("Honda is stoping now");
        }
    }
}
