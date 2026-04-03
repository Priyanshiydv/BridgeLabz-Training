using System;

namespace FlashDealz
{
    internal class FlashDealzMain
    {
        static void Main()
        {
            Product[] products =
            {
            new Product("Laptop", 40),
            new Product("Mobile", 25),
            new Product("TV", 50),
            new Product("Headphones", 30)
        };

            FlashDealzLogic logic = new FlashDealzLogic();

            Console.WriteLine("Before Sorting:");
            logic.Display(products);

            logic.QuickSort(products, 0, products.Length - 1);

            Console.WriteLine("\nTop Discounted Products:");
            logic.Display(products);

            Console.ReadLine();
        }
    }
}

