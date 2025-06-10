using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfPeople = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceOfOneTicket = -1;
            double sum = -1;

            if (dayOfWeek == "Friday")
            {
                switch (group)
                {
                    case "Students": priceOfOneTicket = 8.45; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 30)
                        {
                            sum *= 0.85;
                        }
                        break;
                    case "Business": priceOfOneTicket = 10.90; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 100)
                        {
                            sum -= 10 * priceOfOneTicket;
                        }
                        break;
                    case "Regular": priceOfOneTicket = 15; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 10 && amountOfPeople <= 20)
                        {
                            sum *= 0.95;
                        }
                        break;
                    
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (group)
                {
                    case "Students": priceOfOneTicket = 9.80; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 30)
                        {
                            sum *= 0.85;
                        }
                        break;
                    case "Business": priceOfOneTicket = 15.60; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 100)
                        {
                            sum -= 10 * priceOfOneTicket;
                        }
                        break;
                    case "Regular": priceOfOneTicket = 20; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 10 && amountOfPeople <= 20)
                        {
                            sum *= 0.95;
                        }
                        break;

                }
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (group)
                {
                    case "Students": priceOfOneTicket = 10.46; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 30)
                        {
                            sum *= 0.85;
                        }
                        break;
                    case "Business": priceOfOneTicket = 16; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 100)
                        {
                            sum -= 10 * priceOfOneTicket;
                        }
                        break;
                    case "Regular": priceOfOneTicket = 22.50; sum = amountOfPeople * priceOfOneTicket;
                        if (amountOfPeople >= 10 && amountOfPeople <= 20)
                        {
                            sum *= 0.95;
                        }
                        break;

                }
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
