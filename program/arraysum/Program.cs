int[] num=new int[10];
int i,sum=0;
for(i=0;i<10;i++){
    Console.WriteLine("Enter the num{0}",i);
    num[i]=Convert.ToInt32(Console.ReadLine());
}
foreach(int j in num){
    sum+=j;
}
Console.WriteLine(sum);