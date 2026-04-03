using System;


namespace FlashDealz
{
    internal class FlashDealzLogic
    {
        public void QuickSort(Product[] products, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(products, low, high);
                QuickSort(products, low, pivotIndex - 1);
                QuickSort(products, pivotIndex + 1, high);
            }
        }

        private int Partition(Product[] products, int low, int high)
        {
            int pivot = products[high].Discount;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (products[j].Discount > pivot) // descending order
                {
                    i++;
                    Swap(products, i, j);
                }
            }

            Swap(products, i + 1, high);
            return i + 1;
        }

        private void Swap(Product[] products, int i, int j)
        {
            Product temp = products[i];
            products[i] = products[j];
            products[j] = temp;
        }

        public void Display(Product[] products)
        {
            foreach (Product p in products)
            {
                Console.WriteLine(p.Name + " - " + p.Discount + "%");
            }
        }
    }
}
