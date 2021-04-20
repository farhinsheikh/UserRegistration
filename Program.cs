using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserValidation.FirstName();
            UserValidation.LastName();
            UserValidation.Email();
            UserValidation.MobileNumber();
            UserValidation.Password();
        }
    }
}