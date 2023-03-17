namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator1 c = new calculator1();
            /*   c.sum(2, 3);
            c.sum(3, 4,4);
            int result;
            
            int r = c.Summ1(out result,out string a);
            Console.WriteLine(r+" "+result+" "+a);

            var d= c.fun2();
            Console.WriteLine(d);
          */
            
            int[] A=new int[]{1,2,3,5,6,0,3,9,101};

            int[] r;
            r = c.fun1(A, 1, 2, 3,4,6,0,5,10,100);
           
            foreach(int i  in r)
            {
                
                Console.Write(" "+i);
            }
            
            
        }
    }
}