using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestK = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine()); 
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestK = model;
                }
            }

            Console.WriteLine(biggestK);
        }
    }
}
