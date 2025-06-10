using System;

namespace LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());
            string letterToBeInspected = letter.ToString();
            string upper = letterToBeInspected.ToUpper();   
            string lower = letterToBeInspected.ToLower();
            if (letterToBeInspected == upper)
            {
                Console.WriteLine("upper-case");
            }
            else if (letterToBeInspected == lower)
            {
                Console.WriteLine("lower-case");
            }

        }
    }
}
