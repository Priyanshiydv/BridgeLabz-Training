using System;

namespace BookShelf
{
    internal class LibraryLogic
    {
        private string[] genres = { "Fiction", "Science", "History" };
        private Book[][] books;           // Jagged array
        private int[] bookCount;           // Track count per genre
        private int maxBooks = 5;

        public LibraryLogic()
        {
            books = new Book[genres.Length][];
            bookCount = new int[genres.Length];

            for (int i = 0; i < genres.Length; i++)
            {
                books[i] = new Book[maxBooks];
                bookCount[i] = 0;
            }
        }

        // Add book
        public void AddBook(string genre, string title, string author)
        {
            int index = GetGenreIndex(genre);
            if (index == -1)
            {
                Console.WriteLine("Genre not found.");
                return;
            }

            // Duplicate check
            for (int i = 0; i < bookCount[index]; i++)
            {
                if (books[index][i].Title == title)
                {
                    Console.WriteLine("Duplicate book not allowed.");
                    return;
                }
            }

            if (bookCount[index] == maxBooks)
            {
                Console.WriteLine("Shelf full for this genre.");
                return;
            }

            books[index][bookCount[index]++] = new Book(title, author);
            Console.WriteLine("Book added successfully.");
        }

        // Borrow book
        public void BorrowBook(string genre, string title)
        {
            int index = GetGenreIndex(genre);
            if (index == -1)
            {
                Console.WriteLine("Genre not found.");
                return;
            }

            for (int i = 0; i < bookCount[index]; i++)
            {
                if (books[index][i].Title == title)
                {
                    // Shift left
                    for (int j = i; j < bookCount[index] - 1; j++)
                    {
                        books[index][j] = books[index][j + 1];
                    }

                    books[index][--bookCount[index]] = null;
                    Console.WriteLine("Book borrowed: " + title);
                    return;
                }
            }

            Console.WriteLine("Book not found.");
        }

        // Display library
        public void DisplayLibrary()
        {
            for (int i = 0; i < genres.Length; i++)
            {
                Console.WriteLine("\nGenre: " + genres[i]);

                if (bookCount[i] == 0)
                {
                    Console.WriteLine("  No books available.");
                }

                for (int j = 0; j < bookCount[i]; j++)
                {
                    Console.WriteLine("  " +
                        books[i][j].Title + " - " +
                        books[i][j].Author);
                }
            }
        }

        // Helper
        private int GetGenreIndex(string genre)
        {
            for (int i = 0; i < genres.Length; i++)
            {
                if (genres[i].Equals(genre, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }
    }
}
 
        
