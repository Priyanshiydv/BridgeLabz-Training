using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class StoreNumbersAndSum
    {
        static void Main(string[] args)
        {
            // Create array of size 10
            double[] numbers = new double[10];

            // Initialize total and index
            double total = 0.0;
            int index = 0;

            // Infinite loop to take input
            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double value = double.Parse(Console.ReadLine());

                // Stop if value is 0 or negative
                if (value <= 0)
                {
                    break;
                }

                // Stop if array is full
                if (index == numbers.Length)
                {
                    break;
                }

                // Store value in array
                numbers[index] = value;
                index++;
            }

            // Display stored numbers and calculate sum
            Console.WriteLine("Stored Numbers:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total = total + numbers[i];
            }

            // Display total sum
            Console.WriteLine("Total Sum: " + total);
        }
    }

}
