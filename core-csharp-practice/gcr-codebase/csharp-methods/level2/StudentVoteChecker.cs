using System;

public class StudentVoteChecker
{
    // Method to check voting eligibility
    public static bool CanStudentVote(int age)
    {
        if (age < 0)
            return false;

        if (age >= 18)
            return true;

        return false;
    }

    static void Main(string[] args)
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            bool canVote = CanStudentVote(ages[i]);

            if (canVote)
                Console.WriteLine("Student can vote");
            else
                Console.WriteLine("Student cannot vote");
        }
    }
}
