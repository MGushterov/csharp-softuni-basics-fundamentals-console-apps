using System;

namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            GradeEvaluation(number);
        }

        static void GradeEvaluation(double grade)
        {
            string evaluationInWords = string.Empty;

            if (grade >= 2.00 && grade <= 2.99)
            {
                evaluationInWords = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                evaluationInWords = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                evaluationInWords = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                evaluationInWords = "Very good";
            }
            else
            {
                evaluationInWords = "Excellent";
            }
            Console.WriteLine(evaluationInWords);
        }
    }
}
