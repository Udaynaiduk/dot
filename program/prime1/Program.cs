void prime(int num){
    int flag=0;
    if(num==0 || num==1){
        flag=1;
    }
    for(int i=2;i<=num/2;i++){
        if(num%i==0){
            flag=1;
        }
    }
    if(flag==0){
        Console.WriteLine("Prime");
    }
    if(flag==1){
        Console.WriteLine("Not prime");
    }
}
prime(10);