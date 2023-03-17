namespace LinQ1
{
    internal class Program
    {
        delegate void cal(int x, int y);
        static void Main(string[] args)
        {
            //  string[] name = { "uday", "thrun" };
            /*var data = from i in name
                       select i;
            var data = name.Where((p) => p.StartsWith('u'));

            foreach (var i in data)
            {
                Console.WriteLine(i);
            }

            List<Product> products = new List<Product>()

              {

                  new Product() { Id = 1, names = "poco",price=20000 },
              new Product() { Id = 2, names = "Mi",price=15000 },
              new Product() { Id = 3, names = "vivo",price=10000 }
          };
            var value = from i in products

                         select i;
            var value = products.Where((p) => p.price>10000)
                .OrderBy(i=>i.name)
                .Select(i=>new {i.names,i.price});
                

            foreach (dynamic i in value)
            {
                Console.WriteLine(i);
            }

           
                        //delegate
                          cal c;
                          c = Add;
                          c(5, 4);
                          c += (int a, int b) => { Console.WriteLine(a + b); };
                         c(5,4);

                         // c += (int a, int b) => { Console.WriteLine(a * b); };
                         // c(5, 4);
                          //c += (int a, int b) => { Console.WriteLine(a / b); };
                          //c(5, 5);
                          //calling named function
                          fun(Add);
                          fun((x, y) => { Console.WriteLine(x + y); });//calling lambda  funtiuons
                        fun3((a, b) =>  a + b);

           
            fun4(test);
            
            }


                      }

                      static    void Add(int a, int b)
                          {
                              Console.WriteLine(a + b);
                          }
                      static void fun(cal c1)
                      {
                          c1(5, 6);
                      }
                     static void fun3(Func<int,int,int> fun)
                      {
                        Console.WriteLine( fun(5, 6));
                      }
                      static  void fun4(Func<int,int,string> f)
                      {
                          Console.WriteLine(f(10, 10));
                      }

                     static string test(int a,int b)
                      {
                          int c = a + b;
                          return $"a+b{c}";


                      }
                    */
            var x = (string a, string b) => 1;
           Console.WriteLine(x("uday", "uday"));
        }
           

        }
    }


