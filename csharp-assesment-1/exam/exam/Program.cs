namespace exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarWala car1= new CarWala();//Create new Instance of Carwala class
            //Call the Display Functions
            car1.ListNames();
            car1.ListPrice();
           
            car1.ApplyDiscount();
        }
    }
}