using System;
using System.Linq;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int lowerLimit = 6;
            const int upperLimit = 10;
            const int minAmountOfDigits = 2;
            
            string password = Console.ReadLine();
            bool passIsValid = IsValidated(password, lowerLimit, upperLimit, minAmountOfDigits);

            if (passIsValid)
            {
                Console.WriteLine("Password is valid");
            }

        }
        
        static bool IsValidated(string password, int lowerLimit, int upperLimit, int minAmountOfDigits)
        {
            bool isValid = true;
            if (!IsInRange(password, lowerLimit, upperLimit))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }
            if (!IsAlphaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }
            if (!HasMinimalAmountOfDigits(password, minAmountOfDigits))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            return isValid;
        }
        static bool IsInRange(string password, int lowerLimit, int upperLimit)
        {
            if (password.Length >= lowerLimit && password.Length <= upperLimit)
            {
                return true;
            }
            return false;
        }
        static bool IsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HasMinimalAmountOfDigits(string password, int minAmountOfDigits)
        {
            int sum = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    sum++;
                }
            }

            return sum >= minAmountOfDigits;
        }
    }
}
