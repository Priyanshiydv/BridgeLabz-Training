using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class BMIMultiArray
    {
        static void Main(string[] args)
        {
            // Take input for number of persons
            Console.Write("Enter number of persons: ");
            int number = int.Parse(Console.ReadLine());

            // Create 2D array: rows = number of persons, columns = 3 (weight, height, BMI)
            double[,] personData = new double[number, 3];
            string[] weightStatus = new string[number];

            // Input weight and height
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));

                // Input weight
                while (true)
                {
                    Console.Write("Enter weight (kg): ");
                    personData[i, 0] = double.Parse(Console.ReadLine());
                    if (personData[i, 0] > 0) break;
                    else Console.WriteLine("Invalid input. Enter positive weight.");
                }

                // Input height
                while (true)
                {
                    Console.Write("Enter height (meters): ");
                    personData[i, 1] = double.Parse(Console.ReadLine());
                    if (personData[i, 1] > 0) break;
                    else Console.WriteLine("Invalid input. Enter positive height.");
                }

                // Calculate BMI and store in 2D array
                personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);

                // Determine weight status
                double bmi = personData[i, 2];
                if (bmi <= 18.4)
                    weightStatus[i] = "Underweight";
                else if (bmi >= 18.5 && bmi <= 24.9)
                    weightStatus[i] = "Normal";
                else if (bmi >= 25.0 && bmi <= 39.9)
                    weightStatus[i] = "Overweight";
                else
                    weightStatus[i] = "Obese";
            }

            // Display the results
            Console.WriteLine("\n--- BMI REPORT ---");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("\nPerson " + (i + 1));
                Console.WriteLine("Weight: " + personData[i, 0] + " kg");
                Console.WriteLine("Height: " + personData[i, 1] + " m");
                Console.WriteLine("BMI: " + personData[i, 2]);
                Console.WriteLine("Status: " + weightStatus[i]);
            }
        }
    }

}
