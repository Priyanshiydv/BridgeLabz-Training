using System;

class ParagraphAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        // If paragraph is empty
        if (paragraph.Trim().Length == 0)
        {
            Console.WriteLine("Paragraph is empty!");
            return; 
        }

        // object of the class
        ParagraphAnalyzer obj = new ParagraphAnalyzer();

        // Call method to count words
        int wordCount = obj.CountWords(paragraph);

        // Call method to find longest word
        string longestWord = obj.FindLongestWord(paragraph);
        Console.WriteLine("Total Words: " + wordCount);
        Console.WriteLine("Longest Word: " + longestWord);

        // Take word to replace
        Console.WriteLine("Enter word to replace:");
        string oldWord = Console.ReadLine();
        Console.WriteLine("Enter new word:");
        string newWord = Console.ReadLine();

        // Call replace method
        string newParagraph = obj.ReplaceWord(paragraph, oldWord, newWord);
        Console.WriteLine("Updated Paragraph:");
        Console.WriteLine(newParagraph);
    }

    // Method to count words in the paragraph
    int CountWords(string s)
    {
        string[] words = s.Split(' ');

        int count = 0;

        
        for (int i = 0; i < words.Length; i++)
        {
            // Check word is not empty
            if (words[i].Trim().Length > 0)
            {
                count++;
            }
        }

        return count;
    }

    // Method to find longest word
    string FindLongestWord(string s)
    {
        string[] words = s.Split(' ');

        string longest = "";

        for (int i = 0; i < words.Length; i++)
        {
            
            string word = words[i].Trim();

            // Compare length
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        return longest;
    }
	//Method to replace word
	string ReplaceWord(string s, string oldWord, string newWord)
	{
    string[] words = s.Split(' ');
    string result = "";

    for (int i = 0; i < words.Length; i++)
    {
        // Convert both words to lowercase and compare
        if (words[i].ToLower() == oldWord.ToLower())
        {
            result += newWord;
        }
        else
        {
            result += words[i];
        }

        if (i < words.Length - 1)
        {
            result += " ";
        }
    }
    return result;
	}
}
