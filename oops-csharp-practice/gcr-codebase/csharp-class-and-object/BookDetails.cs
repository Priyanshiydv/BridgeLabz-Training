using System;

public class BookDetails
{
    // Private fields
    private string title;
    private string author;
    private double price;

    // Constructor
    public BookDetails(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: ₹" + price);
    }
}

public class Program
{
    public static void Main()
    {
        // Creating Book object
        BookDetails book = new BookDetails("Harry Potter", "J.K Rowling", 350);

        // Displaying book details
        book.DisplayDetails();
    }
}
