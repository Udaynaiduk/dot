class Sublimation{
    double Weight,Price,Depreciation,Makingcharage,Gross,Total,Net;
     public void Details(){
Console.WriteLine("Enter the Weight ");
Weight=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter price for 1 gram");
Price=Convert.ToDouble(Console.ReadLine());
Gross=Weight*Price;
    }
    public void DepreciationCalculator(){
Console.WriteLine("Enter depreciation percentage");
Depreciation=Convert.ToDouble(Console.ReadLine());
Total=Gross*Depreciation;


    }
    public void MakingCharageCalculator(){

        Console.WriteLine("Enter making charge percentage");
Makingcharage=Convert.ToDouble(Console.ReadLine());
Total+=Gross*Makingcharage;
    }
    public void NetCalculator(){
        Net=Gross+Total;
        Console.WriteLine("Net value:{0}",Net);
    }
}