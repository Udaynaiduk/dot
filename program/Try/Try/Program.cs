namespace Try
{
    internal class Program
    {
        static void Main(string[] args)
        {

            sumlimation n = new sumlimation();
            Console.WriteLine("Enter rate");
            int r=Convert.ToInt32(Console.ReadLine());  
            try
            {
                double v = n.calculate(r);

                Console.WriteLine(v);
            }
            catch (illegal) { 
                Console.WriteLine("Negative value");
            }

            /* try
             {
                 Console.WriteLine("Enter a number");
                 int a = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("The number is " + a);
             }
             catch(FormatException e){
                 Console.WriteLine(e.Message);
             }
             catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }
             finally { Console.WriteLine("End program"); }
         }*/

        }
    }
}