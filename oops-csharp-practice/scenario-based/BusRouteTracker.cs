using System;

class BusRouteTracker
{
    static void Main()
    {
        int totalDistance = 0;
        string choice = "yes";

        Console.WriteLine("Bus Route Distance Tracker");

        // Loop continues until passenger wants to get off
        while (choice == "yes")
        {
            Console.WriteLine("Enter distance covered to next stop (in km):");
            int distance = int.Parse(Console.ReadLine());

            // Add distance to total
            totalDistance = totalDistance + distance;

            Console.WriteLine("Total distance so far: " + totalDistance + " km");

            Console.WriteLine("Do you want to get off at this stop? (yes/no)");
            choice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Passenger got off.");
        Console.WriteLine("Total distance travelled: " + totalDistance + " km");
    }
}
