using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (input != "end")
            {
                var regex = new Regex(@"IP=(.+?)\s+.+?user=(.+)");
                var match = regex.Match(input);
                var ipAddress = match.Groups[1].ToString();
                var user = match.Groups[2].ToString();

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }

                if (!userLogs[user].ContainsKey(ipAddress))
                {
                    userLogs[user].Add(ipAddress, 0);
                }

                userLogs[user][ipAddress]++;

                input = Console.ReadLine();
            }

            PrintResult(userLogs);
        }

        private static void PrintResult(SortedDictionary<string, Dictionary<string, int>> userLogs)
        {
            foreach (var user in userLogs)
            {
                var username = user.Key;
                var ipAddresses = user.Value;

                Console.WriteLine($"{username}: ");
                Console.WriteLine($"{string.Join(", ", ipAddresses.Select(x => $"{x.Key} => {x.Value}"))}.");
            }
        }
    }
}
