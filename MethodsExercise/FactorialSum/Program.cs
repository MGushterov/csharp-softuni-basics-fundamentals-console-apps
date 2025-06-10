using System;

namespace FactorialSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());    
            
            double division = ReturnFactorialOfNumber(number1) / ReturnFactorialOfNumber(number2);
            Console.WriteLine($"{division:f2}");
        }
        static double ReturnFactorialOfNumber(int number)
        {
            double sum = 1;
            for (int i = number; i >= 1; i--)
            {
                sum *= i;   
            }
            return sum;
        }
       
    }
}
