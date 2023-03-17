using System.IO;
using System.IO.Enumeration;

namespace file_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Readf("C:\\Users\\VMUser\\uday.txt");
        }
        static void Writef()
        {
            Console.WriteLine("Enter the data");
            string data=Console.ReadLine();
            StreamWriter w = new StreamWriter(@"C:\Users\VMUser\uday.txt");
            w.Write(data);
            w.Close();
        }
        static void Readf(string filename)
        {
            StreamReader r = new StreamReader(@filename);
           /* while (!r.EndOfStream)
            {
                /*int ch = r.Read();
                    Console.Write((char)ch);
                string ch=r.ReadLine();
                Console.WriteLine(ch);   
            } */
            r.Close();
        }
    }
}