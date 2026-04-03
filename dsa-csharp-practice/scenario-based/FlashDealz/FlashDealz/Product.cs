using System;

namespace FlashDealz
{
    internal class Product
    {
        public string Name;
        public int Discount; // percentage

        public Product(string name, int discount)
        {
            Name = name;
            Discount = discount;
        }
    }
}
