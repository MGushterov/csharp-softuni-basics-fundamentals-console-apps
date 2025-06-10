using System;
using System.Linq;

namespace KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfDNA = int.Parse(Console.ReadLine());
            int longestSubsequenceOfOnes = -1;
            int leftmostIndex = -1;
            int highestSum = 0;
            int indexOfDNA = 0;
            int bestIndexOfDNA = 0;
            int[] bestDNA = new int [lengthOfDNA];

            string dnaOrCommand;
            while ((dnaOrCommand = Console.ReadLine()) != "Clone them!")
            {
                string[] currentDNA = dnaOrCommand
                    .Split('!', StringSplitOptions.RemoveEmptyEntries);
                int[] currentDNAToInt = currentDNA
                    .Select(int.Parse)
                    .ToArray();
                if (currentDNAToInt.Length != lengthOfDNA)
                {
                    continue;
                }
                int subsequence = 0;
                int sumOfOnes = 0;
                bool isFirstSubsequence = true;
                bool lengthMinusOneFirstTime = true;
                int initialIndex = -1;
                for (int i = 0; i < lengthOfDNA - 1; i++)
                {
                    if (currentDNAToInt[i] == 1)
                    {
                        sumOfOnes++;
                    }
                    if (currentDNAToInt[lengthOfDNA - 1] == 1 && lengthMinusOneFirstTime)
                    {
                        sumOfOnes++;
                        lengthMinusOneFirstTime = false;
                    }
                    if (currentDNAToInt[i] == 1 && currentDNAToInt[i + 1] == 1)
                    {
                        subsequence++;
                        if (isFirstSubsequence)
                        {
                            isFirstSubsequence = false;
                            initialIndex = i;
                        }
                    }
                }
                indexOfDNA++;
                if (subsequence > longestSubsequenceOfOnes)
                {
                    longestSubsequenceOfOnes = subsequence;
                    leftmostIndex = initialIndex;
                    highestSum = sumOfOnes;
                    bestIndexOfDNA = indexOfDNA;
                    for (int i = 0; i < currentDNAToInt.Length; i++)
                    {
                        bestDNA[i] = currentDNAToInt[i];
                    }
                }
                else if (subsequence == longestSubsequenceOfOnes)
                {
                    if (initialIndex < leftmostIndex)
                    {
                        longestSubsequenceOfOnes = subsequence;
                        leftmostIndex = initialIndex;
                        highestSum = sumOfOnes;
                        bestIndexOfDNA = indexOfDNA;
                        for (int i = 0; i < currentDNAToInt.Length; i++)
                        {
                            bestDNA[i] = currentDNAToInt[i];
                        }
                    }
                    else if (initialIndex == leftmostIndex)
                    {
                        if (sumOfOnes > highestSum)
                        {
                            longestSubsequenceOfOnes = subsequence;
                            leftmostIndex = initialIndex;
                            highestSum = sumOfOnes;
                            bestIndexOfDNA = indexOfDNA;
                            for (int i = 0; i < currentDNAToInt.Length; i++)
                            {
                                bestDNA[i] = currentDNAToInt[i];
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestIndexOfDNA} with sum: {highestSum}.");
            Console.WriteLine(String.Join(" ", bestDNA));
        }
    }
}
