using System;

namespace NumsInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                nums[i] = number;   
            }

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Console.Write($"{nums[i]} ");
            } 
        }
    }
}
