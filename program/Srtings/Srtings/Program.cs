using System.Text;
namespace Srtings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder table = new StringBuilder("");
            for(int i=1;i<=10;i++)
            {
                table.AppendFormat("{0}*{1}={2}\n", 5, i, 5 * i);
            }

Console.WriteLine(table.ToString());
        }
    }
}