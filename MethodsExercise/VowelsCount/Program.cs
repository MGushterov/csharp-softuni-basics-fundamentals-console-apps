using System;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            DetermineAmountOfVowels(input);
        }

        static void DetermineAmountOfVowels(string input)
        {
            input = input.ToLower();
            int sumOfVowels = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                switch (currCh)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'u':
                    case 'i':
                        sumOfVowels++;
                        break;
                }
            }

            Console.WriteLine(sumOfVowels);
        }
    }
}
