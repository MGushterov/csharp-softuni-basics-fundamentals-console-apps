using System;

namespace SpecialNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currNum = i;
                int sum = 0;
               
                while (currNum != 0)
                {
                    int aditiveNum = currNum % 10;
                    sum += aditiveNum;
                    currNum /= 10;
                    
                }
                bool isDivisible = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isDivisible}");
            }
        }
    }
}
