using System;

namespace TriplesOfLatinNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 97; i < 97 + n; i++)
            {
                char ch1 = (char)i;
                for (int j = 97; j < 97 + n; j++)
                {
                    char ch2 = (char)j; 
                    for (int k = 97; k < 97 + n; k++)
                    {
                        char ch3 = (char)k;
                        Console.WriteLine($"{ch1}{ch2}{ch3}");
                    }
                }
            }
        }
    }
}
