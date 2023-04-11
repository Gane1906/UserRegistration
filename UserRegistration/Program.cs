using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            Console.WriteLine(userValidation.ValidateFirstName("G"));
        }
    }
}