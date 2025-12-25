using System;

class CollinearPoints
{
    // Method using Slope Formula
    public static bool CheckCollinearBySlope(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double left = (y2 - y1) * (x3 - x2);
        double right = (y3 - y2) * (x2 - x1);

        if (left == right)
            return true;
        else
            return false;
    }

    // Method using Area of Triangle Formula
    public static bool CheckCollinearByArea(
        double x1, double y1,
        double x2, double y2,
        double x3, double y3)
    {
        double area = 0.5 * (
            x1 * (y2 - y3) +
            x2 * (y3 - y1) +
            x3 * (y1 - y2)
        );

        if (area == 0)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        // Taking user input
        Console.Write("Enter x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        // Slope Formula Check
        if (CheckCollinearBySlope(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("Points are Collinear using Slope Formula");
        else
            Console.WriteLine("Points are NOT Collinear using Slope Formula");

        // Area Formula Check
        if (CheckCollinearByArea(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("Points are Collinear using Area Formula");
        else
            Console.WriteLine("Points are NOT Collinear using Area Formula");
    }
}
