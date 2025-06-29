﻿using System;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintPriceOfOrder(product, quantity);
        }

        static void PrintPriceOfOrder(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee": price = quantity * 1.50; break;                  
                case "water": price = quantity * 1.00; break;
                case "coke": price = quantity * 1.40; break;
                case "snacks": price = quantity * 2.00; break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
