using System;
using System.Xml.XPath;

namespace NumberAverage
{
    public class NumberAverage
    {
        static void Main(string[] args)
        {

            int num;
            Console.WriteLine("Enter the no of array elements");
            num = Convert.ToInt32(Console.ReadLine());

            // declare array for the given size
            int[] array = new int[num];

            //get the values of the array from the user
            Console.WriteLine("Enter the array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            string result = FindAverage(array);
            Console.WriteLine(result);

        }

        //write here logic to calculate the average an array
        public static string FindAverage(int[] array)
        {
            if (array.Length ==0)
            {
                return "Array is Empty";
            }
            int sum = 0;
            
            
            foreach(int i in array)
            {
                if (i < 0)
                {
                    return "Negative values in array";
                }
                else
                {
                    sum += i;
                }
            }
   

            return "The Average is: "+sum/array.Length;
        }
    }

}