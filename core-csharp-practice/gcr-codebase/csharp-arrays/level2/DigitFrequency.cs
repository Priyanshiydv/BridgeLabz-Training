using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class DigitFrequency
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine(); // Read number as string

            int[] frequency = new int[10]; // Frequency array for digits 0-9

            foreach (char c in number)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0'; // Convert char to int
                    frequency[digit]++;
                }
            }

            Console.WriteLine("\nDigit Frequencies:");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                    Console.WriteLine($"Digit {i}: {frequency[i]} times");
            }
        }
    }
}
