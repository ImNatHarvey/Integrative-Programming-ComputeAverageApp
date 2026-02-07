using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverageApp
{
    internal class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            // Title and Header
            Console.WriteLine("--- Enter 5 Grades ---");

            // Manually reading each grade with specific prompts
            Console.Write("Enter grade 1: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 2: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 3: ");
            double grade3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 4: ");
            double grade4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade 5: ");
            double grade5 = Convert.ToDouble(Console.ReadLine());

            double sum = grade1 + grade2 + grade3 + grade4 + grade5;

            double average = sum / 5;

            double roundedAverage = Math.Round(average);

            // Final output formatted as requested
            Console.WriteLine("The average is: " + average + " and round off to " + roundedAverage);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}