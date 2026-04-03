using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class Friends
    {
        static void Main(string[] args)
        {
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] age = new int[3];
            double[] height = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter age of " + names[i] + ": ");
                age[i] = int.Parse(Console.ReadLine());

                Console.Write("Enter height of " + names[i] + ": ");
                height[i] = double.Parse(Console.ReadLine());
            }

            int youngestIndex = 0;
            int tallestIndex = 0;

            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngestIndex])
                    youngestIndex = i;

                if (height[i] > height[tallestIndex])
                    tallestIndex = i;
            }

            Console.WriteLine("Youngest Friend: " + names[youngestIndex]);
            Console.WriteLine("Tallest Friend: " + names[tallestIndex]);
        }
    }
}
