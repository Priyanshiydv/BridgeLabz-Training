using System;

namespace FitnessTracker
{
    // Logic Class
    
    internal class FitnessTrackerLogic
    {
        // Bubble Sort Method
        // Repeatedly swaps adjacent elements

        public void BubbleSort(User[] users)
        {
            int n = users.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Sort in descending order (ranking)
                    if (users[j].Steps < users[j + 1].Steps)
                    {
                        Swap(users, j, j + 1);
                    }
                }
            }
        }

        // Swap Method
        private void Swap(User[] users, int i, int j)
        {
            User temp = users[i];
            users[i] = users[j];
            users[j] = temp;
        }

        // Display rankings
        public void Display(User[] users)
        {
            foreach (User u in users)
            {
                Console.WriteLine(u.Name + " - " + u.Steps + " steps");
            }
        }
    }
}
