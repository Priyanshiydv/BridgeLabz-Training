using System;
class PenDistribution
{
    static void Main(string[] args)
    {
        int totalPens = 14;
        int totalStudents = 3;
        int pensPerStudent = totalPens / totalStudents;
        int remainingPens = totalPens % totalStudents;

        Console.WriteLine(
            "The Pen Per Student is " + pensPerStudent +
            " and the remaining pen not distributed is " + remainingPens
        );
    }
}
