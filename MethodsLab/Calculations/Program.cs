using System;

namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Calculation(calculation, number1, number2);
        }

        static void Calculation(string calculation, int number1, int number2)
        {
            int sum = 0;

            if (calculation == "add")
            {
                sum = number1 + number2;
            }
            else if (calculation == "multiply")
            {
                sum = number1 * number2;
            }
            else if (calculation == "subtract")
            {
                sum = number1 - number2;
            }
            else if (calculation == "divide")
            {
                sum = number1 / number2;
            }
            Console.WriteLine(sum);
        }
    }
}
