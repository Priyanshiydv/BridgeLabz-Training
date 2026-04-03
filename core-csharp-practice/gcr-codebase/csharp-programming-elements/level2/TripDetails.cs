using System;
class TripDetails
{
    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter to city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from to via (miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter distance via to final city (miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time taken (hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;

        Console.WriteLine(
            "The results of the trip are: " +
            name + ", Total Distance = " + totalDistance +
            " miles, Time Taken = " + timeTaken + " hours"
        );
    }
}
