using System;

namespace FitTrack
{
    sealed class FitTrackMenu
    {
        private ITrackable tracker;

        public void Start()
        {
            UserProfile user = new UserProfile();

            Console.Write("Enter User ID: ");
            user.UserId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter User Name: ");
            user.UserName = Console.ReadLine();

            Console.Write("Enter Age: ");
            user.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- User Profile ---");
            user.DisplayUser();

            int choice;

            do
            {
                Console.WriteLine("\n---- FitTrack Menu ----");
                Console.WriteLine("1. Start Cardio Workout");
                Console.WriteLine("2. End Cardio Workout");
                Console.WriteLine("3. Start Strength Workout");
                Console.WriteLine("4. End Strength Workout");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                Workout workout = new Workout();

                switch (choice)
                {
                    case 1:
                        workout.WorkoutType = "Cardio";
                        workout.Duration = 30;
                        tracker = new WorkoutUtilityImpl(workout);
                        tracker.StartWorkout();
                        break;

                    case 2:
                        workout.WorkoutType = "Cardio";
                        tracker = new WorkoutUtilityImpl(workout);
                        tracker.EndWorkout();
                        break;

                    case 3:
                        workout.WorkoutType = "Strength";
                        workout.Duration = 45;
                        tracker = new WorkoutUtilityImpl(workout);
                        tracker.StartWorkout();
                        break;

                    case 4:
                        workout.WorkoutType = "Strength";
                        tracker = new WorkoutUtilityImpl(workout);
                        tracker.EndWorkout();
                        break;

                    case 0:
                        Console.WriteLine("Exiting FitTrack...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
