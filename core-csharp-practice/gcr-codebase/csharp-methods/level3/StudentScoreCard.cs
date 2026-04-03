using System;

class StudentScoreCard
{
    // Method to generate random PCM marks
    public static int[,] GeneratePCMMarks(int students)
    {
        int[,] marks = new int[students, 3];
        Random random = new Random();

        for (int i = 0; i < students; i++)
        {
            marks[i, 0] = random.Next(10, 100); // Physics
            marks[i, 1] = random.Next(10, 100); // Chemistry
            marks[i, 2] = random.Next(10, 100); // Maths
        }

        return marks;
    }

    // Method to calculate Total, Average, Percentage
    public static double[,] CalculateResults(int[,] marks, int students)
    {
        double[,] results = new double[students, 3];

        for (int i = 0; i < students; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double average = total / 3.0;
            double percentage = (total / 300.0) * 100;

            results[i, 0] = total;
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    // Method to display scorecard
    public static void DisplayScoreCard(int[,] marks, double[,] results, int students)
    {
        Console.WriteLine("\nStudent\tPhysics\tChem\tMaths\tTotal\tAverage\tPercentage");

        for (int i = 0; i < students; i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                marks[i, 0] + "\t" +
                marks[i, 1] + "\t" +
                marks[i, 2] + "\t" +
                results[i, 0] + "\t" +
                results[i, 1] + "\t" +
                results[i, 2]
            );
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int[,] marks = GeneratePCMMarks(students);
        double[,] results = CalculateResults(marks, students);

        DisplayScoreCard(marks, results, students);
    }
}
