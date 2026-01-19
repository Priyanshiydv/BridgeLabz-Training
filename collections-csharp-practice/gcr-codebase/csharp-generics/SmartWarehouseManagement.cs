using System;
using System.Collections.Generic;

// Abstract base class
abstract class WarehouseItem
{
    public string Name;
    public abstract void Display();
}

//Derived class
class Electronics : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Electronics Item: " + Name);
    }
}

// Generic class with constraint
class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].Display();
        }
    }
}

class SmartWarehouseManagement
{
    static void Main()
    {
        Storage<Electronics> store = new Storage<Electronics>();
        store.AddItem(new Electronics { Name = "Laptop" });
        store.DisplayItems();
    }
}
