using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class FactorsOfNumber
    {
        static void Main(string[] args)
        {
            // Take input number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Validate input
            if (number <= 0)
            {
                Console.Error.WriteLine("Invalid input.");
                Environment.Exit(0);
            }

            // Initialize array size and index
            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;

            // Find factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    // Increase array size if full
                    if (index == maxFactor)
                    {
                        maxFactor = maxFactor * 2;
                        int[] temp = new int[maxFactor];

                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }

                        factors = temp;
                    }

                    factors[index] = i;
                    index++;
                }
            }

            // Display factors
            Console.WriteLine("Factors of the number:");
            for (int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }
        }
    }
}
