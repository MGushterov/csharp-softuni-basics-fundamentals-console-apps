﻿using System;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());


            double V = (height * width * length) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
