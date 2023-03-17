using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRT
{
    [Serializable]
     class Customer
    {


            public string Name { get; set; }
            public string Address { get; set; }

            public Customer(string a, string b)
            {
                Name = a;
                Address = b;
            }
            public override string ToString()
            {
                return $"Name:{Name} Address{Address}";

            }

        }
    }


