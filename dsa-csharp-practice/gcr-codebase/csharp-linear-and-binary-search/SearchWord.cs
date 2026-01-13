using System;

class SearchWord
{
    static void Main()
    {
        string[] sentences = {
            "I love C#",
            "Java is powerful",
            "C# is easy"
        };

        string searchWord = "easy";

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(searchWord))
            {
                Console.WriteLine("Found in: " + sentences[i]);
                break;
            }
        }
    }
}
