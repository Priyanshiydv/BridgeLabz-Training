using System;

class BookNode
{
    public int BookId;
    public string Title;
    public string Author;
    public string Genre;
    public bool Available;

    public BookNode Prev;
    public BookNode Next;

    public BookNode(int id, string title, string author, string genre, bool available)
    {
        BookId = id;
        Title = title;
        Author = author;
        Genre = genre;
        Available = available;
        Prev = null;
        Next = null;
    }
}

class Library
{
    private BookNode head;
    private BookNode tail;

    // Add at beginning
    public void AddAtBeginning(int id, string title, string author, string genre, bool available)
    {
        BookNode node = new BookNode(id, title, author, genre, available);

        if (head == null)
        {
            head = tail = node;
        }
        else
        {
            node.Next = head;
            head.Prev = node;
            head = node;
        }
    }

    // Add at end
    public void AddAtEnd(int id, string title, string author, string genre, bool available)
    {
        BookNode node = new BookNode(id, title, author, genre, available);

        if (tail == null)
        {
            head = tail = node;
        }
        else
        {
            tail.Next = node;
            node.Prev = tail;
            tail = node;
        }
    }

    // Add at position
    public void AddAtPosition(int pos, int id, string title, string author, string genre, bool available)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, title, author, genre, available);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        if (temp.Next == null)
        {
            AddAtEnd(id, title, author, genre, available);
            return;
        }

        BookNode node = new BookNode(id, title, author, genre, available);
        node.Next = temp.Next;
        node.Prev = temp;
        temp.Next.Prev = node;
        temp.Next = node;
    }

    // Remove by Book ID
    public void RemoveById(int id)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                if (temp == head)
                {
                    head = head.Next;
                    if (head != null)
                        head.Prev = null;
                }
                else if (temp == tail)
                {
                    tail = tail.Prev;
                    tail.Next = null;
                }
                else
                {
                    temp.Prev.Next = temp.Next;
                    temp.Next.Prev = temp.Prev;
                }

                Console.WriteLine("Book removed");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }

    // Search by title or author
    public void Search(string title, string author)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.Title == title || temp.Author == author)
            {
                DisplayBook(temp);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }

    // Update availability
    public void UpdateAvailability(int id, bool status)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.BookId == id)
            {
                temp.Available = status;
                Console.WriteLine("Availability updated");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Book not found");
    }

    // Display forward
    public void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Next;
        }
    }

    // Display reverse
    public void DisplayReverse()
    {
        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.Prev;
        }
    }

    // Count books
    public void CountBooks()
    {
        int count = 0;
        BookNode temp = head;

        while (temp != null)
        {
            count++;
            temp = temp.Next;
        }

        Console.WriteLine("Total Books: " + count);
    }

    private void DisplayBook(BookNode b)
    {
        Console.WriteLine("ID: " + b.BookId);
        Console.WriteLine("Title: " + b.Title);
        Console.WriteLine("Author: " + b.Author);
        Console.WriteLine("Genre: " + b.Genre);
        Console.WriteLine("Available: " + b.Available);
        Console.WriteLine("----------------------");
    }
}

class Program
{
    static void Main()
    {
        Library lib = new Library();

        lib.AddAtEnd(1, "Java", "James", "Programming", true);
        lib.AddAtEnd(2, "CSharp", "Microsoft", "Programming", true);
        lib.AddAtBeginning(3, "Python", "Guido", "Programming", false);

        Console.WriteLine("Books Forward:");
        lib.DisplayForward();

        Console.WriteLine("Books Reverse:");
        lib.DisplayReverse();

        lib.Search("Java", "");
        lib.UpdateAvailability(3, true);

        lib.CountBooks();
    }
}
