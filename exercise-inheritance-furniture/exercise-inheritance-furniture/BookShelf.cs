
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of Furniture
    public class BookShelf : Furniture
    {  //Add  NoOfLegs  property
        public int NoOfShelves { get; set; }
        //overrride the Accept method to read NoOfLegs property also
        //
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the NoOfLegs");
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        //override the Display method to include the display of NoOfLegs property also
        public override void Display()
        {
            base.Display();
            Console.Write("  NoOfShelves" + NoOfShelves);

        }
    }
}

















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:28:32 PM 
*/
