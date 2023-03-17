using System.Linq;
namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "uday", "Bhaskar" };
            var data = name.Where((s) => s.StartsWith('u'));
            foreach (dynamic i in data)
            {
                Console.WriteLine(i);
            }
        }
    }
}