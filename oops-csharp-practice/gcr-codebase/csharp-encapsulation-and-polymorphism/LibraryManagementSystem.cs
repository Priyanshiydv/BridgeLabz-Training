using System;

abstract class LibraryItem
{
    private string title;

    public LibraryItem(string title)
    {
        this.title = title;
    }

    public abstract int GetLoanDuration();

    public void Show()
    {
        Console.WriteLine("Title : " + title);
    }
}

class Book : LibraryItem
{
    public Book(string title) : base(title) { }

    public override int GetLoanDuration()
    {
        return 14;
    }
}

class Program
{
    static void Main()
    {
        LibraryItem[] items = new LibraryItem[1];
        items[0] = new Book("C# Basics");

        for (int i = 0; i < items.Length; i++)
            Console.WriteLine(items[i].GetLoanDuration());
    }
}
