using System;

class BMI
{
    static void Main()
    {
        Console.Write("Enter weight in kg: ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter height in cm: ");
        double heightCm = double.Parse(Console.ReadLine());

        double heightMeter = heightCm / 100;
        double bmi = weight / (heightMeter * heightMeter);

        Console.WriteLine($"BMI Value: {bmi:F2}");

        if (bmi <= 18.4)
            Console.WriteLine("Status: Underweight");
        else if (bmi <= 24.9)
            Console.WriteLine("Status: Normal");
        else if (bmi <= 39.9)
            Console.WriteLine("Status: Overweight");
        else
            Console.WriteLine("Status: Obese");
    }
}
