﻿using System;

namespace MetersToKm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            float kilometers = meters / 1000.0f;
            Console.WriteLine($"{kilometers:f2}");

        }
    }
}
