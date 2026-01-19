using System;

namespace FitnessTracker
{
    // Data Holder Class
    
    internal class User
    {
        public string Name;
        public int Steps;

        public User(string name, int steps)
        {
            Name = name;
            Steps = steps;
        }
    }
}
