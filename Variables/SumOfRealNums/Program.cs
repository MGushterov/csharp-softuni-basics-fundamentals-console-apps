﻿using System;
using System.Numerics;

namespace SumOfRealNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = (decimal)0;
           
            for (int i = 0; i < n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            
            Console.WriteLine(sum);
        }
    }
}
