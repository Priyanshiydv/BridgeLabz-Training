using System;

class NumberGuessingGame
{
    static int GenerateGuess(int low, int high)
    {
        return (low + high) / 2;
    }

    static string GetUserFeedback()
    {
        Console.Write("Is the guess High (H), Low (L), or Correct (C)? ");
        return Console.ReadLine().ToUpper();
    }

    static void PlayGame()
    {
        int low = 1, high = 100;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100.");

        do
        {
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses: " + guess);

            feedback = GetUserFeedback();

            if (feedback == "H")
                high = guess - 1;
            else if (feedback == "L")
                low = guess + 1;

        } while (feedback != "C");

        Console.WriteLine("Computer guessed correctly!");
    }

    static void Main()
    {
        PlayGame();
    }
}
