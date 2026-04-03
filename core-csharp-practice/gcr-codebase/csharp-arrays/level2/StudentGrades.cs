using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class StudentGrades
    {
        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            double[,] marks = new double[n, 3]; // 2D array for Physics, Chemistry, Maths
            double[] percentages = new double[n];
            string[] grades = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEnter marks for Student {i + 1}:");

                for (int j = 0; j < 3; j++)
                {
                    string subject = j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths";

                    while (true)
                    {
                        Console.Write($"{subject}: ");
                        double mark = double.Parse(Console.ReadLine());

                        if (mark >= 0)
                        {
                            marks[i, j] = mark;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Marks cannot be negative. Please enter again.");
                        }
                    }
                }

                // Calculate percentage
                percentages[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

                // Determine grade
                if (percentages[i] >= 80)
                    grades[i] = "A";
                else if (percentages[i] >= 70)
                    grades[i] = "B";
                else if (percentages[i] >= 60)
                    grades[i] = "C";
                else if (percentages[i] >= 50)
                    grades[i] = "D";
                else if (percentages[i] >= 40)
                    grades[i] = "E";
                else
                    grades[i] = "R";
            }

            // Display results
            Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tPercentage\tGrade");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}\t");
                Console.Write($"{marks[i, 0]}\t{marks[i, 1]}\t\t{marks[i, 2]}\t");
                Console.Write($"{percentages[i]:F2}\t\t{grades[i]}");
                Console.WriteLine();
            }
        }
    }
}

