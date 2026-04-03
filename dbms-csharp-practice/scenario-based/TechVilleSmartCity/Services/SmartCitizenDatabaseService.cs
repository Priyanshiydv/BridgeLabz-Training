using System;

namespace TechVilleSmartCity.Services
{
    public class SmartCitizenDatabaseService
    {
        public void StartDatabase()
        {
            Console.WriteLine("\n=== Module 3: Smart Citizen Database ===");

            // 1️ Single-Dimensional Array (Citizen IDs)
            int[] citizenIds = new int[10];

            Console.WriteLine("\nEnter 10 Citizen IDs:");

            for (int i = 0; i < citizenIds.Length; i++)
            {
                Console.Write($"Citizen {i + 1} ID: ");
                citizenIds[i] = Convert.ToInt32(Console.ReadLine());
            }

            // 2️ Sorting Array
            Array.Sort(citizenIds);
            Console.WriteLine("\nSorted Citizen IDs:");
            foreach (int id in citizenIds)
            {
                Console.Write(id + " ");
            }

            // 3️ Searching
            Console.Write("\n\nEnter ID to search: ");
            int searchId = Convert.ToInt32(Console.ReadLine());

            int index = Array.BinarySearch(citizenIds, searchId);

            if (index >= 0)
                Console.WriteLine("Citizen Found!");
            else
                Console.WriteLine("Citizen Not Found!");

            // 4️ Copying Array
            int[] copiedIds = new int[citizenIds.Length];
            Array.Copy(citizenIds, copiedIds, citizenIds.Length);

            Console.WriteLine("\nCopied Array:");
            foreach (int id in copiedIds)
            {
                Console.Write(id + " ");
            }

            // 5 Multi-Dimensional Array (Zones & Sectors)
            Console.WriteLine("\n\n=== Zone & Sector Citizen Count ===");

            int[,] zones = new int[5, 3]; // 5 Zones, 3 Sectors each

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter citizen count for Zone {i + 1}, Sector {j + 1}: ");
                    zones[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nZone-Wise Citizen Distribution:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Zone {i + 1}: ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(zones[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
