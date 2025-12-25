using System;

class RandomNumberStats
{
    // Method to generate array of 4-digit random numbers
    public int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            // Generates a random 4-digit number between 1000 and 9999
            numbers[i] = random.Next(1000, 10000);
        }

        return numbers;
    }

    // Method to find average, minimum, and maximum of an array
    public double[] FindAverageMinMax(int[] numbers)
    {
        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        foreach (int num in numbers)
        {
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }

        double average = (double)sum / numbers.Length;

        // Return results as an array: [average, min, max]
        return new double[] { average, min, max };
    }

    static void Main(string[] args)
    {
        RandomNumberStats obj = new RandomNumberStats();

        // Generate 5 random 4-digit numbers
        int[] randomNumbers = obj.Generate4DigitRandomArray(5);

        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int num in randomNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();

        // Find average, min and max
        double[] result = obj.FindAverageMinMax(randomNumbers);

        Console.WriteLine("Average Value : " + result[0]);
        Console.WriteLine("Minimum Value : " + result[1]);
        Console.WriteLine("Maximum Value : " + result[2]);
    }
}
