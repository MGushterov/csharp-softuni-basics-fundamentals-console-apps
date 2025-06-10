using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculatePower(@base, power));
        }

        static double CalculatePower(double @base, double power)
        {
            double result = 1.0;

            for (int timesRaised = 0; timesRaised < power; timesRaised++)
            {
                result *= @base;
            }

            return result;
        }
    }
}
