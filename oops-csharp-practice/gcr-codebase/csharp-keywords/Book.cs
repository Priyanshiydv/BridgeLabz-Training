using System;

class Book
{
    // static variable
    public static string LibraryName = "City Central Library";

    // readonly variable
    public readonly string ISBN;

    public string Title;
    public string Author;

    // constructor using this
    public Book(string title, string author, string isbn)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }

    // static method
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }

    public void Display()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
    }
}

class Program
{
    static void Main()
    {
        Book b1 = new Book("C# Basics", "John", "ISBN123");

        Book.DisplayLibraryName();

        if (b1 is Book)
        {
            b1.Display();
        }
    }
}
