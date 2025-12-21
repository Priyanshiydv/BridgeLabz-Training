using System;

class TriangleArea
{
    static void Main(string[] args)
    {
        double baseValue;
        double heightValue;
        Console.Write("Enter base in inches: ");
        baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height in inches: ");
        heightValue = Convert.ToDouble(Console.ReadLine());

        double areaInSquareInches = 0.5 * baseValue * heightValue;
        double areaInSquareCm = areaInSquareInches * 6.4516;
        Console.WriteLine(
            "The area of triangle in square inches is " + areaInSquareInches +
            " and in square centimeters is " + areaInSquareCm
        );
    }
}

