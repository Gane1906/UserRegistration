using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidateSecondName("Abc");
            userValidation.ValidateSecondName("Ab");
            userValidation.ValidateSecondName("abcd");
            userValidation.ValidateSecondName("Abcd");
        }
    }
}