using System;

class Book
{
    private string title;
    private string author;
    private double price;

    public Book()
    {
        this.title = "Unknown";
        this.author = "Unknown";
        this.price = 0;
    }

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void DisplayBook()
    {
        Console.WriteLine($"{title} | {author} | ₹{price}");
    }

    static void Main()
    {
        Book b1 = new Book();
        Book b2 = new Book("Clean Code", "Robert Martin", 450);

        b1.DisplayBook();
        b2.DisplayBook();
    }
}
