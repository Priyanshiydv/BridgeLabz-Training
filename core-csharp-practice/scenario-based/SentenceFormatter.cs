using System;

//29-12-2025
class SentenceFormatter
{
    static void Main()
    {
		Console.WriteLine("Write a Paragraph!");
        string[] sentence = Console.ReadLine().Split('.');
		
		SentenceFormatter obj = new SentenceFormatter(); // object created
		
        for(int i = 0; i < sentence.Length-1; i++)
        {
            Console.WriteLine(obj.FormatSentence(sentence[i]));//object call
        }

    }
    string FormatSentence(string s)
    {
        s = s.Trim();
        string formatted = "";
		
		if (s.Length == 0)
            return "";
		
		//for capitalize
        if(s[0] >= 'a' && s[0] <= 'z')
        {
            formatted += (char)(s[0] - 32);
        }
        else
        {
            formatted += s[0];
        }
		
        for(int i = 1; i < s.Length; i++)
        {
			//add space
            if(s[i] == ',' || s[i] == ';')
            {
                formatted += s[i] + " ";
					
            }
			else if (s[i] >= 'A' && s[i] <= 'Z')
            {
                formatted += (char)(s[i] + 32);
            }
			
            else if(s[i] == ' ' && s[i-1] == ' ')
            {
                continue;
            }
            else
            {
                formatted += s[i];
            }
        }
        return formatted + '.';
    }
}