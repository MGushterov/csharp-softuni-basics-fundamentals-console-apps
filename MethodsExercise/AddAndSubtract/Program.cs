using System;

namespace AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            
            int output = SubtractThirdNumFromSum(number1, number2, number3);
            Console.WriteLine(output);
        }
        static int SubtractThirdNumFromSum(int number1, int number2, int number3)
        {
            int result = (number1 + number2) - number3;
            return result;
        }
    }
}
