int n,i,num,gre=0;
Console.WriteLine("Enter n numbers");
n=Convert.ToInt32(Console.ReadLine());
for(i=1;i<=n;i++){
Console.WriteLine("Enter the number{0}",i);
num=Convert.ToInt32(Console.ReadLine());
if(num>gre){
    gre=num;
}
}
Console.WriteLine(gre);