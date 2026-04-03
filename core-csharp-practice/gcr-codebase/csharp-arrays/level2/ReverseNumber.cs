using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level2
{
    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int count = 0;

            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }

            int[] digits = new int[count];

            for (int i = 0; i < count; i++)
            {
                digits[i] = number % 10;
                number = number / 10;
            }

            Console.Write("Reversed Number: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(digits[i]);
            }
        }
    }
}
