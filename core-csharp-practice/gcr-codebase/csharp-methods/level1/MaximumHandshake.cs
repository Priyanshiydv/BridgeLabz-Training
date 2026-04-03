using System;

class MaximumHandshakes
{
   
    public static int CalculateHandshakes(int numberOfStudents)
    {
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        return handshakes;
    }

    static void Main(string[] args)
    {
        
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        
        int totalHandshakes = CalculateHandshakes(numberOfStudents);

        
        Console.WriteLine("Number of possible handshakes: " + totalHandshakes);
    }
}
