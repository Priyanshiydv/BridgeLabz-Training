using System;

namespace FitTrack
{
    internal class Workout  //store workout data
    {
        public int WorkoutId { get; set; }
        public string WorkoutName { get; set; }
        public string WorkoutType { get; set; } // Cardio / Strength
        public int Duration { get; set; } // in minutes

        public override string ToString()
        {
            return "Workout ID: " + WorkoutId +
                   "\nWorkout Name: " + WorkoutName +
                   "\nWorkout Type: " + WorkoutType +
                   "\nDuration: " + Duration + " minutes";
        }
    }
}
