
using System;

namespace SmallestOfThreeNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            DetermineSmallestNumber(number1, number2, number3);
        }

        static void DetermineSmallestNumber(int number1, int number2, int number3)
        {
            int smallestNum = int.MaxValue;
            int[] numberStack = new int[3]
            {
            number1,
            number2,
            number3,
            };
            for (int i = 2; i >= 0; i--)
            {
                int currNum = numberStack[i];
                if (currNum < smallestNum)
                {
                    smallestNum = currNum;
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
}
