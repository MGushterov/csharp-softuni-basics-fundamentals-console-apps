using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] previousOutput = new int[rows];

            for (int i = 1; i <= rows; i++)
            {
                int columns = i;
                int[] outputOnSingleLine = new int[i];

                for (int j = 1; j <= columns; j++)
                {
                    int num = 0;
                    if (j - 1 == 0)
                    {
                        outputOnSingleLine[0] = 1;
                    }
                    else if (columns == j)
                    {
                        outputOnSingleLine[columns - 1] = 1;
                    }
                    else
                    {
                        for (int l = 0; l < j - 1; l++)
                        {
                            num = previousOutput[l] + previousOutput[l + 1];
                            outputOnSingleLine[j - 1] = num;
                        }
                    }
                }
                for (int k = 0; k < columns; k++)
                {
                    previousOutput[k] = outputOnSingleLine[k];
                }
                Console.WriteLine(string.Join(" ", outputOnSingleLine));
            }
        }
    }
}
