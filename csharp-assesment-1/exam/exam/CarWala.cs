using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exam
{
    class CarWala
    {
       private Dictionary<string, double> car = new Dictionary<string, double>(); //Declear Dictionary
        public  CarWala()
        {
            //Instialize the key value pairs
            
            car.Add("Honda", 800000);
            car.Add("Suziki", 500000);
            car.Add("Maruthi", 500000);
            car.Add("Ford", 1500000);
            car.Add("MercedeseBenz", 5000000);
            car.Add("Audi", 3000000);
            car.Add("MercedeseQ7", 7000000);
            car.Add("RollsRoyals", 40000000);
            car.Add("Nano", 100000);
            car.Add("Tesla", 20000000);

        }
        //create Function Display Car Names Start With M
       public void ListNames()

        {
            Console.WriteLine("Cars Name Start With M");
            foreach(KeyValuePair<string,double> kvp in car)
            {
                if (Regex.IsMatch(kvp.Key,"[M]"))
                {
                    Console.WriteLine(kvp.Key+":"+kvp.Value);
                }
            }
            Console.WriteLine("---------------------------");
        }
        //Creat Function Display Car Names Above 10 Lakshs
        public void ListPrice()
        {
            Console.WriteLine("Car Name Above 10 Lakshs");
            foreach(KeyValuePair<string,double> kvp in car)
            {
                if (kvp.Value > 1000000)
                {
                    Console.WriteLine(kvp.Key+":"+kvp.Value);
                }
            }
            Console.WriteLine("---------------------------");
        }
        //Creat Funtion If Price is Greater than 15 Lakshs Apply 20% Discount
        public void ApplyDiscount()
        {
            Console.WriteLine("Discount Car Details");
            foreach (KeyValuePair<string, double> kvp in car)
            {
                //try and catch block 
                if (kvp.Value > 1500000)
                {
                    try//try for if value greater than 15 lakh
                    {

                        double value = (kvp.Value * 0.2);

                        Console.WriteLine(kvp.Key + ":" + value);
                    }
                    catch(Exception e)//catch generic exception
                    {
                        Console.WriteLine(e.Message);
                    }

                }
            
                }
            Console.WriteLine("---------------------------");
            }
        }

    }
    
