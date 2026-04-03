using System;

class Product
{
    public static double Discount = 10.0;

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(string name, double price, int quantity, int productId)
    {
        this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;
        this.ProductID = productId;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public void Display()
    {
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product("Laptop", 50000, 1, 301);

        if (p1 is Product)
        {
            p1.Display();
        }
    }
}
