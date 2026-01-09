using System;

namespace SmartHome
{
    sealed class SmartHomeMenu
    {
        private IControllable appliance;

        public void Start()
        {
            int choice;

            do
            {
                Console.WriteLine("\n---- Smart Home Automation Menu ----");
                Console.WriteLine("1. Turn ON Light");
                Console.WriteLine("2. Turn OFF Light");
                Console.WriteLine("3. Turn ON Fan");
                Console.WriteLine("4. Turn OFF Fan");
                Console.WriteLine("5. Turn ON AC");
                Console.WriteLine("6. Turn OFF AC");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                Appliance app = new Appliance(); // MODEL object

                switch (choice)
                {
                    case 1:
                        app.Type = "Light";
                        appliance = new ApplianceUtilityImpl(app);
                        appliance.TurnOn();
                        break;

                    case 2:
                        app.Type = "Light";
                        appliance = new ApplianceUtilityImpl(app);
                        appliance.TurnOff();
                        break;

                    case 3:
                        app.Type = "Fan";
                        appliance = new ApplianceUtilityImpl(app);
                        appliance.TurnOn();
                        break;

                    case 4:
                        app.Type = "Fan";
                        appliance = new ApplianceUtilityImpl(app);
                        appliance.TurnOff();
                        break;

                    case 5:
                        app.Type = "AC";
                        appliance = new ApplianceUtilityImpl(app);
                        appliance.TurnOn();
                        break;

                    case 6:
                        app.Type = "AC";
                        appliance = new ApplianceUtilityImpl(app);
                        appliance.TurnOff();
                        break;

                    case 0:
                        Console.WriteLine("Exiting Smart Home System...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
