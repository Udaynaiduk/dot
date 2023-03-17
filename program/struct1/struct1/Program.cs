namespace struct1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            struct2 s;
            s.Name = "uday";
            s.Addres = "add";
            Console.WriteLine(s);
            record1 n = new record1(1,"uday");
            Console.WriteLine(n);
           
        }
    }
}