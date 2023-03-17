using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    internal class Building
    {
        internal int Id { get; set; }
        internal string Name { get; set; }
        internal double Plintharea { get; set; }
        public void Accept()
        {
            Console.WriteLine("Enter the Id ");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name  ");
            Name= Console.ReadLine();
            Console.WriteLine("Enter the Area ");
            Plintharea=Convert.ToDouble( Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Id:" + Id + " Name:" + Name + " PlinthArea:" + Plintharea);
        }
    }
}
 