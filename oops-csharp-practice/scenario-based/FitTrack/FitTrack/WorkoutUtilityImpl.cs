using System;

namespace FitTrack
{
    internal class WorkoutUtilityImpl : ITrackable  // workout logic
    {
        private Workout workout;

        public WorkoutUtilityImpl(Workout workout)
        {
            this.workout = workout;
        }

        public void StartWorkout()
        {
            if (workout.WorkoutType == "Cardio")
                Console.WriteLine("Starting Cardio Workout ");

            else if (workout.WorkoutType == "Strength")
                Console.WriteLine("Starting Strength Training");

            Console.WriteLine("Workout Duration: " + workout.Duration + " minutes");
        }

        public void EndWorkout()
        {
            Console.WriteLine(workout.WorkoutType + " Workout Completed ");
        }
    }
}
