int odd=0,even=0,n,i,num;
Console.WriteLine("Enter n numbers");
n=Convert.ToInt32(Console.ReadLine());
for(i=1;i<=n;i++){
    Console.WriteLine("enetr number{0}",i);
    num=Convert.ToInt32(Console.ReadLine());
    if(num%2==0){
        even+=1;

    }
    if(num%2!=0){
        odd+=1;
    }
}
Console.WriteLine(even+"even count"+odd+"odd count");