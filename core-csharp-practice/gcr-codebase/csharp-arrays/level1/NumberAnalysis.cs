using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    internal class NumberAnalysis
    {
        static void Main(string[] args)
        {
            // Create an array of 5 integers
            int[] numbers = new int[5];

            // Take user input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Check each number
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine(numbers[i] + " is Positive Even");
                    }
                    else
                    {
                        Console.WriteLine(numbers[i] + " is Positive Odd");
                    }
                }
                else if (numbers[i] < 0)
                {
                    Console.WriteLine(numbers[i] + " is Negative");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is Zero");
                }
            }

            // Compare first and last element
            if (numbers[0] == numbers[numbers.Length - 1])
            {
                Console.WriteLine("First and Last elements are Equal");
            }
            else if (numbers[0] > numbers[numbers.Length - 1])
            {
                Console.WriteLine("First element is Greater than Last element");
            }
            else
            {
                Console.WriteLine("Last element is Greater than First element");
            }
        }
    }

}
