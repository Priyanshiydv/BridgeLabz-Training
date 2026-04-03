using System;

class FriendsComparison
{
    public static int FindYoungest(int[] ages)
    {
        int minAge = ages[0];
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
                minAge = ages[i];
        }
        return minAge;
    }

    public static double FindTallest(double[] heights)
    {
        double maxHeight = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
                maxHeight = heights[i];
        }
        return maxHeight;
    }

    static void Main(string[] args)
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter age of " + names[i] + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height of " + names[i] + ": ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Youngest Age: " + FindYoungest(ages));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
    }
}
