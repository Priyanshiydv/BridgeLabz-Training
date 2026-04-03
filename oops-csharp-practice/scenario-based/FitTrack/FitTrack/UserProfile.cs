using System;

namespace FitTrack
{
    internal class UserProfile
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }

        public void DisplayUser()
        {
            Console.WriteLine("User ID: " + UserId);
            Console.WriteLine("User Name: " + UserName);
            Console.WriteLine("Age: " + Age);
        }
    }
}
