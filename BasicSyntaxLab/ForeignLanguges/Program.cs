﻿using System;

namespace ForeignLanguges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England": Console.WriteLine("English"); break;
                case "Spain":
                case "Mexico":
                case "Argentina": Console.WriteLine("Spanish"); break;
                default: Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
