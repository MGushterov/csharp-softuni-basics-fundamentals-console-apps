using System;

namespace CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{letter1}{letter2}{letter3}"); 
        }
    }
}
