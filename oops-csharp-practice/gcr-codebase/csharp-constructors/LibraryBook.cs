using System;

class LibraryBook
{
    string title;
    string author;
    int price;
    bool available = true;

    Book(string t, string a, int p)
    {
        title = t;
        author = a;
        price = p;
    }

    void BorrowBook()
    {
        if (available)
        {
            available = false;
            Console.WriteLine("Book borrowed");
        }
        else
        {
            Console.WriteLine("Book not available");
        }
    }

    static void Main()
    {
        BookLibrary b = new LibraryBook("C#", "Microsoft", 300);
        b.BorrowBook();
        b.BorrowBook();
    }
}
