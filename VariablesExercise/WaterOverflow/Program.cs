using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const int Capacity = 255;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                sum += liters;
                if (sum> Capacity)
                {
                    sum -= liters;
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
