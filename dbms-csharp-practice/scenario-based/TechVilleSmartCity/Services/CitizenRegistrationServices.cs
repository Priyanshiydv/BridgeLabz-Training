using System;

namespace TechVilleSmartCity.Services
{
    public class CitizenRegistrationService
    {
        public void RegisterCitizen()
        {
            Console.WriteLine("=== Welcome to TechVille Citizen Registration Portal ===");
            Console.WriteLine();

            // Step 1: Accept Citizen Details
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Annual Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Residency Years: ");
            int residencyYears = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            // Step 2: Basic Validations
            if (age < 18)
            {
                Console.WriteLine(" Citizen must be at least 18 years old.");
                return;
            }

            if (income < 0 || residencyYears < 0)
            {
                Console.WriteLine(" Income and Residency Years cannot be negative.");
                return;
            }

            // Step 3: Calculate Eligibility Score
            double eligibilityScore = (residencyYears * 10) + (age * 2) - (income / 10000);

            // Step 4: Determine Service Eligibility
            string serviceStatus;

            if (eligibilityScore >= 100)
            {
                serviceStatus = "Full Benefits Eligible";
            }
            else if (eligibilityScore >= 50)
            {
                serviceStatus = "Partial Benefits Eligible";
            }
            else
            {
                serviceStatus = "Not Eligible";
            }

            // Step 5: Display Formatted Output
            Console.WriteLine("===== Citizen Information =====");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Income: {income}");
            Console.WriteLine($"Residency Years: {residencyYears}");
            Console.WriteLine($"Eligibility Score: {eligibilityScore:F2}");
            Console.WriteLine($"Service Status: {serviceStatus}");
        }
    }
}
