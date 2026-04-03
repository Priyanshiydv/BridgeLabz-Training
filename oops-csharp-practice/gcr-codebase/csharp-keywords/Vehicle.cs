using System;

class Vehicle
{
    public static double RegistrationFee = 1500;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string ownerName, string vehicleType, string regNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = regNumber;
    }

    public static void UpdateRegistrationFee(double fee)
    {
        RegistrationFee = fee;
    }

    public void Display()
    {
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Fee: " + RegistrationFee);
    }
}

class Program
{
    static void Main()
    {
        Vehicle v1 = new Vehicle("Rahul", "Car", "DL01AB1234");

        if (v1 is Vehicle)
        {
            v1.Display();
        }
    }
}
