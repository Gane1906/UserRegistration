using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidatePassWord("1Ab6abcd");
            userValidation.ValidatePassWord("abc123");
            userValidation.ValidatePassWord("123456A789");
        }
    }
}