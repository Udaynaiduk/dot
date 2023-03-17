int num,n=1,greater=0;
while(n<=5)
{
Console.WriteLine("Enter numner{0}",n);
   num=Convert.ToInt32(Console.ReadLine());
    if(num>greater){
        greater=num;
    }
n++;



}
Console.WriteLine(greater);


    