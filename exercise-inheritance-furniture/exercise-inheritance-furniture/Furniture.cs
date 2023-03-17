
using System;
using System.Collections.Generic;
using System.Text;
namespace exercise_inheritance_furniture
{
   public abstract class Furniture
    {
        //Add below mentioned Properties 
        //Height(int),Width(int),Color(string),Price(double),Qty(int)
        public int Height { get; set; }
        public int Width { get; set; }  
        public string Color { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }    
        public virtual void Accept()
        {
            Console.WriteLine("Enetr the Heighr ");
           Height =Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enetr the Width ");
           Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr the Color ");
            Color= Console.ReadLine();

            Console.WriteLine("Enetr the Price ");
           Price = Convert.ToDouble(Console.ReadLine()); Console.ReadLine();

            Console.WriteLine("Enetr the ");
            Qty = Convert.ToInt32(Console.ReadLine());
            //code to accept height,width ,color,price and qty

        }
        public virtual void Display()
        {
            //code to display height width ,price,qty and color
            Console.WriteLine("Height" + Height + "  Width:" + Width + "  Color:" + Color + " Price:" + Price + " Qty" + Qty); 
        }
    }
}






























/**
* @author Anilkumar.S
*
* @date - 8/24/2020 2:24:45 PM 
*/
