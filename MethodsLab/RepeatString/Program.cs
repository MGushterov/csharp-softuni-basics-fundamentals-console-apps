using System;
using System.Text;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repitions = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(text, repitions));
        }

        static string RepeatString(string text, int repitions)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < repitions; i++)
            {
                result.Append(text);
            }
            return result.ToString();
        }
    }
}
