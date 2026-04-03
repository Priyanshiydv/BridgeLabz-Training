using System;

// Base Product class
class Product
{
    public string Name;
    public double Price;
}

// Derived product
class Book : Product { }

// Generic utility class
class Marketplace
{
    // Generic method with constraint
    public static void ApplyDiscount<T>(T product, double percentage) where T : Product
    {
        product.Price -= product.Price * percentage / 100;
        Console.WriteLine("Discounted Price: " + product.Price);
    }
}

class OnlineMarketplace
{
    static void Main()
    {
        Book book = new Book { Name = "C# Book", Price = 500 };
        Marketplace.ApplyDiscount(book, 10);
    }
}
