using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultiplicationTableSixToNine
    {
        static void Main(string[] args)
        {
            // Take input number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Create array to store results
            int[] multiplicationResult = new int[4];

            int index = 0;

            // Store multiplication values from 6 to 9
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[index] = number * i;
                index++;
            }

            // Display multiplication table
            index = 0;
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationResult[index]);
                index++;
            }
        }
    }
}
