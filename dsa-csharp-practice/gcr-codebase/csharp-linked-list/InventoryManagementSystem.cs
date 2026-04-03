using System;

class InventoryNode
{
    public int ItemId;
    public string ItemName;
    public int Quantity;
    public double Price;
    public InventoryNode Next;

    public InventoryNode(int id, string name, int qty, double price)
    {
        ItemId = id;
        ItemName = name;
        Quantity = qty;
        Price = price;
        Next = null;
    }
}

class InventoryList
{
    private InventoryNode head;

    // Add at beginning
    public void AddAtBeginning(int id, string name, int qty, double price)
    {
        InventoryNode node = new InventoryNode(id, name, qty, price);
        node.Next = head;
        head = node;
    }

    // Add at end
    public void AddAtEnd(int id, string name, int qty, double price)
    {
        InventoryNode node = new InventoryNode(id, name, qty, price);

        if (head == null)
        {
            head = node;
            return;
        }

        InventoryNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = node;
    }

    // Add at position
    public void AddAtPosition(int pos, int id, string name, int qty, double price)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, name, qty, price);
            return;
        }

        InventoryNode node = new InventoryNode(id, name, qty, price);
        InventoryNode temp = head;

        for (int i = 1; i < pos - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        node.Next = temp.Next;
        temp.Next = node;
    }

    // Remove by Item ID
    public void RemoveById(int id)
    {
        if (head == null)
        {
            Console.WriteLine("Inventory empty");
            return;
        }

        if (head.ItemId == id)
        {
            head = head.Next;
            Console.WriteLine("Item removed");
            return;
        }

        InventoryNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != id)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Item not found");
        }
        else
        {
            temp.Next = temp.Next.Next;
            Console.WriteLine("Item removed");
        }
    }

    // Update quantity
    public void UpdateQuantity(int id, int newQty)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id)
            {
                temp.Quantity = newQty;
                Console.WriteLine("Quantity updated");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }

    // Search by ID or Name
    public void Search(int id, string name)
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == id || temp.ItemName == name)
            {
                DisplayItem(temp);
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found");
    }

    // Calculate total value
    public void TotalValue()
    {
        double total = 0;
        InventoryNode temp = head;

        while (temp != null)
        {
            total = total + (temp.Price * temp.Quantity);
            temp = temp.Next;
        }

        Console.WriteLine("Total Inventory Value: " + total);
    }

    // Sort by Name or Price
    public void SortByName(bool ascending)
    {
        if (head == null) return;

        for (InventoryNode i = head; i.Next != null; i = i.Next)
        {
            for (InventoryNode j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && string.Compare(i.ItemName, j.ItemName) > 0) ||
                    (!ascending && string.Compare(i.ItemName, j.ItemName) < 0))
                {
                    Swap(i, j);
                }
            }
        }
    }

    public void SortByPrice(bool ascending)
    {
        if (head == null) return;

        for (InventoryNode i = head; i.Next != null; i = i.Next)
        {
            for (InventoryNode j = i.Next; j != null; j = j.Next)
            {
                if ((ascending && i.Price > j.Price) ||
                    (!ascending && i.Price < j.Price))
                {
                    Swap(i, j);
                }
            }
        }
    }

    private void Swap(InventoryNode a, InventoryNode b)
    {
        int id = a.ItemId;
        string name = a.ItemName;
        int qty = a.Quantity;
        double price = a.Price;

        a.ItemId = b.ItemId;
        a.ItemName = b.ItemName;
        a.Quantity = b.Quantity;
        a.Price = b.Price;

        b.ItemId = id;
        b.ItemName = name;
        b.Quantity = qty;
        b.Price = price;
    }

    // Display all
    public void DisplayAll()
    {
        InventoryNode temp = head;
        while (temp != null)
        {
            DisplayItem(temp);
            temp = temp.Next;
        }
    }

    private void DisplayItem(InventoryNode item)
    {
        Console.WriteLine("ID: " + item.ItemId);
        Console.WriteLine("Name: " + item.ItemName);
        Console.WriteLine("Quantity: " + item.Quantity);
        Console.WriteLine("Price: " + item.Price);
        Console.WriteLine("-------------------");
    }
}

class Program
{
    static void Main()
    {
        InventoryList inv = new InventoryList();

        inv.AddAtEnd(1, "Pen", 10, 5);
        inv.AddAtEnd(2, "Book", 5, 50);
        inv.AddAtBeginning(3, "Pencil", 20, 2);

        Console.WriteLine("All Items:");
        inv.DisplayAll();

        inv.UpdateQuantity(1, 15);
        inv.Search(2, "");

        inv.TotalValue();

        Console.WriteLine("Sorted by Price Ascending:");
        inv.SortByPrice(true);
        inv.DisplayAll();
    }
}
