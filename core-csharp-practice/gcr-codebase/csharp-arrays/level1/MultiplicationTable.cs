using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MultiplicationTable
    {
        static void Main(string[] args)
        {
            // Take input number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // Create array to store multiplication results
            int[] table = new int[10];

            // Store multiplication values
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = number * (i + 1);
            }

            // Display multiplication table
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
            }
        }
    }

}
