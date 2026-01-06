using System;

interface IInsurable
{
    double CalculateInsurance();
}

abstract class Vehicle
{
    private string number;
    private double rate;

    public Vehicle(string no, double rate)
    {
        number = no;
        this.rate = rate;
    }

    public abstract double CalculateRentalCost(int days);

    public void Show()
    {
        Console.WriteLine("Vehicle No : " + number);
    }
}

class Car : Vehicle, IInsurable
{
    public Car(string no, double rate) : base(no, rate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * 1000;
    }

    public double CalculateInsurance()
    {
        return 500;
    }
}

class Program
{
    static void Main()
    {
        Vehicle[] v = new Vehicle[1];
        v[0] = new Car("MH12", 1000);

        for (int i = 0; i < v.Length; i++)
            Console.WriteLine(v[i].CalculateRentalCost(2));
    }
}
