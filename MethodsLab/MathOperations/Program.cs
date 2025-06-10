using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());    
            Console.WriteLine(Calculate(number1, @operator, number2));
        }

        static double Calculate(int num1, char @operator, int num2)
        {
            double result = 0;

            switch (@operator)
            {
                case '*': result = num1 * num2; break;
                case '/': result = num1 / num2; break;
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
            }
            
            return result;
        }
    }
}
