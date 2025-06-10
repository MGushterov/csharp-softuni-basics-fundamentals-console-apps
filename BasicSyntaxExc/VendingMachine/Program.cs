using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            string money = Console.ReadLine();
            double coinSum = 0;
            
            while (money != "Start")
            {
                double coin = double.Parse(money);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    coinSum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                money = Console.ReadLine();
            }
            string product = Console.ReadLine();
            
            while (product != "End")
            {
                product = product.ToLower();
                switch (product)
                {
                    case "nuts": coinSum -= 2.0;
                        if (coinSum >= 0)
                        {
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            coinSum += 2.0;
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "water": coinSum -= 0.7;
                        if (coinSum >= 0)
                        {
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            coinSum += 0.7;
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "crisps": coinSum -= 1.5;
                        if (coinSum >= 0)
                        {
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            coinSum += 1.5;
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "soda": coinSum -= 0.8;
                        if (coinSum >= 0)
                        {
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            coinSum += 0.8;
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "coke": coinSum -= 1.0;
                        if (coinSum >= 0)
                        {
                            Console.WriteLine($"Purchased {product}");
                        }
                        else
                        {
                            coinSum += 1.0;
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default: Console.WriteLine("Invalid product"); break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coinSum:f2}");
        }
    }
}
