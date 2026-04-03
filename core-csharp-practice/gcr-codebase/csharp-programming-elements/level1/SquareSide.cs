using System;
class SquareSide
{
    static void Main(string[] args)
    {
        double perimeter;
        Console.Write("Enter the perimeter of the square: ");
        perimeter = Convert.ToDouble(Console.ReadLine());

        double side = perimeter / 4;
        Console.WriteLine(
            "The length of the side is " + side + " whose perimeter is " + perimeter
        );
    }
}
