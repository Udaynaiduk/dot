using System;

namespace PhoneNumberValidator
{
    //Please do not change the signature of class methods

    public class PhoneNumberValidator
    {
        static void Main(string[] args)
        {
            DisplayResult(ValidatePhoneNumber(GetInput()));
            // call the functions to validate phone number and display the status
        }
        public static string GetInput()
        {

            // get phonenumber as input
           string input;
                input = Console.ReadLine();
            
            return input;
            
       

        }
        public static void DisplayResult(int result)
        {
            if (result == 1)
            {
                Console.WriteLine("Valid");
            }
            if (result == 0 || result == -1)
            {
                Console.WriteLine("Invalid");
            }
            // display status of phone number valid or invalid
        }
        public static int ValidatePhoneNumber(string input)
        {
            if (input == null)
            {
                return -1;
            }
            
            int count = 0;
            foreach (char c in input)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' )
                {
                    count++;
                }
                
            }
            if (count == 10)
            {
                return 1;
            }
            else if (input =="" )
            {
                return -1;
            }
           
            
            else
            {
                return 0;

            }
           
        }
        
    }
}

