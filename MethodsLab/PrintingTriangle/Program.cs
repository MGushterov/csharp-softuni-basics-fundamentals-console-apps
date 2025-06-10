using System;

namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            PrintTriangle(limit);
        }

        static void PrintTriangle(int limit)
        {
            for (int rows = 1; rows <= limit; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{columns} ");
                }
                Console.WriteLine();
            }
            for (int rows = limit - 1; rows >= 1; rows--)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{columns} ");
                }
                Console.WriteLine();
            }
        }
    }
}
