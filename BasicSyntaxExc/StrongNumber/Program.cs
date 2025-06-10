using System;

namespace StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int usedNum = num;
            int factorial = 0;
            
            int finalSum = 0;

            for (int i = usedNum; usedNum > 0; i--)
            {
                factorial = usedNum % 10;
                usedNum /= 10;
                int factorialSum = 1;

                for (int j = 1; j <= factorial; j++)
                {
                    factorialSum *= j;
                }

                finalSum += factorialSum;
            }
            if (finalSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");

            }

        }
    }
}
