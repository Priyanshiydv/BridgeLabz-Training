using System;
namespace TrafficManager
{
    internal class TrafficMenu
    {
        private TrafficLogic logic;

        public TrafficMenu()
        {
            logic = new TrafficLogic();
        }

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== Traffic Manager =====");
                Console.WriteLine("1. Add vehicle to waiting queue");
                Console.WriteLine("2. Allow vehicle into roundabout");
                Console.WriteLine("3. Vehicle exits roundabout");
                Console.WriteLine("4. Display roundabout");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter vehicle number: ");
                        logic.AddToQueue(Console.ReadLine());
                        break;

                    case 2:
                        logic.EnterRoundabout();
                        break;

                    case 3:
                        logic.ExitRoundabout();
                        break;

                    case 4:
                        logic.DisplayRoundabout();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Traffic Manager...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
