int[] num=new int[10];
int count=0,i;
for(i=0;i<10;i++){
    Console.WriteLine("Enter number{0}:",i);
    num[i]=Convert.ToInt32(Console.ReadLine());
}
foreach(int j in num){
    if(j%5==0){
count+=1;
    }
}
Console.WriteLine(count);