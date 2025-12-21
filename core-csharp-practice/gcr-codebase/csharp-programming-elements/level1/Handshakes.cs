using System;
class Handshakes
{
    static void Main(string[] args)
    {
        int numberOfStudents;
        Console.Write("Enter number of students: ");
        numberOfStudents = Convert.ToInt32(Console.ReadLine());

        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine(
            "The maximum number of handshakes among "
            + numberOfStudents + " students is " + handshakes
        );
    }
}
