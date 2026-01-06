using System;

interface ITaxable
{
    double CalculateTax();
}

abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public int ProductId { get { return productId; } set { productId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public double Price { get { return price; } set { price = value; } }

    public Product(int id, string name, double price)
    {
        ProductId = id;
        Name = name;
        Price = price;
    }

    public abstract double CalculateDiscount();

    public void Display()
    {
        Console.WriteLine("Product : " + Name);
        Console.WriteLine("Final Price : " + (Price - CalculateDiscount()));
    }
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return 500;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }
}

class Program
{
    static void Main()
    {
        Product[] p = new Product[1];
        p[0] = new Electronics(101, "Laptop", 50000);

        for (int i = 0; i < p.Length; i++)
            p[i].Display();
    }
}
