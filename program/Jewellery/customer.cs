class Customer{
int _Id;
string Name;
string Address;
public int Id{get{return _Id;} set{_Id=value;}}
 public void Accept(){
  Console.WriteLine("-----------------------");
    Console.WriteLine("Enter your name:");
    Name=Console.ReadLine();
    Console.WriteLine("-----------------------");
    Console.WriteLine("Enter your address");
    Address=Console.ReadLine();
    Console.WriteLine("-----------------------");

}
  public void Display(){
    Console.WriteLine("-----------------------");
    Console.WriteLine($"Id:{_Id}");
    Console.WriteLine($"Name:{Name}");
    Console.WriteLine($"Address:{Address}");
    Console.WriteLine("-----------------------");

}


}

































