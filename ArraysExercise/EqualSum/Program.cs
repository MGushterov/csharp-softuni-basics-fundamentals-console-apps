using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int equalIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    
                    leftSum += nums [j];
                }
                for (int k = nums.Length - 1; k > i; k--)
                {
                    
                    rightSum += nums[k];
                }
                bool areEqual = false;
                if (leftSum == rightSum)
                {
                    areEqual = true;
                    equalIndex = i;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (equalIndex == -1)
            {
                Console.WriteLine("no");
            }
        }
    }
}
