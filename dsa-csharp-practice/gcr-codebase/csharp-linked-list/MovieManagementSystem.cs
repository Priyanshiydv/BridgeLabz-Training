using System;

namespace MovieManagementSystem
{
 
    // Movie Node
    
    class MovieNode
    {
        public string Title;
        public string Director;
        public int Year;
        public double Rating;
        public MovieNode Next;
        public MovieNode Prev;

        public MovieNode(string title, string director, int year, double rating)
        {
            Title = title;
            Director = director;
            Year = year;
            Rating = rating;
            Next = null;
            Prev = null;
        }
    }

    
    // Doubly Linked List
    
    class MovieDoublyList
    {
        private MovieNode head;

        // Add at Beginning
        public void AddAtBeginning(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (head != null)
            {
                newNode.Next = head;
                head.Prev = newNode;
            }
            head = newNode;
        }

        // Add at End
        public void AddAtEnd(string title, string director, int year, double rating)
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);

            if (head == null)
            {
                head = newNode;
                return;
            }

            MovieNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        // Add at Specific Position
        public void AddAtPosition(int position, string title, string director, int year, double rating)
        {
            if (position <= 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }

            MovieNode newNode = new MovieNode(title, director, year, rating);
            MovieNode temp = head;

            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            newNode.Next = temp.Next;
            if (temp.Next != null)
                temp.Next.Prev = newNode;

            temp.Next = newNode;
            newNode.Prev = temp;
        }

        // Remove by Movie Title
        public void RemoveByTitle(string title)
        {
            MovieNode temp = head;

            while (temp != null)
            {
                if (temp.Title == title)
                {
                    if (temp.Prev != null)
                        temp.Prev.Next = temp.Next;
                    else
                        head = temp.Next;

                    if (temp.Next != null)
                        temp.Next.Prev = temp.Prev;

                    Console.WriteLine("Movie removed");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Movie not found");
        }

        // Search by Director or Rating
        public void Search(string director, double rating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.Director == director || temp.Rating == rating)
                {
                    Console.WriteLine("Found Movie: " + temp.Title);
                }
                temp = temp.Next;
            }
        }

        // Update Rating
        public void UpdateRating(string title, double newRating)
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.Title == title)
                {
                    temp.Rating = newRating;
                    Console.WriteLine("Rating updated");
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Movie not found");
        }

        // Display Forward
        public void DisplayForward()
        {
            MovieNode temp = head;
            Console.WriteLine("\nMovies (Forward):");
            while (temp != null)
            {
                Console.WriteLine(temp.Title + " " + temp.Director + " " + temp.Year + " " + temp.Rating);
                temp = temp.Next;
            }
        }

        // Display Reverse
        public void DisplayReverse()
        {
            if (head == null)
                return;

            MovieNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            Console.WriteLine("\nMovies (Reverse):");
            while (temp != null)
            {
                Console.WriteLine(temp.Title + " " + temp.Director + " " + temp.Year + " " + temp.Rating);
                temp = temp.Prev;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            MovieDoublyList movies = new MovieDoublyList();

            movies.AddAtBeginning("Inception", "Nolan", 2010, 9.0);
            movies.AddAtEnd("Interstellar", "Nolan", 2014, 8.8);
            movies.AddAtPosition(2, "Avatar", "Cameron", 2009, 8.0);

            movies.DisplayForward();
            movies.DisplayReverse();

            movies.Search("Nolan", 9.0);
            movies.UpdateRating("Avatar", 8.5);
            movies.RemoveByTitle("Inception");

            movies.DisplayForward();
        }
    }
}
