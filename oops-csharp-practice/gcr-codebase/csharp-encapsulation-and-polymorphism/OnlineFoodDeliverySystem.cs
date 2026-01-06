using System;

abstract class FoodItem
{
    protected double price;
    protected int quantity;

    public FoodItem(double price, int qty)
    {
        this.price = price;
        quantity = qty;
    }

    public abstract double CalculateTotalPrice();
}

class VegItem : FoodItem
{
    public VegItem(double price, int qty) : base(price, qty) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }
}

class Program
{
    static void Main()
    {
        FoodItem[] food = new FoodItem[1];
        food[0] = new VegItem(100, 2);

        for (int i = 0; i < food.Length; i++)
            Console.WriteLine(food[i].CalculateTotalPrice());
    }
}
