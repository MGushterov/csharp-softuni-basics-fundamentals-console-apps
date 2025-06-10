using System;

namespace CharsInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char symbol1 = char.Parse(Console.ReadLine());
            char symbol2 = char.Parse(Console.ReadLine());
            PrintCharsInRange(symbol1, symbol2);
        }

        static void PrintCharsInRange(char symbol1, char symbol2)
        {
            if (symbol1 < symbol2)
            {
                for (int i = symbol1 + 1; i < symbol2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = symbol2 + 1; i < symbol1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
