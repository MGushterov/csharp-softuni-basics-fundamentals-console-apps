using System;

namespace SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                int numValueOfChar = (int)currChar;
                sum += numValueOfChar;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
