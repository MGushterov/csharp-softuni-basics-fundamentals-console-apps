using System;

namespace RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lCount = int.Parse(Console.ReadLine());
            float headset = float.Parse(Console.ReadLine());
            float mouse = float.Parse(Console.ReadLine());
            float keyboard = float.Parse(Console.ReadLine());
            float display = float.Parse(Console.ReadLine());

            float newHeadsets = 0;
            float newMouses = 0;
            float newKeyboards = 0;
            float newDisplays = 0;

            for (int i = 1; i <= lCount; i++)
            {
                if (i % 12 == 0)
                {
                    newHeadsets++;
                    newMouses++;
                    newKeyboards++;
                    newDisplays++;
                }
                else if (i % 6 == 0)
                {
                    newHeadsets++;
                    newMouses++;
                    newKeyboards++;
                }
                else if (i % 2 == 0)
                {
                    newHeadsets++;
                }
                else if (i % 3 == 0)
                {
                    newMouses++;
                }
                
            }
            double finalSum = (newHeadsets * headset) + (newMouses * mouse) + (newKeyboards * keyboard) + (newDisplays * display);
            Console.WriteLine($"Rage expenses: {finalSum:f2} lv.");
        }
    }
}
