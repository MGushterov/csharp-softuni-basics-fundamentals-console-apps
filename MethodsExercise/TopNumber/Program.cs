using System;

namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numString = Console.ReadLine();
            int number = int.Parse(numString);

            for (int i = 1; i <= number; i++)
            {
                int currNum = i;
                if (PrintTopInteger(currNum, numString) == true)
                {
                    Console.WriteLine(currNum);
                }
            }
        }
        static bool PrintTopInteger(int number, string numString)
        {
            if (PrintIfSumOfDigitsIsDivisibleByEight(number, numString) == true && PrintIfOddDigitExists(number, numString) == true)
            {
                return true;
            }
            return false;
        }
        static bool PrintIfSumOfDigitsIsDivisibleByEight(int number, string numString)
        {
            int sum = 0;

            for (int i = 0; i < numString.Length; i++)
            {
                int currDigit = number % 10;
                number /= 10;
                sum += currDigit;
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
        static bool PrintIfOddDigitExists(int number, string numString)
        {
            for (int i = 0; i < numString.Length; i++)
            {
                int currDigit = number % 10;
                number /= 10;
                if (currDigit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
