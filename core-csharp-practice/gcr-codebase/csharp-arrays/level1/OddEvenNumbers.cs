using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class OddEvenNumbers
    {
        static void Main(string[] args)
        {
            // Take input number
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            // Validate natural number
            if (number <= 0)
            {
                Console.Error.WriteLine("Invalid input. Please enter a natural number.");
                Environment.Exit(0);
            }

            // Create arrays for odd and even numbers
            int[] oddNumbers = new int[number / 2 + 1];
            int[] evenNumbers = new int[number / 2 + 1];

            // Index variables
            int oddIndex = 0;
            int evenIndex = 0;

            // Loop from 1 to number
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            // Print odd numbers
            Console.WriteLine("Odd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(oddNumbers[i] + " ");
            }

            Console.WriteLine();

            // Print even numbers
            Console.WriteLine("Even Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(evenNumbers[i] + " ");
            }
        }
    }
}

