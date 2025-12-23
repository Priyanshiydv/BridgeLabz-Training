using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class MeanHeightOfPlayers
    {
        static void Main(string[] args)
        {
            // Create array to store heights of 11 players
            double[] heights = new double[11];

            double sum = 0.0;

            // Take input for heights
            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write("Enter height of player " + (i + 1) + ": ");
                heights[i] = double.Parse(Console.ReadLine());
            }

            // Calculate sum of heights
            for (int i = 0; i < heights.Length; i++)
            {
                sum = sum + heights[i];
            }

            // Calculate mean height
            double mean = sum / heights.Length;

            // Display mean height
            Console.WriteLine("Mean Height of Football Team: " + mean);
        }
    }
}
