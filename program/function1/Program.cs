int n;
double accept5(){
    int n1=1,n2;
    double sum=0;
    Console.WriteLine("enter n numbers");
    n=Convert.ToInt32(Console.ReadLine());
    while(n1<=n){
        Console.WriteLine("enter number {0}",n1);

n2=Convert.ToInt32(Console.ReadLine());
sum+=n2;
n1++;2

    }
    
    return sum;
}
 void avg(double sum,int n){
    double avg1=sum/n;
    Console.WriteLine("sum="+sum+" and average="+avg1);
 }
 
 double sum1=accept5();
 avg(sum1,n);
/* avg(20,4);
 //avg(accept5(),n); */


 