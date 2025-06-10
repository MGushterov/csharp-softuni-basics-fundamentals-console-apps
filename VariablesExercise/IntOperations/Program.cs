using System;

namespace IntOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());

            long operation1 = (long)n1 + n2;
            long operation2 = operation1 / n3;
            long operation3 = operation2 * n4;

            Console.WriteLine(operation3);
        }
    }
}
