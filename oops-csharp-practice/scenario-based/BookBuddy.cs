using System;
using System.Collections.Generic;

// Custom Exception
class InvalidBookFormatException : Exception
{
    public InvalidBookFormatException(string message) : base(message)
    {
    }
}

class BookBuddy
{
    // List to store books in "Title - Author" format
    private List<string> books = new List<string>();

    // Add a book
    public void AddBook(string title, string author)
    {
        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
        {
            throw new InvalidBookFormatException("Invalid book format. Title or Author missing.");
        }

        string book = title + " - " + author;
        books.Add(book);

        Console.WriteLine("Book added: " + book);
    }

    // Sort books alphabetically
    public void SortBooksAlphabetically()
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Book list is empty.");

            books.Sort();
            Console.WriteLine("\nBooks sorted alphabetically.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Search books by author
    public void SearchByAuthor(string author)
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Book list is empty.");

            Console.WriteLine("\nBooks by author: " + author);

            foreach (string book in books)
            {
                // Split Title and Author
                string[] parts = book.Split('-');

                if (parts.Length != 2)
                    throw new InvalidBookFormatException("Invalid stored book format.");

                string bookAuthor = parts[1].Trim();

                if (bookAuthor.Contains(author))
                {
                    Console.WriteLine(book);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Display all books
    public void DisplayAllBooks()
    {
        try
        {
            if (books.Count == 0)
                throw new Exception("Book list is empty.");

            Console.WriteLine("\nAll Books:");
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    // Convert List to Array (for export)
    public void ExportBooks()
    {
        string[] bookArray = books.ToArray();

        Console.WriteLine("\nExported Book Report:");
        for (int i = 0; i < bookArray.Length; i++)
        {
            Console.WriteLine(bookArray[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        BookBuddy app = new BookBuddy();

        // Adding books
        app.AddBook("Atomic Habits", "James Clear");
        app.AddBook("Clean Code", "Robert Martin");
        app.AddBook("The Alchemist", "Paulo Coelho");

        // Display all books
        app.DisplayAllBooks();

        // Sort books
        app.SortBooksAlphabetically();
        app.DisplayAllBooks();

        // Search by author
        app.SearchByAuthor("Martin");

        // Export list to array
        app.ExportBooks();

        Console.ReadLine();
    }
}
