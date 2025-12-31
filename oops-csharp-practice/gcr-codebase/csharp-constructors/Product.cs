using System;

class Product
{
    string productName;
    int price;
    static int totalProducts = 0;

    Product(string n, int p)
    {
        productName = n;
        price = p;
        totalProducts++;
    }

    void DisplayProductDetails()
    {
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Price: " + price);
    }

    static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
    }

    static void Main()
    {
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Mobile", 20000);

        p1.DisplayProductDetails();
        DisplayTotalProducts();
    }
}
