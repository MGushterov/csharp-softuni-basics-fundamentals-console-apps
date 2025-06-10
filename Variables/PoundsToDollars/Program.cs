using System;

namespace PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pounds = double.Parse(Console.ReadLine());
            decimal dollars = (decimal)(pounds * 1.31);
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
