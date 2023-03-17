// See https://aka.ms/new-console-template for more information
double gross,net;
double discount;
Console.WriteLine("Enter gross");
gross=Convert.ToDouble(Console.ReadLine());

if(gross>=10000)
{
    discount=gross*0.10;
    net=gross-discount;
    Console.WriteLine("Net value:"+net);
}
else{
    discount=gross*0.5;
    net=gross-discount;
    Console.WriteLine("Net value:"+net);
}