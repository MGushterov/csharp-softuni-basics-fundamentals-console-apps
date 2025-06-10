using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = num; i > 0; i--)
            {
                int currDigit = num % 10;
                num /= 10;  
                sum += currDigit;
            }
            
            Console.WriteLine(sum);
        }
    }
}
