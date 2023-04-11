using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class LambdaFunctionsDemo
    {
        public bool ValidateFirstName() => Regex.IsMatch(Console.ReadLine(), "^[A-Z]{1}[a-z]{2,}$");
        public bool ValidateLastName() => Regex.IsMatch(Console.ReadLine(), "^[A-Z]{1}[a-z]{2,}$");
        public bool ValidateEmail() => Regex.IsMatch(Console.ReadLine(), "^[0-9A-Za-z]+[.+-_]{0,1}[0-9A-Za-z]+[@][]A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$");
        public bool ValidatePhone() => Regex.IsMatch(Console.ReadLine(), "^[6-9]{1}[0-9]{9}$");
        public bool ValidatePassword() => Regex.IsMatch(Console.ReadLine(), "^(?=[a-zA-Z0-9#@$?-_]{8,}$)(?=.*?[a-z])(?=.*?[A-Z])(?=.*?[0-9]).*$");
    }
}
