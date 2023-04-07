using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            UserValidation userValidation = new UserValidation();
            string[] email = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc11@abc.net", "abc-100@abc.net", "abc.100@abc.com.au" };
            foreach (string emailItem in email)
            {
                userValidation.ValidateEmail(emailItem);
            }
        }
    }
}