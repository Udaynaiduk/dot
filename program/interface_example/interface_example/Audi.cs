using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_example
{
    internal class Audi:Icar
    {
        public void Acceleration()
        {
            Console.WriteLine("Audi is moving");
        }
        public void  GearChange()
        {
            Console.WriteLine("Audi is gear change");
        }
        public void Breaking()
        {
            Console.WriteLine("Audi is stoping now");
        }
    }
}
