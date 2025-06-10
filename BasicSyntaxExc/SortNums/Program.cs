using System;

namespace SortNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            double biggestNum = -1;
            double middleNum = -1;
            double smallestNum = -1;

            if (n1 > n2 && n1 > n3)
            {
                biggestNum = n1;
                if (n2 > n3)
                {
                    middleNum = n2;
                    smallestNum = n3;
                }
                else 
                {
                    middleNum = n3;
                    smallestNum = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                biggestNum = n2;
                if (n1 > n3)
                {
                    middleNum = n1;
                    smallestNum = n3;
                }
                else
                {
                    middleNum = n3;
                    smallestNum = n1;
                }    
            }
            else if (n3 > n1 && n3 > n2)
            {
                biggestNum = n3;
                if (n1 > n2)
                {
                    middleNum = n1;
                    smallestNum = n2;
                }
                else 
                {
                    middleNum = n2;
                    smallestNum = n1;
                }
            }
            Console.Write($"{biggestNum}\n{middleNum}\n{smallestNum}");
        }
    }
}
