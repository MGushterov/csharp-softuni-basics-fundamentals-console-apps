using System;

namespace NxN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintCage(number);
        }

        static void PrintCage(int number)
        {
            for (int verticalRow = 0; verticalRow < number; verticalRow++)
            {
                for (int horizontalRow = 0; horizontalRow < number; horizontalRow++)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }   
    }
}
