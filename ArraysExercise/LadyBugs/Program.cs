using System;
using System.Linq;

namespace LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfTheField = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[sizeOfTheField];

            //generating field
            for (int i = 0; i < sizeOfTheField; i++)
            {
                for (int j = 0; j < initialIndexes.Length; j++)
                {
                    if (i == initialIndexes[j])
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int initialPosition = int.Parse(commandArgs[0]);
                string direction = commandArgs[1];
                int flyLength = int.Parse(commandArgs[2]);

                if (initialPosition < 0 || initialPosition > sizeOfTheField - 1)
                {
                    continue;
                }
                if (field[initialPosition] == 0)
                {
                    continue;
                }
                int landingSpot = 0;
                field[initialPosition] = 0;
                if (direction == "right")
                {
                    landingSpot = initialPosition + flyLength;
                    while (true)
                    {
                        if (landingSpot < 0 || landingSpot > sizeOfTheField - 1)
                        {
                            break;
                        }
                        if (field[landingSpot] == 0)
                        {
                            field[landingSpot] = 1;
                            break;
                        }
                        landingSpot += flyLength;
                    }
                }
                if (direction == "left")
                {
                    landingSpot = initialPosition - flyLength;
                    while (true)
                    {
                        if (landingSpot < 0 || landingSpot > sizeOfTheField - 1)
                        {
                            break;
                        }
                        if (field[landingSpot] == 0)
                        {
                            field[landingSpot] = 1;
                            break;
                        }
                        landingSpot -= flyLength;
                    }
                }
            }

            for (int i = 0; i < sizeOfTheField; i++)
            {
                Console.Write($"{field[i]} ");
            }
        }
    }
}
