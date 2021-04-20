using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistrationProblem
{
    class UserValidation
    {
        public static void FirstName()
        {
            string regex = "^[A-Za-z]{3,}$";
            Console.WriteLine("Enter first name");
            string fName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(fName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}