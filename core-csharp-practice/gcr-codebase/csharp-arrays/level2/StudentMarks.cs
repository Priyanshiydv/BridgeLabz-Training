using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.arrays.level2
{
    internal class StudentMarks
    {
        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            double[,] marks = new double[n, 3]; // 3 subjects: Physics, Chemistry, Maths
            double[] percentages = new double[n];
            string[] grades = new string[n];

            // Input marks
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}:");

                Console.Write("Physics: ");
                marks[i, 0] = double.Parse(Console.ReadLine());

                Console.Write("Chemistry: ");
                marks[i, 1] = double.Parse(Console.ReadLine());

                Console.Write("Maths: ");
                marks[i, 2] = double.Parse(Console.ReadLine());
            }

            // Calculate percentage and grade
            for (int i = 0; i < n; i++)
            {
                percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                if (percentages[i] >= 90)
                    grades[i] = "A";
                else if (percentages[i] >= 80)
                    grades[i] = "B";
                else if (percentages[i] >= 70)
                    grades[i] = "C";
                else if (percentages[i] >= 60)
                    grades[i] = "D";
                else
                    grades[i] = "F";
            }

            // Display results
            Console.WriteLine("\nResults:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Student {i + 1}: Percentage = {percentages[i]:F2}%, Grade = {grades[i]}");
            }
        }
    }
}