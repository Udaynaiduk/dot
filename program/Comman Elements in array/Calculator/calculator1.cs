using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class calculator1
    {
        /* internal void sum(params  int[] b)
         {
             int sum = 0;
             foreach(int i in b)
             {
                 sum+=i;
             }
             Console.WriteLine(sum);

         }
         public int Summ1(out int a,out string s)
         {
             a = 100;
             s = "uday";
             return 1;
         }
         public (int,string) fun2()
         {
             return (3, "uday");
         }*/
        internal int[] fun1(int[] num1, params int[] num2)
        {
            int c = 0;
            int[] array1 = new int[num2.Length];

            for (int i = 0; i < num1.Length; i++)
            {
                for (int j = 0; j < num2.Length; j++)
                {

                    {

                        if (num1[i] == num2[j])
                        {

                            array1[i] = num2[j];
                            c++;
                            break;

                        }
                    }





                }


            }
           Array.Resize(ref array1, c);
                return array1; 

        }
    }
}

