using System;
using System.Text.Json;
using System.Collections.Generic;

// Car class
public class Car
{
    public string Brand { get; set; } = "";
    public string Model { get; set; } = "";
    public int Year { get; set; }
    public double Price { get; set; }
}

class CarToJson
{
    static void Main()
    {
        // Create Car object
        Car car = new Car
        {
            Brand = "Toyota",
            Model = "Fortuner",
            Year = 2022,
            Price = 4200000
        };

        // Convert to JSON
        string jsonCar = JsonSerializer.Serialize(car, new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine("Car JSON Data:");
        Console.WriteLine(jsonCar);
    }
}
