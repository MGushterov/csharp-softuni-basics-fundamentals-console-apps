using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double finalsum = 0.0;

            for (int i = 1; i <= orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double sum = (days * capsules * pricePerCapsule);
                finalsum += sum;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }
            Console.WriteLine($"Total: ${finalsum:f2}");
        }
    }
}
