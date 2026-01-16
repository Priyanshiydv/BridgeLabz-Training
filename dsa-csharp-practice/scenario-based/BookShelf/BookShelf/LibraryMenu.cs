using System;

namespace BookShelf
{
    internal class LibraryMenu
    {
            private LibraryLogic logic;

            public LibraryMenu()
            {
                logic = new LibraryLogic();
            }

            public void Start()
            {
                int choice;

                do
                {
                    Console.WriteLine("\n===== Library Menu =====");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Borrow Book");
                    Console.WriteLine("3. Display Library");
                    Console.WriteLine("0. Exit");
                    Console.Write("Enter choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Genre (Fiction/Science/History): ");
                            string genre = Console.ReadLine();

                            Console.Write("Enter Book Title: ");
                            string title = Console.ReadLine();

                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();

                            logic.AddBook(genre, title, author);
                            break;

                        case 2:
                            Console.Write("Enter Genre: ");
                            string g = Console.ReadLine();

                            Console.Write("Enter Book Title: ");
                            string t = Console.ReadLine();

                            logic.BorrowBook(g, t);
                            break;

                        case 3:
                            logic.DisplayLibrary();
                            break;

                        case 0:
                            Console.WriteLine("Exiting Library...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }

                } while (choice != 0);
            }
        }
    }
