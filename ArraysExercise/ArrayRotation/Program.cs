using System;
using System.Linq;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rotatedNumbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int firstNum = rotatedNumbers[0];
                for (int j = 0; j < rotatedNumbers.Length - 1; j++)
                {
                    rotatedNumbers[j] = rotatedNumbers[j + 1];
                }
                rotatedNumbers[rotatedNumbers.Length - 1] = firstNum;
            }

            Console.WriteLine(string.Join(" ", rotatedNumbers));
        }
    }
}
