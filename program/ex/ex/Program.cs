using System.Text;
using System.Text.RegularExpressions;

namespace ex
{
    internal class Program
    {
            static void Main(string[] args)
            {
            string id = Console.ReadLine();
           Console.WriteLine( Regex.Match(id, "[a-e][0-9]{4}"));


            }

          /*  static string ovwels(string name)
            {

                StringBuilder s = new StringBuilder(name);
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a'|| s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' )
                    {
                        s.Replace(s[i].ToString(), "");
                        
                    }

                }

            return s.ToString();
            }
          */
        }
    }

