using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BMIProgram
    {
        static void Main(string[] args)
        {
            // Take number of persons
            Console.Write("Enter number of persons: ");
            int n = int.Parse(Console.ReadLine());

            // Create arrays
            double[] weight = new double[n];
            double[] height = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            // Take input for weight and height
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));

                Console.Write("Enter weight (kg): ");
                weight[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter height (meters): ");
                height[i] = double.Parse(Console.ReadLine());

                // Calculate BMI
                bmi[i] = weight[i] / (height[i] * height[i]);

                // Find status using BMI table
                if (bmi[i] <= 18.4)
                {
                    status[i] = "Underweight";
                }
                else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
                {
                    status[i] = "Normal";
                }
                else if (bmi[i] >= 25.0 && bmi[i] <= 39.9)
                {
                    status[i] = "Overweight";
                }
                else
                {
                    status[i] = "Obese";
                }
            }

            // Display result
            Console.WriteLine("\n--- BMI REPORT ---");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));
                Console.WriteLine("Height: " + height[i]);
                Console.WriteLine("Weight: " + weight[i]);
                Console.WriteLine("BMI: " + bmi[i]);
                Console.WriteLine("Status: " + status[i]);
            }
        }
    }

}
