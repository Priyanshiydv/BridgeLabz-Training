using System;

class HandshakeCalculator
{
    
    public static int CalculateMaximumHandshakes(int numberOfStudents)
    {
        int maximumHandshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        return maximumHandshakes;
    }

    static void Main(string[] args)
    {
        
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());

        
        int result = CalculateMaximumHandshakes(numberOfStudents);

        
        Console.WriteLine("Maximum number of possible handshakes: " + result);
    }
}
