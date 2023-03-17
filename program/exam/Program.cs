namespace ovwels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enetr the word");
            string word;
           word= Console.ReadLine();
          string n=ovwels(word);
           Console.WriteLine(n);
            Console.WriteLine("Hello, World!");
        }
      
          static string ovwels(string name)
        {

            /*StringBuilder s=new StringBuilder(name);
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] =='a')
                {
                  s.Replace(s[i].ToString(),"");
                  i--;  
                }

            }*/
            string str = "";

            for(int i = 0; i < name.Length; i++)
            {
                if (name[i]=='a'|| name[i] == 'e'|| name[i] == 'i'|| name[i] == 'o'|| name[i] == 'u')
                {

                }
                else
                {
                    str=str + name[i];
                }
            }
          
            return str;
        }  

        }
    }
