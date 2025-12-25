using System;

class SimpleInterestCalculator
{
    // Method to calculate Simple Interest
    public static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        double simpleInterest = (principal * rate * time) / 100;
        return simpleInterest;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter Principal Amount: ");
        double principalAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rateOfInterest = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double timePeriod = Convert.ToDouble(Console.ReadLine());

        double result = CalculateSimpleInterest(principalAmount, rateOfInterest, timePeriod);

        Console.WriteLine($"The Simple Interest is {result} for Principal {principalAmount}, Rate of Interest {rateOfInterest} and Time {timePeriod}");
    }
}
