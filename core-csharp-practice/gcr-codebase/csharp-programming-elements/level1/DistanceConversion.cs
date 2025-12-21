using System;
class DistanceConversion
{
    static void Main(string[] args)
    {
        double distanceInFeet;
        Console.Write("Enter distance in feet: ");
        distanceInFeet = Convert.ToDouble(Console.ReadLine());

        double yards = distanceInFeet / 3;
        double miles = yards / 1760;

        Console.WriteLine(
            "The distance in feet is " + distanceInFeet +
            ", in yards is " + yards +
            " and in miles is " + miles
        );
    }
}
