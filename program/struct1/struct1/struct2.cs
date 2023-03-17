using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct1
{
    internal struct struct2
    {
        public string Name;
        public string Addres;
       /* internal  struct2(string n,string a)
        {
            Name = n;
            Address = a;
            
        }*/

        public override string ToString()
        {
            return "Name"+ Name + "   Address" + Addres;
        }
    }
}
