using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//22/12/2025
namespace BridgeLabzTraining.arrays.level1
{
    internal class SumOfDigits
    {
        public static void Main(string[] args)
        {  
            // Take input for a number
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            // Validate the input
            if (n < 0)
            {
                Console.Error.WriteLine("Invalid Number.");
                Environment.Exit(0);
            }

            // Handle zero
            if (n == 0)
            {
                Console.WriteLine("Sum of Digits: 0");
                Environment.Exit(0);
            }

            // Find the count of digits
            int temp = n;
            int count = 0;

            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }

            // Create array to store digits
            int[] digits = new int[count];

            // Store digits in array
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = n % 10;
                n = n / 10;
            }

            // Calculate sum of digits
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum = sum + digits[i];
            }

            // Display the sum
            Console.WriteLine("Sum of Digits: " + sum);
        }
    }

}
 