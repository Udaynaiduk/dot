using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery12
{
    internal  abstract  class Ornment
    {
        internal int Id { get; set; }
        internal string Name{ get; set; }
        internal string Description{ get; set; }
         internal double Weight { get; set; }

        internal virtual void Accept()
        {
            Console.WriteLine("Enter the Name");
            Name =Console.ReadLine();
            Console.WriteLine("Enter Description");
            Description =Console.ReadLine();
            Console.WriteLine("Enter the Weight");
            Weight =Convert.ToDouble(Console.ReadLine());

        }

        internal virtual void Display()
        {
            Console.WriteLine("Name:"+Name+"  Description:"+Description+"  Weight"+Weight);
          
        }


    }
}
