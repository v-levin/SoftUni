using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _8.Commits
{

    public class Commit
    {
        public string Hash { get; set; }

        public string Message { get; set; }

        public int Additions { get; set; }

        public int Deletions { get; set; }

        public Commit(string hash, string message, int additions, int deletions)
        {
            Hash = hash;
            Message = message;
            Additions = additions;
            Deletions = deletions;
        }
    }

    public class Commits
    {
        public static void Main()
        {

            var commitsData = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            var pattern = @"^https:\/\/github\.com\/(?<user>[A-Za-z0-9-]+)\/(?<repo>[A-Za-z-_]+)\/commit\/(?<hash>[A-Fa-f0-9]{40}),(?<message>[^\n]+),(?<additions>\d+),(?<deletions>\d+)$";
            var urlPattern = new Regex(pattern);

            var inputLine = Console.ReadLine();

            while (inputLine != "git push")
            {
                if (urlPattern.IsMatch(inputLine))
                {
                    var url = urlPattern.Match(inputLine);

                    var user = url.Groups["user"].Value;
                    var repo = url.Groups["repo"].Value;
                    var hash = url.Groups["hash"].Value;
                    var message = url.Groups["message"].Value;
                    var additions = int.Parse(url.Groups["additions"].Value);
                    var deletions = int.Parse(url.Groups["deletions"].Value);

                    var commit = new Commit(hash, message, additions, deletions);

                    if (!commitsData.ContainsKey(user))
                    {
                        commitsData[user] = new SortedDictionary<string, List<Commit>>();
                    }

                    if (!commitsData[user].ContainsKey(repo))
                    {
                        commitsData[user][repo] = new List<Commit>();
                    }

                    commitsData[user][repo].Add(commit);
                }

                inputLine = Console.ReadLine();
            }

            foreach (var userCommit in commitsData)
            {
                var user = userCommit.Key;
                var reposData = userCommit.Value;

                Console.WriteLine($"{user}:");

                foreach (var repoData in reposData)
                {
                    var repo = repoData.Key;
                    var commits = repoData.Value;

                    Console.WriteLine($"  {repo}:");

                    var totalAdditions = commits.Sum(c => c.Additions);
                    var totalDeletions = commits.Sum(c => c.Deletions);

                    foreach (var commit in commits)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }

                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }
        }
    }
}
