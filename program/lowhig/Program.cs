int low=999,hig=0,i,n,num;
Console.WriteLine("Enter the n numbers");
num=Convert.ToInt32(Console.ReadLine());


for(i=1;i<=num;i++){
    Console.WriteLine("enter the number{0}",i);
    n=Convert.ToInt32(Console.ReadLine());
    if(n<low){
        low=n;
    }
    if(n>hig){
        hig=n;

    }
}
Console.WriteLine(low +"and"+hig);