using System;
using System.Linq;

namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengers = new int [n];
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
                
            }
            Console.Write(String.Join(" ", passengers));
            Console.WriteLine($"\n{sum}"); 
            
        }
    }
}
