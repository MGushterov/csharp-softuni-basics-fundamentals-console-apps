using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;
            if (people < capacity)
            {
                courses++;
            }
            else if (people % capacity == 0)
            {
                courses = people / capacity;
            }
            else
            {
                courses = people / capacity;
                courses++;
            }

            Console.WriteLine(courses);
        }
    }
}
