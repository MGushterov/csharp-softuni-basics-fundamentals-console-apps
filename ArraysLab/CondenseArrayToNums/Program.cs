using System;
using System.Linq;

namespace CondenseArrayToNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] sumOfTwo = new int[elements.Length - 1];
            int sum = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (i != elements.Length - 1)
                {
                    sumOfTwo[i] = elements[i] + elements[i + 1];
                    sum += sumOfTwo[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
