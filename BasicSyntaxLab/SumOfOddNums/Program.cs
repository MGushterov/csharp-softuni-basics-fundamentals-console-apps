using System;

namespace SumOfOddNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfNums = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;

            for (int i = 0; i < amountOfNums; i++)
            {
                num = 1 + (i * 2);

                sum += num;
                Console.WriteLine(num);


            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
