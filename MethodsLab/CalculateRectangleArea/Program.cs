using System;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine(RectangleArea(sideA, sideB));
        }

        static int RectangleArea(int sideA, int sideB)
        {
            int area = sideA * sideB;
            return area;
        }
    }
}
