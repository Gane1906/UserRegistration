using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidatePassWord("A1babcdt");
            userValidation.ValidatePassWord("abcABC1234");
            userValidation.ValidatePassWord("123456A");
        }
    }
}