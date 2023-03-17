int num,i,n;
double sum=0,avg=0;
Console.WriteLine("enter n numbers");
n=Convert.ToInt32(Console.ReadLine());

for(i=1;i<=10;i++){
    Console.WriteLine("Enter number{0}",i);
    num=Convert.ToInt32(Console.ReadLine());
    sum+=num;

}
Console.WriteLine(sum);
avg=sum/n;
Console.WriteLine(avg);
