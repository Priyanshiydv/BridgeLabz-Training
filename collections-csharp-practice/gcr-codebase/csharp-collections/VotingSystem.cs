using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>();

        votes.Add("Alice", 0);
        votes.Add("Bob", 0);
        votes.Add("John", 0);

        votes["Alice"]++;
        votes["Bob"]++;
        votes["Alice"]++;
        votes["John"]++;

        SortedDictionary<string, int> sortedVotes =
            new SortedDictionary<string, int>(votes);

        string[] keys = new string[sortedVotes.Count];
        sortedVotes.Keys.CopyTo(keys, 0);

        Console.WriteLine("Voting Results:");
        for (int i = 0; i < keys.Length; i++)
        {
            Console.WriteLine(keys[i] + " : " + sortedVotes[keys[i]]);
        }
    }
}
