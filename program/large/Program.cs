

int num1=100;
int num2=140;
int num3=134;
if(num1>num2 && num1>num3){
    Console.WriteLine("{0} greater than {1} and {2}",num1,num2,num3);
}
else if(num2>num3){
    Console.WriteLine(" {0} is greater than {1} and {2}",num2,num1,num3);
}
else{
    Console.WriteLine(" {0} is greater than {1} and {2}",num3,num1,num2);
}