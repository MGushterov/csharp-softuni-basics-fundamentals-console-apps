﻿using System;

namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int division = -1;

            if (num % 10 == 0)
            {
                division = 10;
            }
            else if (num % 7 == 0)
            {
                division = 7;
            }
            else if (num % 6 == 0)
            {
                division = 6;
            }
            else if (num % 3 == 0)
            {
                division = 3;
            }
            else if (num % 2 == 0)
            {
                division = 2;
            }

            if (division == -1)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {division}");
            }
        }
    }
}
