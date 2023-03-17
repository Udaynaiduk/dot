namespace Jewellery12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer n = new Customer("uday","ana");
            Console.WriteLine(n);

          /*  int choice = 0, Count = 0;
            Ornment[] Or= new Ornment[2];
            while (Count < 2)
            {
                Console.WriteLine("Enter the Choice 1.Glod 2.Sliver 3.Exit");
                choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Or[Count] = new GoldOrnment();
                        Console.WriteLine("Gold data");
                        

                        break;
                    case 2:
                        Or[Count] = new SliverOrnment();
                        Console.WriteLine("Sliver data");
                        

                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }
                Or[Count].Accept();
                Count++;
            }
                for(int i=0;i<Or.Length;i++)
                {
                    Or[i].Display();

                }
*/
            

        }
    }
}