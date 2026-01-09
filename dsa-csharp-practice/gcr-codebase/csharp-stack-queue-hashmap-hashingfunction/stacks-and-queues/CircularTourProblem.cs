using System;

class CircularTour
{
    static int FindStart(int[] petrol, int[] distance)
    {
        int start = 0;
        int surplus = 0;
        int deficit = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            surplus += petrol[i] - distance[i];

            if (surplus < 0)
            {
                start = i + 1;
                deficit += surplus;
                surplus = 0;
            }
        }

        return (surplus + deficit >= 0) ? start : -1;
    }

    static void Main()
    {
        int[] petrol = { 6, 3, 7 };
        int[] distance = { 4, 6, 3 };

        int startPoint = FindStart(petrol, distance);

        if (startPoint == -1)
            Console.WriteLine("No possible tour");
        else
            Console.WriteLine("Start at petrol pump: " + startPoint);
    }
}
