using System;

class ATMDispenser
{
    static void DispenseCash(int amount, int[] notes)
    {
        Console.WriteLine("\nDispensing Amount: ₹" + amount);

        int remaining = amount;

        for (int i = 0; i < notes.Length; i++)
        {
            int count = remaining / notes[i];

            if (count > 0)
            {
                Console.WriteLine("₹" + notes[i] + " x " + count);
                remaining = remaining % notes[i];
            }
        }

        if (remaining != 0)
        {
            Console.WriteLine("Exact change not possible.");
            Console.WriteLine("Remaining amount: ₹" + remaining);
            Console.WriteLine("Fallback dispensed: ₹" + (amount - remaining));
        }
        else
        {
            Console.WriteLine("Exact amount dispensed successfully.");
        }
    }

    static void Main(string[] args)
    {
        int amount = 880;

        Console.WriteLine("=== Scenario A: All Notes Available ===");
        int[] notesA = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        DispenseCash(amount, notesA);

        Console.WriteLine("\n=== Scenario B: ₹500 Note Removed ===");
        int[] notesB = { 200, 100, 50, 20, 10, 5, 2, 1 };
        DispenseCash(amount, notesB);

        Console.WriteLine("\n=== Scenario C: Exact Change Not Possible ===");
        int[] notesC = { 200, 100, 50 };
        DispenseCash(amount, notesC);

        Console.ReadLine();
    }
}
