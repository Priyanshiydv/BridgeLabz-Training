using System;

public class AreaOfCircle
{
    // Private field
    private double radius;

    // Constructor
    public AreaOfCircle(double radius)
    {
        this.radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    // Method to display results
    public void DisplayDetails()
    {
        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("Area: " + CalculateArea());
        Console.WriteLine("Circumference: " + CalculateCircumference());
    }
}

public class Program
{
    public static void Main()
    {
        // Creating Circle object
        AreaOfCircle circle = new AreaOfCircle(10);

        // Displaying circle details
        circle.DisplayDetails();
    }
}
