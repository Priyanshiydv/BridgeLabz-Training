using System;
using System.Collections.Generic;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();

        cart.Add("Laptop", 55000);
        cart.Add("Mouse", 500);
        cart.Add("Keyboard", 1500);

        SortedDictionary<double, string> sortedCart =
            new SortedDictionary<double, string>();

        string[] keys = new string[cart.Count];
        cart.Keys.CopyTo(keys, 0);

        for (int i = 0; i < keys.Length; i++)
        {
            sortedCart.Add(cart[keys[i]], keys[i]);
        }

        double total = 0;
        double[] prices = new double[sortedCart.Count];
        sortedCart.Keys.CopyTo(prices, 0);

        Console.WriteLine("Items Sorted by Price:");
        for (int i = 0; i < prices.Length; i++)
        {
            Console.WriteLine(sortedCart[prices[i]] + " : " + prices[i]);
            total = total + prices[i];
        }

        Console.WriteLine("Total Bill: " + total);
    }
}
