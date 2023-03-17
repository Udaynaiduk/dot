
using System;
using System.Collections.Generic;
using System.Text;


namespace exercise_inheritance_furniture
{
    //child of furniture
   public class DiningTable : Furniture
    {
        //Add  NoOfLegs  property
        public int NoOfLegs;
        //overrride the Accept method to read NoOfLegs property also
        //
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter the NoOfLegs");
            NoOfLegs=Convert.ToInt32(Console.ReadLine());
        }
        //override the Display method to include the display of NoOfLegs property also
        public override void Display()
        {
            base.Display();
            Console.Write(" :NoOfLegs" + NoOfLegs);
        }
    }
}


















































/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:27:28 PM 
*/
