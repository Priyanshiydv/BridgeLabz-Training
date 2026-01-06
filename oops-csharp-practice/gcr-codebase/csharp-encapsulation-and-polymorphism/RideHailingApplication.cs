using System;

abstract class Vehicle
{
    protected double rate;

    public Vehicle(double rate)
    {
        this.rate = rate;
    }

    public abstract double CalculateFare(double km);
}

class Bike : Vehicle
{
    public Bike(double rate) : base(rate) { }

    public override double CalculateFare(double km)
    {
        return rate * km;
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] v = new Vehicle[1];
        v[0] = new Bike(10);

        for (int i = 0; i < v.Length; i++)
            Console.WriteLine(v[i].CalculateFare(5));
    }
}
