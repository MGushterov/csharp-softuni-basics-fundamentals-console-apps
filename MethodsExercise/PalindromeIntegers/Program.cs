using System;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();

            //make to lower!!

            while (numberString != "END")
            {
                PrintPalindromeNumber(numberString);
                numberString = Console.ReadLine();
            }
        }
        static void PrintPalindromeNumber(string numberString)
        {
            int number = int.Parse(numberString);
            int[] numArgs = new int[numberString.Length];

            for (int i = 0; i < numberString.Length; i++)
            {
                int currDigit = number % 10;
                numArgs[i] = currDigit;
                number /= 10;
            }

            if (numArgs.Length % 2 == 0)
            {
                Console.WriteLine(PrintPalindromeNumberIfLengthIsEven(numArgs).ToString().ToLower());
            }
            else
            {
                Console.WriteLine(PrintPalindromeNumberIfLengthIsOdd(numArgs).ToString().ToLower());
            }

        }
        static bool PrintPalindromeNumberIfLengthIsOdd(int[] numArgs)
        {
            bool isPalindrome = true;
            for (int i = 0; i < numArgs.Length - 2; i++)
            {
                if (numArgs[i] == numArgs[(numArgs.Length - 1) - i])
                {
                    continue;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
        static bool PrintPalindromeNumberIfLengthIsEven(int[] numArgs)
        {
            bool isPalindrome = true;
            for (int i = 0; i <= numArgs.Length - 2; i++)
            {
                if (numArgs[i] == numArgs[(numArgs.Length - 1) - i])
                {
                    continue;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
