using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FizzBuzzProgram
    {
        static void Main(string[] args)
        {
            // Take input number
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());

            // Validate input
            if (number <= 0)
            {
                Console.Error.WriteLine("Invalid input.");
                Environment.Exit(0);
            }

            // Create string array
            string[] results = new string[number + 1];

            // Store FizzBuzz results
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    results[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    results[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    results[i] = "Buzz";
                }
                else
                {
                    results[i] = i.ToString();
                }
            }

            // Display results
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Position " + i + " = " + results[i]);
            }
        }
    }
}
