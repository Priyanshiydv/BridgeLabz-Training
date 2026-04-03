using System;

class GeometryProgram
{
    // Euclidean Distance
    public static double FindDistance(double x1, double y1, double x2, double y2)
    {
        double distance = Math.Sqrt(
            Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)
        );
        return distance;
    }

    // Find Slope and Intercept
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;

        double[] result = new double[2];
        result[0] = m;
        result[1] = b;

        return result;
    }

    static void Main()
    {
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = FindDistance(x1, y1, x2, y2);
        Console.WriteLine("Euclidean Distance: " + distance);

        double[] line = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine("Equation of Line: y = " + line[0] + "x + " + line[1]);
    }
}
