using System;

class StudentGrade
{
    static void Main()
    {
        Console.Write("Enter Physics marks: ");
        int physics = int.Parse(Console.ReadLine());

        Console.Write("Enter Chemistry marks: ");
        int chemistry = int.Parse(Console.ReadLine());

        Console.Write("Enter Maths marks: ");
        int maths = int.Parse(Console.ReadLine());

        int total = physics + chemistry + maths;
        double percentage = total / 3.0;

        char grade;
        string remarks;

        if (percentage >= 80)
        {
            grade = 'A';
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (percentage >= 70)
        {
            grade = 'B';
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (percentage >= 60)
        {
            grade = 'C';
            remarks = "Level 2, below but approaching standards";
        }
        else if (percentage >= 50)
        {
            grade = 'D';
            remarks = "Level 1, well below standards";
        }
        else if (percentage >= 40)
        {
            grade = 'E';
            remarks = "Level 1-, too below standards";
        }
        else
        {
            grade = 'R';
            remarks = "Remedial standards";
        }

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine($"Average Percentage : {percentage:F2}%");
        Console.WriteLine($"Grade              : {grade}");
        Console.WriteLine($"Remarks            : {remarks}");
    }
}
