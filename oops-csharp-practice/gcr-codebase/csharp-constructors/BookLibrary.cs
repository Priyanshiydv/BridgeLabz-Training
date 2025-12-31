using System;

class BookLibrary
{
    public string ISBN;
    protected string title;
    private string author;

    public void SetAuthor(string a)
    {
        author = a;
    }

    public string GetAuthor()
    {
        return author;
    }
}

class EBook : BookLibrary
{
    static void Main()
    {
        EBook e = new EBook();
        e.ISBN = "ISBN101";
        e.title = "C# Guide";
        e.SetAuthor("Microsoft");

        Console.WriteLine("ISBN: " + e.ISBN);
        Console.WriteLine("Title: " + e.title);
        Console.WriteLine("Author: " + e.GetAuthor());
    }
}
