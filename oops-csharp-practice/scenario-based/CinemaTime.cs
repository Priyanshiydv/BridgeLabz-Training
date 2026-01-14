using System;
using System.Collections.Generic;

class CinemaTime
{
    static void Main()
    {
        // Data storage 
        List<string> movieTitles = new List<string>();
        List<string> showTimes = new List<string>();

        try
        {
            // Insert data
            AddMovie(movieTitles, showTimes, "Inception", "18:30");
            AddMovie(movieTitles, showTimes, "Avengers Endgame", "21:00");
            AddMovie(movieTitles, showTimes, "Interstellar", "15:45");

            // Uncomment to test invalid time
            // AddMovie(movieTitles, showTimes, "Bad Time Movie", "25:99");

            DisplayAllMovies(movieTitles, showTimes);

            SearchMovie(movieTitles, showTimes, "Inter");

            PrintReport(movieTitles, showTimes);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }

    // Add movie algorithm
    static void AddMovie(List<string> titles, List<string> times, string title, string time)
    {
        if (!IsValidTime(time))
        {
            throw new Exception("Invalid time format: " + time);
        }

        titles.Add(title);
        times.Add(time);
    }

    // Linear search algorithm
    static void SearchMovie(List<string> titles, List<string> times, string keyword)
    {
        Console.WriteLine("\nSearching movies with keyword: " + keyword);

        bool found = false;

        for (int i = 0; i < titles.Count; i++)
        {
            if (titles[i].Contains(keyword))
            {
                Console.WriteLine(titles[i] + " at " + times[i]);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No matching movies found.");
        }
    }

    // Traversal algorithm
    static void DisplayAllMovies(List<string> titles, List<string> times)
    {
        Console.WriteLine("\nAll Movies:");

        for (int i = 0; i < titles.Count; i++)
        {
            Console.WriteLine(titles[i] + " - " + times[i]);
        }
    }

    // List → Array conversion 
    static void PrintReport(List<string> titles, List<string> times)
    {
        Console.WriteLine("\nMovie Report:");

        string[] titleArray = titles.ToArray();
        string[] timeArray = times.ToArray();

        for (int i = 0; i < titleArray.Length; i++)
        {
            Console.WriteLine(titleArray[i] + " | " + timeArray[i]);
        }
    }

    // Validation algorithm
    static bool IsValidTime(string time)
    {
        if (time.Length != 5 || time[2] != ':')
            return false;

        int hour = int.Parse(time.Substring(0, 2));
        int minute = int.Parse(time.Substring(3, 2));

        if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
            return false;

        return true;
    }
}
