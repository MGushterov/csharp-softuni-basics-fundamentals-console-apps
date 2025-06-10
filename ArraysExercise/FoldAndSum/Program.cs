using System;
using System.Linq;

namespace FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unwrappedNums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int k = unwrappedNums.Length / 4;
            int[] firstAndLastNums = new int[2 * k];
            int[] middleNums = new int[2 * k];
            bool firstTimeEntering = true;

            for (int i = 0; i < 2 * k;)
            {
                bool hasEnteredIf = false;
                if (i == k && firstTimeEntering == true)
                {
                    firstTimeEntering = false;
                    hasEnteredIf = true;
                    for (int j = 0; j < 2 * k; j++)
                    {
                        middleNums[j] = unwrappedNums[j + k];
                    }
                }
                if (hasEnteredIf == false)
                {
                    if (i == k)
                    {
                        int counter = i;
                        for (int j = (unwrappedNums.Length - 1) - k;
                            j < unwrappedNums.Length - 1; j++)
                        {
                            firstAndLastNums[counter] = unwrappedNums[j + 1];
                            counter++;
                        }
                    }
                    else if (i < k)
                    {
                        firstAndLastNums[i] = unwrappedNums[i];
                    }
                    i++;
                }
            }
            int[] firstNums = new int[k];
            for (int i = 0; i < k; i++)
            {
                firstNums[i] = firstAndLastNums[i];
            }
            Array.Reverse(firstNums);

            Array.Reverse(unwrappedNums);
            int[] lastNums = new int[k];
            for (int i = 0; i < k; i++)
            {
                lastNums[i] = unwrappedNums[i];
            }

            for (int i = 0; i < 2 * k;)
            {
                int sum = 0;
                if (i == k)
                {
                    for (int j = 0; j < k; j++)
                    {
                        sum = lastNums[j] + middleNums[i];
                        Console.Write($"{sum} ");
                        i++;
                    }
                }
                else
                {
                    sum = firstNums[i] + middleNums[i];
                    Console.Write($"{sum} ");
                    i++;
                }
            }
        }
    }
}
