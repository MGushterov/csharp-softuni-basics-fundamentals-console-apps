using System;

namespace EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numsString = Console.ReadLine().Split();
            int[] nums = new int[numsString.Length];
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numsString.Length; i++)
            {
                nums[i] = int.Parse(numsString[i]);
                
                if (nums[i] % 2 == 0)
                {
                    evenSum += nums[i];
                }
                else
                {
                    oddSum += nums[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);    
        }
    }
}
