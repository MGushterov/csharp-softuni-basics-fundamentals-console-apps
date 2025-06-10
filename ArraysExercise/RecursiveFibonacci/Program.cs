using System;

namespace RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fib = new int[n];
            fib[0] = 1; 

            if (n >= 2)
            {
                fib[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }
            }
           
            Console.WriteLine(fib[n - 1]);
        }
    }
}
