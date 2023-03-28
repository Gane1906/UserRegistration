using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidateMobileNumber("9154871234");
            userValidation.ValidateMobileNumber("1234567890");
            userValidation.ValidateMobileNumber("913455");
        }
    }
}