using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace exercise_state_wise_temperature_average
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*declare array for collecting temperature of cities of 3 states
            
             *first state provides temperature of 3 cities
             *second state provides temperature of 7 cities
             *third state provides temperature of 4 cities
            */
            int[][] temprature=new int[3][];
            temprature[0] = new int[] {9,8,2};
            temprature[1] = new int[7] {3,4,5,6,7,8,9};
            temprature[2]=new int[3] {9,8,4};
            for(int i = 0; i < temprature.Length; i++)

            {
                Console.WriteLine($"Enter {i + 1} state temperature ");
                for(int j = 0; j < temprature[i].Length; j++)
                {
                    temprature[i][j]=Convert.ToInt32(Console.ReadLine());

                }
            }


            for (int i = 0; i < temprature.Length; i++)
            {
                var result = GetStateWiseAverage(i, temprature);
                Console.WriteLine(result);
            }
        }

        /* 
         * Method calculates average of temperature for the state whose position is provided
         */

        public  static int GetStateWiseAverage(int index,int[][] temprature)
        {
            if(index<0||index>=temprature.Length)
            {
                throw new IndexOutOfRangeException("Invalid state Index");
            }
            int sum = 0;
            int[] temp = temprature[index];
           
                foreach (int i in temp)
                {
                    sum+=i;
                    
                }
            

            // put here logic to calculate average
            return sum/temp.Length;
        }
    }
}

