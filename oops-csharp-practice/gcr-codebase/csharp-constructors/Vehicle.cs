using System;

class Vehicle
{
    string ownerName;
    string vehicleType;
    static int registrationFee = 5000;

    Vehicle(string o, string v)
    {
        ownerName = o;
        vehicleType = v;
    }

    void DisplayVehicleDetails()
    {
        Console.WriteLine("Owner: " + ownerName);
        Console.WriteLine("Vehicle: " + vehicleType);
        Console.WriteLine("Fee: " + registrationFee);
    }

    static void UpdateRegistrationFee(int fee)
    {
        registrationFee = fee;
    }

    static void Main()
    {
        Vehicle.UpdateRegistrationFee(6000);
        Vehicle v = new Vehicle("Nikhil", "Bike");
        v.DisplayVehicleDetails();
    }
}
