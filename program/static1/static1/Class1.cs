using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static1
{
    internal class Class1
    {
        static int c = 0;
        internal int data = 0;
        public Class1() {
            c++;
            data++;
        }
        internal void fun2()
        {
              
            Console.WriteLine(data);
            
        }
      internal  static  void fun1()
        {
            Console.WriteLine(c);
        }
    }
}
