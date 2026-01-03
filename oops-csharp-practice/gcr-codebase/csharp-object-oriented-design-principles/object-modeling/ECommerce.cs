using System;
using System.Collections.Generic;

class Product
{
    public string Name;

    public Product(string name)
    {
        Name = name;
    }
}

class Order
{
    public List<Product> Products = new List<Product>();
}

class Customer
{
    public string Name;

    public Customer(string name)
    {
        Name = name;
    }

    public void PlaceOrder(Order order)
    {
        Console.WriteLine(Name + " placed an order.");
    }
}

class ECommerce
{
    static void Main()
    {
        Customer c = new Customer("Asha");
        Order o = new Order();

        o.Products.Add(new Product("Laptop"));
        o.Products.Add(new Product("Mouse"));

        c.PlaceOrder(o);
    }
}
