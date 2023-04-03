using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            userValidation.ValidatePassWord("A1bab_cdt");
            userValidation.ValidatePassWord("abcAB-C1234");
            userValidation.ValidatePassWord("Ganesh@1906");
        }
    }
}