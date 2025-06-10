using System;

namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            string[] dayOfTheWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            Console.WriteLine(dayOfTheWeek[n - 1]);
        }
    }
}
