using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidateEmail("abc.xyz@bridgelabz.co.in");
            userValidation.ValidateEmail("abc123@gmail.com");
            userValidation.ValidateEmail("abc123");
        }
    }
}