using System;

namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inspectedNum = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenNums(inspectedNum);
            int oddSum = GetSumOfOddNums(inspectedNum);
            Console.WriteLine(evenSum * oddSum);
        }


        static int GetSumOfEvenNums(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currDigit = number % 10;
                number /= 10;

                if (currDigit % 2 == 0)
                {
                    sum += currDigit;
                }
            }
            return sum;
        }

        static int GetSumOfOddNums(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int currDigit = number % 10;
                number /= 10;

                if (currDigit % 2 != 0)
                {
                    sum += currDigit;
                }
            }
            return sum;
        }
    }
}
