using System;

class AthleteRound
{
    // Method to calculate rounds
    public static double CalculateRounds(double side1, double side2, double side3)
    {
        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000; // meters
        double rounds = totalDistance / perimeter;
        return rounds;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter side 1 (meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 (meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 (meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);

        Console.WriteLine("Number of rounds required: " + rounds);
    }
}
