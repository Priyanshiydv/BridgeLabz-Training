using System;

class BMICalculator
{
    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double weight = data[i, 0];
            double heightCm = data[i, 1];
            double heightM = heightCm / 100;

            data[i, 2] = weight / (heightM * heightM);
        }
    }

    public static string[] GetBMIStatus(double[,] data)
    {
        string[] status = new string[10];

        for (int i = 0; i < 10; i++)
        {
            double bmi = data[i, 2];

            if (bmi < 18.5)
                status[i] = "Underweight";
            else if (bmi < 25)
                status[i] = "Normal";
            else if (bmi < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }
        return status;
    }

    static void Main(string[] args)
    {
        double[,] personData = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight (kg) of person " + (i + 1) + ": ");
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (cm) of person " + (i + 1) + ": ");
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        CalculateBMI(personData);
        string[] status = GetBMIStatus(personData);

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Person " + (i + 1) +
                " Weight: " + personData[i, 0] +
                " Height: " + personData[i, 1] +
                " BMI: " + personData[i, 2] +
                " Status: " + status[i]);
        }
    }
}
