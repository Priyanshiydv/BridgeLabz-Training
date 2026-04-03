using System;

class WordReplacer
{
    
    public static string ReplaceWord(string sentence, string oldWord, string newWord)
    {
        string result = "";
        int i = 0;

        while (i < sentence.Length)
        {
            int matchIndex = 0;

            while (i + matchIndex < sentence.Length &&
                   matchIndex < oldWord.Length &&
                   sentence[i + matchIndex] == oldWord[matchIndex])
            {
                matchIndex++;
            }

            if (matchIndex == oldWord.Length)
            {
                result += newWord;
                i += oldWord.Length;
            }
            else
            {
                result += sentence[i];
                i++;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}
