using System;

class Library
{
    // Arrays to store book details
    string[] titles = new string[5];
    string[] authors = new string[5];
    string[] status = new string[5]; // Available / Checked Out
    int count = 0; // number of books

    static void Main()
    {
        Library lib = new Library();
        int choice;

        do
        {
            Console.WriteLine("\n--- Library Management System ---");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Student");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    lib.AdminMenu();
                    break;

                case 2:
                    lib.StudentMenu();
                    break;

                case 3:
                    Console.WriteLine("Exiting System...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 3);
    }

    // ---------------- ADMIN MENU ----------------
    void AdminMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Admin Menu ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Display Books");
            Console.WriteLine("3. Back");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddBook();
                    break;

                case 2:
                    DisplayBooks();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 3);
    }

    // ---------------- STUDENT MENU ----------------
    void StudentMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Menu ---");
            Console.WriteLine("1. Search Book");
            Console.WriteLine("2. Checkout Book");
            Console.WriteLine("3. Back");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SearchBook();
                    break;

                case 2:
                    CheckoutBook();
                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 3);
    }

    // Method to add book (Admin)
    void AddBook()
    {
        if (count >= titles.Length)
        {
            Console.WriteLine("Library is full!");
            return;
        }

        Console.Write("Enter Book Title: ");
        titles[count] = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        authors[count] = Console.ReadLine();

        status[count] = "Available";

        count++;
        Console.WriteLine("Book added successfully!");
    }

    // Method to display books
    void DisplayBooks()
    {
        if (count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(
                (i + 1) + ". " + titles[i] + " | " + authors[i] + " | " + status[i]
            );
        }
    }

    // Method to search book by partial title
    void SearchBook()
    {
        Console.Write("Enter title to search: ");
        string search = Console.ReadLine().ToLower();

        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (titles[i].ToLower().Contains(search))
            {
                Console.WriteLine(
                    titles[i] + " | " + authors[i] + " | " + status[i]
                );
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found!");
        }
    }

    // Method to checkout book
    void CheckoutBook()
    {
        Console.Write("Enter full title to checkout: ");
        string name = Console.ReadLine().ToLower();

        for (int i = 0; i < count; i++)
        {
            if (titles[i].ToLower() == name)
            {
                if (status[i] == "Available")
                {
                    status[i] = "Checked Out";
                    Console.WriteLine("Book checked out successfully!");
                }
                else
                {
                    Console.WriteLine("Book already checked out!");
                }
                return;
            }
        }

        Console.WriteLine("Book not found!");
    }
}
