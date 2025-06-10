using System;
using System.Linq;
using System.Text;

namespace MiddleChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArray = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputArray[i] = input[i];
            }

            ReturnMiddleChar(inputArray);
        }
        static void ReturnMiddleChar(char[] inputArray)
        {
            if (ReturnMiddleCharWithLengthOdd(inputArray))
            {
                Console.WriteLine(inputArray[(inputArray.Length - 1) / 2]);
            }
            if (ReturnMiddleCharWithLengthEven(inputArray))
            {
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (i == (inputArray.Length - 1) / 2)
                    {
                        Console.Write(inputArray[i]);
                    }
                    if (i == ((inputArray.Length - 1) / 2) + 1)
                    {
                        Console.Write(inputArray[i]);
                    }
                }
            }
        }
        static bool ReturnMiddleCharWithLengthOdd(char[] inputArray)
        {
            if (inputArray.Length % 2 != 0)
            {
                return true;
            }
            return false;
        }
        static bool ReturnMiddleCharWithLengthEven(char[] inputArray)
        {
            if (inputArray.Length % 2 == 0)
            {
                
                return true;               
            }
            return false;
        }
    }
}
