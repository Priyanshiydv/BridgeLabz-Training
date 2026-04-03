using System;

class CarRental
{
    string customerName;
    string carModel;
    int rentalDays;

    CarRental(string c, string m, int d)
    {
        customerName = c;
        carModel = m;
        rentalDays = d;
    }

    int CalculateCost()
    {
        return rentalDays * 1000;
    }

    static void Main()
    {
        CarRental c = new CarRental("Divya", "Swift", 4);
        Console.WriteLine("Total Cost: " + c.CalculateCost());
    }
}
