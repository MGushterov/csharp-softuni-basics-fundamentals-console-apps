using System;

namespace PadawnEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float priceOfLightsaber = float.Parse(Console.ReadLine());
            float priceOfRobe = float.Parse(Console.ReadLine());
            float priceOfBelt = float.Parse(Console.ReadLine());

            double studentsLightsabers = Math.Ceiling(students * 1.10);
            double lightsaberSum = priceOfLightsaber * studentsLightsabers;

            double totalSum = 0;
            if (students >= 6)
            {
                int studentsBelts = students / 6;
                double totalBelts = students - studentsBelts;
                double beltSum = totalBelts * priceOfBelt;
                totalSum = lightsaberSum + beltSum + (students * priceOfRobe);
            }
            else
            {
                totalSum = lightsaberSum + (students * priceOfBelt) + (students * priceOfRobe);

            }

            if (totalSum <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:f2}lv.");
            }
            else
            {
                double diff = amountOfMoney - totalSum;
                Console.WriteLine($"John will need {Math.Abs(diff):f2}lv more.");
            }
        }
    }
}
