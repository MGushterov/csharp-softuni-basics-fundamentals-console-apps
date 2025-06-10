using System;
using System.Linq;

namespace MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < elements.Length; i++)
            {
                int currNum = elements[i];
                for (int j = i; j < elements.Length - 1; j++)
                {
                    if (currNum + elements[j + 1] == magicNum)
                    {
                        Console.Write($"{currNum} {elements[j + 1]}\n");
                    }
                }
            }
        }
    }
}
