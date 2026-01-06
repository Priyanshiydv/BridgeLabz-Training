using System;

// Interface for rent calculation (Abstraction)
interface IRentable
{
    double CalculateRent(int days);
}

// Base class (Inheritance + protected fields)
class Vehicle
{
    protected int VehicleId;
    protected string Brand;
    protected double RatePerDay;

    public Vehicle(int vehicleId, string brand, double ratePerDay)
    {
        VehicleId = vehicleId;
        Brand = brand;
        RatePerDay = ratePerDay;
    }

    // Polymorphism
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Vehicle ID: " + VehicleId +
                          ", Brand: " + Brand +
                          ", Rate Per Day: " + RatePerDay);
    }
}

// Bike class
class Bike : Vehicle, IRentable
{
    public Bike(int vehicleId, string brand, double ratePerDay)
        : base(vehicleId, brand, ratePerDay)
    {
    }

    public double CalculateRent(int days)
    {
        return RatePerDay * days;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Bike ID: " + VehicleId +
                          ", Brand: " + Brand +
                          ", Rate Per Day: " + RatePerDay);
    }
}

// Car class
class Car : Vehicle, IRentable
{
    public Car(int vehicleId, string brand, double ratePerDay)
        : base(vehicleId, brand, ratePerDay)
    {
    }

    public double CalculateRent(int days)
    {
        return RatePerDay * days;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Car ID: " + VehicleId +
                          ", Brand: " + Brand +
                          ", Rate Per Day: " + RatePerDay);
    }
}

// Truck class
class Truck : Vehicle, IRentable
{
    public Truck(int vehicleId, string brand, double ratePerDay)
        : base(vehicleId, brand, ratePerDay)
    {
    }

    public double CalculateRent(int days)
    {
        return RatePerDay * days;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Truck ID: " + VehicleId +
                          ", Brand: " + Brand +
                          ", Rate Per Day: " + RatePerDay);
    }
}

// Customer class
class Customer
{
    int CustomerId;
    string Name;

    public Customer(int customerId, string name)
    {
        CustomerId = customerId;
        Name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Customer ID: " + CustomerId +
                          ", Name: " + Name);
    }
}

// Main class
class VehicleRentalApp
{
    static void Main(string[] args)
    {
        Customer customer = new Customer(1, "Amit");
        customer.DisplayInfo();

        IRentable bike = new Bike(101, "Honda", 300);
        bike.CalculateRent(3);
        ((Bike)bike).DisplayInfo();
        Console.WriteLine("Bike Rent for 3 days: " + bike.CalculateRent(3));

        IRentable car = new Car(201, "Hyundai", 1000);
        ((Car)car).DisplayInfo();
        Console.WriteLine("Car Rent for 2 days: " + car.CalculateRent(2));

        IRentable truck = new Truck(301, "Tata", 2000);
        ((Truck)truck).DisplayInfo();
        Console.WriteLine("Truck Rent for 1 day: " + truck.CalculateRent(1));
    }
}
