using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistrationProblem
{
    class UserValidation
    {
     //*****For first name*****
        public static void FirstName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
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
        //*****for last name*****
        public static void LastName()
        {
            string regex = "[A-Z]{1}[a-z]{3,10}$";
            Console.WriteLine("Enter Last Name");
            string lName = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(lName);
            if (result == true)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
       // *****for email******
        public static void Email()
        {
            string regex = "[a-zA-Z0-9_.]+@[a-zA-Z.]+$";
            Console.WriteLine("Enter your email");
            string email = Console.ReadLine();
            Regex rg = new Regex(regex);
            bool result = rg.IsMatch(email);
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