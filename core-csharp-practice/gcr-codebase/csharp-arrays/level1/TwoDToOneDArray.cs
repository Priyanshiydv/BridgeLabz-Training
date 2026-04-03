using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class TwoDToOneDArray
    {
        static void Main(string[] args)
        {
            // Take rows and columns input
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            // Create 2D array
            int[,] matrix = new int[rows, columns];

            // Take input for 2D array
            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Create 1D array
            int[] array = new int[rows * columns];
            int index = 0;

            // Copy elements from 2D to 1D
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }

            // Display 1D array
            Console.WriteLine("1D Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}


