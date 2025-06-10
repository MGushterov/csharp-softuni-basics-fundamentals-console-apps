using System;

namespace RoundNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbersString = Console.ReadLine().Split(' ');
            double[] numbers = new double[numbersString.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(numbersString[i]);
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
