using System;
class AthleteRounds
{
    static void Main(string[] args)
    {
        double side1, side2, side3;
        Console.Write("Enter side1 (meters): ");
        side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side2 (meters): ");
        side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter side3 (meters): ");
        side3 = Convert.ToDouble(Console.ReadLine());

        double perimeter = side1 + side2 + side3;
        double distance = 5000; 
        double rounds = distance / perimeter;

        Console.WriteLine(
            "The total number of rounds the athlete will run is " + rounds +
            " to complete 5 km"
        );
    }
}
