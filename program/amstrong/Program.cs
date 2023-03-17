void Amstrong(int num){
    int temp,r,sum=0;
    temp=num;
    while(num!=0)
    {
        r=num%10;
        sum+=(r*r*r);
        num/=10;
        
    }
    if(temp==sum){
        Console.WriteLine("Amstrong");
    }
    if(temp!=sum){
        Console.WriteLine("Not Amstrong");
    }
}
Amstrong(153);