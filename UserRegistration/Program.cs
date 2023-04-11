using System;
using System.Linq.Expressions;

namespace UserRegistration
{
    public class Program
    {
        static void Main(String[] args)
        {
            LambdaFunctionsDemo lambda = new LambdaFunctionsDemo();
            Console.Write("Enter First name: ");
            if (lambda.ValidateFirstName())
                Console.WriteLine("Valid First name");
            else
                Console.WriteLine("Invalid First name");
            Console.Write("Enter Last name: ");
            if (lambda.ValidateLastName())
                Console.WriteLine("Valid Last name");
            else
                Console.WriteLine("Invalid Last name");
            Console.Write("Enter Email: ");
            if (lambda.ValidateEmail())
                Console.WriteLine("Valid email");
            else
                Console.WriteLine("Invalid email");
            Console.Write("Enter Phone number: ");
            if (lambda.ValidatePhone())
                Console.WriteLine("Valid mobile number");
            else
                Console.WriteLine("Invalid mobile number");
            Console.Write("Enter Password: ");
            if (lambda.ValidatePassword())
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
    }
}