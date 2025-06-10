using System;

namespace PrintPartOfAscii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = beginning; i <= end; i++)
            {
                char ch = (char)i;
                Console.Write($"{ch} ");
            }
        }
    }
}
