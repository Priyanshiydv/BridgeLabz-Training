using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Match
{
    public int match_id { get; set; }
    public string team1 { get; set; }
    public string team2 { get; set; }
    public Dictionary<string, int> score { get; set; }
    public string winner { get; set; }
    public string player_of_match { get; set; }
}

class IPLCensorshipAnalyzer
{
    static void Main()
    {
        string jsonInput = "ipl_input.json";
        string csvInput = "ipl_input.csv";

        CreateSampleFiles(jsonInput, csvInput);

        // Process JSON
        var matchesFromJson = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(jsonInput));
        ApplyCensorship(matchesFromJson);
        File.WriteAllText("ipl_output.json", JsonConvert.SerializeObject(matchesFromJson, Formatting.Indented));

        // Process CSV
        var matchesFromCsv = ReadCsv(csvInput);
        ApplyCensorship(matchesFromCsv);
        WriteCsv("ipl_output.csv", matchesFromCsv);

        Console.WriteLine("Censorship applied! Output files generated.");
    }

    // 🔹 Rule: Mask Team Name
    static string MaskTeamName(string team)
    {
        string[] parts = team.Split(' ');
        if (parts.Length == 2)
            return parts[0] + " ***";
        else if (parts.Length >= 3)
            return parts[0] + " *** " + parts[2];
        return "***";
    }

    // 🔹 Apply censorship rules
    static void ApplyCensorship(List<Match> matches)
    {
        foreach (var match in matches)
        {
            string oldTeam1 = match.team1;
            string oldTeam2 = match.team2;

            match.team1 = MaskTeamName(match.team1);
            match.team2 = MaskTeamName(match.team2);
            match.winner = MaskTeamName(match.winner);
            match.player_of_match = "REDACTED";

            // Fix score dictionary keys
            var newScore = new Dictionary<string, int>();
            foreach (var item in match.score)
            {
                string maskedKey = MaskTeamName(item.Key);
                newScore[maskedKey] = item.Value;
            }
            match.score = newScore;
        }
    }

    // 🔹 Read CSV
    static List<Match> ReadCsv(string path)
    {
        var lines = File.ReadAllLines(path);
        var list = new List<Match>();

        for (int i = 1; i < lines.Length; i++)
        {
            var p = lines[i].Split(',');

            var match = new Match
            {
                match_id = int.Parse(p[0]),
                team1 = p[1],
                team2 = p[2],
                winner = p[5],
                player_of_match = p[6],
                score = new Dictionary<string, int>
                {
                    { p[1], int.Parse(p[3]) },
                    { p[2], int.Parse(p[4]) }
                }
            };

            list.Add(match);
        }
        return list;
    }

    // 🔹 Write CSV
    static void WriteCsv(string path, List<Match> matches)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            sw.WriteLine("match_id,team1,team2,score_team1,score_team2,winner,player_of_match");

            foreach (var m in matches)
            {
                int s1 = m.score[m.team1];
                int s2 = m.score[m.team2];

                sw.WriteLine($"{m.match_id},{m.team1},{m.team2},{s1},{s2},{m.winner},{m.player_of_match}");
            }
        }
    }

    // 🔹 Create Sample Input Files
    static void CreateSampleFiles(string jsonPath, string csvPath)
    {
        string jsonData = @"[
  {
    ""match_id"": 101,
    ""team1"": ""Mumbai Indians"",
    ""team2"": ""Chennai Super Kings"",
    ""score"": { ""Mumbai Indians"": 178, ""Chennai Super Kings"": 182 },
    ""winner"": ""Chennai Super Kings"",
    ""player_of_match"": ""MS Dhoni""
  }
]";
        File.WriteAllText(jsonPath, jsonData);

        string csvData = @"match_id,team1,team2,score_team1,score_team2,winner,player_of_match
101,Mumbai Indians,Chennai Super Kings,178,182,Chennai Super Kings,MS Dhoni";
        File.WriteAllText(csvPath, csvData);
    }
}
