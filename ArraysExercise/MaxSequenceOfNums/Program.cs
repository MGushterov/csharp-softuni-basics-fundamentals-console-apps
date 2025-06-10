using System;
using System.Linq;

namespace MaxSequenceOfNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] equalElements = new int[elements.Length];
            int biggestCounter = 0;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    int equalElement = elements[i];
                    int counterOfEqualElements = 0;
                    
                    for (int j = i; j < elements.Length; j++)
                    {
                        if (elements[j] != equalElement)
                        {
                            break;
                        }
                        counterOfEqualElements++;
                    }
                    if (counterOfEqualElements > biggestCounter)
                    {
                        for (int k = 0; k < counterOfEqualElements; k++)
                        {
                            equalElements[k] = equalElement;
                        }
                        biggestCounter = counterOfEqualElements;
                    } 
                }
            }

            for (int i = 0; i < biggestCounter; i++)
            {
                Console.Write($"{equalElements[i]} ");
            }
        }
    }
}
