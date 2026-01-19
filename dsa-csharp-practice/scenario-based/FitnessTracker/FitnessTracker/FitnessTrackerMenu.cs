using System;

namespace FitnessTracker
{
    internal class FitnessTrackerMenu
    {
        public void Start()
        {
            User[] users =
            {
                new User("Divya", 8200),
                new User("Neha", 9500),
                new User("Suruchi", 7600),
                new User("Priya", 9000)
            };

            FitnessTrackerLogic logic = new FitnessTrackerLogic();

            Console.WriteLine("Before Ranking:");
            logic.Display(users);

            // Apply Bubble Sort
            logic.BubbleSort(users);

            Console.WriteLine("\nDaily Step Leaderboard:");
            logic.Display(users);
        }
    }
}
