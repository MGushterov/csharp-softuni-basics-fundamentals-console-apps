using System;
using System.Linq;

namespace EncryptSortPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sums = new int[n];

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                char[] lettersOfInput = input.ToCharArray();
                int sum = 0;
                for (int j = 0; j < lettersOfInput.Length; j++)
                {
                    int numericValueOfChar = (int)lettersOfInput[j];
                    if (lettersOfInput[j] == 'a' || lettersOfInput[j] == 'e' || lettersOfInput[j] == 'i' || lettersOfInput[j] == 'o' || lettersOfInput[j] == 'u' || lettersOfInput[j] == 'A' || lettersOfInput[j] == 'E' || lettersOfInput[j] == 'I' || lettersOfInput[j] == 'O' || lettersOfInput[j] == 'U')
                    {
                        sum += (numericValueOfChar * lettersOfInput.Length);
                    }
                    else
                    {
                        sum += (numericValueOfChar / lettersOfInput.Length);
                    }
                }
                sums[i] = sum;
            }
            for (int i = 0; i < sums.Length;)
            {
                int currNum = sums[i];
                bool numWasReplaced = false;
                for (int j = sums.Length - 1; j >= i; j--)
                {
                    if (currNum > sums[j])
                    {
                        int replacedNum = sums[j];
                        sums[j] = currNum;
                        sums[i] = replacedNum;
                        numWasReplaced = true;
                        break;
                    }
                }
                if (numWasReplaced == false)
                {
                    i++;
                }
            }
            Console.Write(String.Join("\n", sums));
        }
    }
}
