using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidateFirstName("Abc");
            userValidation.ValidateFirstName("Ab");
            userValidation.ValidateFirstName("abcd");
            userValidation.ValidateFirstName("Abcd");
        }
    }
}