using System;

class Circle
{
    private double radius;

    public Circle() : this(1.0) { }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    static void Main()
    {
        Circle c = new Circle(5);
        Console.WriteLine("Area: " + c.CalculateArea());
    }
}
