using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ1
{
    internal class Product
    {
        public int Id { get; set; }

        public string names { get; set; }
       public int price { get; set; }   
      

        
       public override string ToString()
        {
            return $"Id:{Id} Name:{names} Price:{price}";
        }
       
    }
}
