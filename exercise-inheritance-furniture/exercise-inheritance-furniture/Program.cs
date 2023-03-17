using System;
using System.Dynamic;
using System.Xml.Serialization;

namespace exercise_inheritance_furniture
{
   public class Program
    {
        static void Main(string[] args)
        {
            Furniture[] items = new Furniture[2];
            Program p=new Program();
            int a=p.AddToStock(items);
            double b = p.TotalStockValue(items);
            int c=p.ShowStockDetails(items);


            //create an array  of objects in furniture type
            //create program class object
            // call AddToStock(<furniture array>);
            //call ShowStockDetails(<furniture array>);
            // call TotalStockValue(<furniture array>) and display output 
             
            
        }
       public int AddToStock(Furniture []items) {
            int Count = 0,Choice;
            for(Count= 0; Count < items.Length; Count++)
            {
                Console.WriteLine("Enter the choice 1.BookShelf 2.DiningTable");
                Choice = Convert.ToInt32(Console.ReadLine());
                switch (Choice)
                {
                    case 1:
                        items[Count] = new BookShelf();
                        Console.WriteLine("Enter BookShelf Data");
                        items[Count].Accept();
                        break;
                    case 2:
                        items[Count] = new DiningTable();
                        Console.WriteLine("Enter Diningtable Data");
                        items[Count].Accept();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }

            }


            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            // and according to the choice create necessary sub class object and store data
            //continue the process up to the size of array

            // return <size of array>;
            return Count;
        }
     public   double TotalStockValue(Furniture []items)
        {
            double stockValue=default;
            foreach(var c in items)
            {
                stockValue+= c.Price * c.Qty;

            }
            //calculate total stock value i.e qty * price of each item
            return stockValue;
        }
        public   int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock
            foreach(var c in items)
            {
                c.Display();
            }
           //return <size of array>;
           return 0;    
        }
    }
}
