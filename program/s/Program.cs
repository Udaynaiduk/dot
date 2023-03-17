// See https://aka.ms/new-console-template for more information
int num1=1;
int  num2,n;
int sum=0;

Console.Write("Enter how many numbers:");
n=Convert.ToInt32(Console.ReadLine());
while(num1<=n){
    Console.WriteLine("Enter number {0}",num1);
    num2=Convert.ToInt32(Console.ReadLine());
    sum+=num2;
    num1++;

}


float average;
average=Convert.ToSingle(sum)/Convert.ToSingle(n);
Console.WriteLine(sum);
Console.WriteLine(average);
