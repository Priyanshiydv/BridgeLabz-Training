using System;

namespace TechVilleSmartCity.Services
{
    public class ServiceEligibilityService
    {
        public void StartRegistration()
        {
            Console.WriteLine("\n=== Module 2: Service Eligibility Checker ===");

            Console.Write("Enter number of family members to register: ");
            int totalMembers = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= totalMembers; i++)
            {
                Console.WriteLine($"\n--- Registering Member {i} ---");

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0)
                {
                    Console.WriteLine("Invalid age entered. Skipping this member...");
                    continue; // skip invalid data
                }

                if (age < 18)
                {
                    Console.WriteLine("Underage citizen detected. Stopping registration process.");
                    break; // stop entire loop
                }

                Console.Write("Enter Annual Income: ");
                double income = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Residency Years: ");
                int residency = Convert.ToInt32(Console.ReadLine());

                // Nested if-else for eligibility scoring
                double score;

                if (residency >= 10)
                {
                    if (income < 300000)
                        score = 120;
                    else
                        score = 90;
                }
                else
                {
                    if (income < 300000)
                        score = 70;
                    else
                        score = 40;
                }

                // Ternary operator
                string category = age >= 60 ? "Senior Citizen" : "Regular Citizen";

                // Determine service package
                string package;

                if (score >= 100)
                    package = "Platinum";
                else if (score >= 80)
                    package = "Gold";
                else if (score >= 50)
                    package = "Silver";
                else
                    package = "Basic";

                // Switch for displaying package
                switch (package)
                {
                    case "Platinum":
                        Console.WriteLine("Assigned: Platinum Package");
                        break;
                    case "Gold":
                        Console.WriteLine("Assigned: Gold Package");
                        break;
                    case "Silver":
                        Console.WriteLine("Assigned: Silver Package");
                        break;
                    default:
                        Console.WriteLine("Assigned: Basic Package");
                        break;
                }

                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Category: {category}");
                Console.WriteLine($"Eligibility Score: {score}");
            }
        }
    }
}
