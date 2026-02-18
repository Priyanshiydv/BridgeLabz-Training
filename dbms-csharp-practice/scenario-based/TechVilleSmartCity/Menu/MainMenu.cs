using System;
using TechVilleSmartCity.Services;

namespace TechVilleSmartCity.Menu
{
    public class MainMenu
    {
        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n=== TechVille Smart City Management System ===");
                Console.WriteLine("1. Module 1 - Citizen Registration");
                Console.WriteLine("2. Module 2 - Service Eligibility Checker");
                Console.WriteLine("3. Module 3 - Smart Citizen Database");

                Console.WriteLine("0. Exit");
                Console.Write("Select an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CitizenRegistrationService module1 = new CitizenRegistrationService();
                        module1.RegisterCitizen();
                        break;

                    case 2:
                        ServiceEligibilityService module2 = new ServiceEligibilityService();
                        module2.StartRegistration();
                        break;
                    case 3:
                        SmartCitizenDatabaseService module3 = new SmartCitizenDatabaseService();
                        module3.StartDatabase();
                        break;


                    case 0:
                        Console.WriteLine("Exiting system...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
