using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.arrays.level1
{
    //23/12/2025
    internal class VotingEligibility
    {
        static void Main(string[] args)
        {
            // Create an array to store ages of 10 students
            int[] ages = new int[10];

            // Take input for students' ages
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write("Enter age of student " + (i + 1) + ": ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            // Check voting eligibility
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine("Invalid age.");
                }
                else if (ages[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + ages[i] + " can vote.");
                }
                else
                {
                    Console.WriteLine("The student with the age " + ages[i] + " cannot vote.");
                }
            }
        }
    }
}
