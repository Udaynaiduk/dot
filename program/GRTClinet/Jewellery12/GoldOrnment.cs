using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Jewellery12
{
    internal class GoldOrnment : Ornment
    {
        internal int charat { get; set; }

        internal override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the purity");
            charat = Convert.ToInt32(Console.ReadLine());
            
        }
        internal override void Display()
        {
            base.Display();
            Console.Write(" purity:" + charat);
            Console.WriteLine();

        }

    }
}
