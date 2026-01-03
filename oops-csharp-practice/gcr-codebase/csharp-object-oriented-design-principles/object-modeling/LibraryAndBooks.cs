using System;
using System.Collections.Generic;

// Book can exist without Library
class Book
{
    public string Title;
    public string Author;

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }
}

class Library
{
    public string Name;
    public List<Book> Books = new List<Book>();

    public Library(string name)
    {
        Name = name;
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public void ShowBooks()
    {
        Console.WriteLine($"Library: {Name}");
        foreach (Book b in Books)
        {
            Console.WriteLine($"- {b.Title} by {b.Author}");
        }
    }
}

class LibraryAndBooks
{
    static void Main()
    {
        Book b1 = new Book("Java Basics", "James");
        Book b2 = new Book("C# Fundamentals", "Anders");

        Library lib1 = new Library("City Library");
        Library lib2 = new Library("College Library");

        lib1.AddBook(b1);
        lib2.AddBook(b1);
        lib2.AddBook(b2);

        lib1.ShowBooks();
        lib2.ShowBooks();
    }
}
