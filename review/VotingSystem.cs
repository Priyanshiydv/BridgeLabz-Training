using System; 

class VotingSystem 
{
    static void Main() 
    {
        
        string[] candidates = { "A", "B", "C", "D" };

        // Vote count
        int[] votes = new int[candidates.Length];

        // Store voter names
        string[] voters = new string[50];

        // Track voter
        bool[] hasVoted = new bool[50];

        // Total registered voters
        int voterCount = 0;

        // Controls program execution
        bool run = true;

        
        while (run)
        {
            Console.WriteLine("\n===== VOTING SYSTEM =====");
            Console.WriteLine("1. Admin (Add Voters)");
            Console.WriteLine("2. User (Vote)");
            Console.WriteLine("3. Result");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            // ADMIN
            if (choice == 1)
            {
                Console.WriteLine("\n--- ADMIN PANEL ---");
                Console.WriteLine("Enter voter names (type stop to finish)");

                // Add voters until limit
                while (voterCount < 50)
                {
                    Console.Write("Voter Name: ");
                    string name = Console.ReadLine();

                    // Stop adding voters
                    if (name.ToLower() == "stop")
                        break;

                    // Store voter name
                    voters[voterCount] = name;

                    // Mark voter as not voted
                    hasVoted[voterCount] = false;

                   
                    Console.WriteLine("Voter added with index: " + voterCount);

                    voterCount++;
                }
            }

            // USER
            else if (choice == 2)
            {
                Console.Write("\nEnter your voter index: ");
                int index = int.Parse(Console.ReadLine());

                // Validate voter index
                if (index < 0 || index >= voterCount)
                {
                    Console.WriteLine("Invalid voter index!");
                    continue;
                }

                // Check if already voted
                if (hasVoted[index])
                {
                    Console.WriteLine("You have already voted!");
                    continue;
                }

                // Show candidates
                Console.WriteLine("\nCandidates:");
                for (int i = 0; i < candidates.Length; i++)
                {
                    Console.WriteLine(i + " - Candidate " + candidates[i]);
                }

                Console.Write("Enter candidate index: ");
                int cIndex = int.Parse(Console.ReadLine());

                // Validate candidate choice
                if (cIndex < 0 || cIndex >= candidates.Length)
                {
                    Console.WriteLine("Invalid candidate!");
                }
                else
                {
                    votes[cIndex]++;          // Add vote
                    hasVoted[index] = true;  // Mark voter as voted
                    Console.WriteLine("Vote submitted successfully!");
                }
            }

            // RESULT
            else if (choice == 3)
            {
                Console.WriteLine("\n--- RESULT ---");

                int maxVotes = votes[0];
                int winner = 0;
                bool tie = false;

                // Find winner or tie
                for (int i = 1; i < votes.Length; i++)
                {
                    if (votes[i] > maxVotes)
                    {
                        maxVotes = votes[i];
                        winner = i;
                        tie = false;
                    }
                    else if (votes[i] == maxVotes)
                    {
                        tie = true;
                    }
                }

                // Display vote count
                for (int i = 0; i < votes.Length; i++)
                {
                    Console.WriteLine("Candidate " + candidates[i] + " = " + votes[i] + " votes");
                }

                // If tie → re-election
                if (tie)
                {
                    Console.WriteLine("\n TIE ");

                    // Reset votes
                    for (int i = 0; i < votes.Length; i++)
                        votes[i] = 0;

                    // Reset voting status
                    for (int i = 0; i < hasVoted.Length; i++)
                        hasVoted[i] = false;
                }
                else
                {
                    Console.WriteLine("\n Winner: Candidate " + candidates[winner]);
                    Console.WriteLine("Won with " + maxVotes + " votes");
                    run = false; // End program
                }
            }

            //  EXIT 
            else if (choice == 0)
            {
                run = false; 
            }

            //INVALID
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
