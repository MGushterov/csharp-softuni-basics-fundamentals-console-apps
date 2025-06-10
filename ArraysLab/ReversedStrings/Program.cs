using System;

namespace ReversedStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            Array.Reverse(symbols);
            
            foreach (string symbol in symbols)
            {
                Console.Write($"{symbol} ");
            }
        }
    }
}
