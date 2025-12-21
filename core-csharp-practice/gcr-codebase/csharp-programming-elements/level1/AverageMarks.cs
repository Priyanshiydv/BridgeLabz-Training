using System;
class AverageMarks
{
    static void Main(string[] args)
    {
        int maths = 94;
        int physics = 95;
        int chemistry = 96;
        double average = (maths + physics + chemistry) / 3.0;

        Console.WriteLine("Sam's average mark in PCM is " + average);
    }
}
