using System.Collections;
using System.Text.RegularExpressions;

namespace interface_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            /*Driver D=new Driver();
             Honda H=new Honda();
             Audi A=new Audi();
             D.Driving(H);
             D.Driving(A);*/


            /*ArrayList list=new ArrayList();
            list.Add(1);
            list.Add(new Honda());
            list.Add("hello");
            foreach(object o in list)
            {
                Console.WriteLine(o);
                if(o is Honda)
                {
                    ((Honda)o).Acceleration();

                }
            }
            Hashtable table=new Hashtable();
            table.Add(1, 1);
            table.Add(2, new Honda());
            table.Add(3, "hello");
            foreach(DictionaryEntry o in table)
            {
                Console.WriteLine(o.Key+" "+o.Value.ToString());
                if(o.Value is Honda)
                {
                    ((Honda)o.Value).Acceleration();

                }
            }
            Stack list=new Stack();
            list.Push(1);
            list.Push(new Honda()); 
            foreach(object i in list.ToArray())
            {
                Console.WriteLine(i);
                if (i is Honda)
                {
                    ((Honda)i).Acceleration();

                }
            }
            Queue queue= new Queue();  
            queue.Enqueue(1);
            queue.Enqueue(new Honda());
            foreach(object i in queue)
            {
                Console.WriteLine(i);
                if(i is Honda)
                {
                    ((Honda)i).Acceleration();
                }
            }

            generic1<int> g=new generic1<int>();
            g.display(10);
            LinkedList<Honda> h=new LinkedList<Honda>();
            h.AddFirst(new Honda());
            h.AddFirst(new Honda());
            foreach(Honda i in h)
            {
                i.Acceleration();
            }
            Stack<Honda> list=new Stack<Honda>();
            list.Push(new Honda()); 
            list.Push(new Honda()); 
            foreach(Honda i in list)
            {
                i.Acceleration();
            }
            Queue<Honda> que=new Queue<Honda>();
            que.Enqueue(new Honda());
            que.Enqueue(new Honda());
            foreach(Honda i in que)
            {
                i.Acceleration();
            }
            */
            Dictionary<string, double> d = new Dictionary<string, double>();
            d.Add("honda ", 100000);
            d.Add("audi", 500000);
            d.Add("ma", 45);
            foreach (KeyValuePair<string, double> i in d)
            {

               

            }
            display(d);
        }
            static void display(Dictionary<string,double> d)
            {
                foreach (KeyValuePair<string, double> i in d)
                {

                    if (i.Value > 100000)
                    {
                    double value = i.Value - i.Value *0.2;
                    Console.WriteLine(i.Key+":"+value);
                    }

                if (Regex.IsMatch(i.Key, "[m]"))
                {
                    Console.WriteLine(i.Key+":"+i.Value);
                }

                }
               
            }

        }
    }
