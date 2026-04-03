using System;

// Superclass Vehicle
class Vehicle
{
    // Method to display vehicle info
    public virtual void DisplayInfo()
    {
        Console.WriteLine("This is a vehicle");
    }
}

// Car class inherits Vehicle
class Car : Vehicle
{
    // Overriding method
    public override void DisplayInfo()
    {
        Console.WriteLine("Car has seats");
    }
}

// Truck class inherits Vehicle
class Truck : Vehicle
{
    // Overriding method
    public override void DisplayInfo()
    {
        Console.WriteLine("Truck carries goods");
    }
}

// Motorcycle class inherits Vehicle
class Motorcycle : Vehicle
{
    // Overriding method
    public override void DisplayInfo()
    {
        Console.WriteLine("Motorcycle is a two wheeler");
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Creating Vehicle type objects
        Vehicle v1 = new Car();
        Vehicle v2 = new Truck();
        Vehicle v3 = new Motorcycle();

        // Calling method without using foreach loop
        v1.DisplayInfo();
        v2.DisplayInfo();
        v3.DisplayInfo();
    }
}
