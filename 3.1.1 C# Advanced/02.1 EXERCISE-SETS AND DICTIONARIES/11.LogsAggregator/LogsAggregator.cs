using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.LogsAggregator
{
    public class LogsAggregator
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var inputParams = Console.ReadLine().Split();
                var ipAddress = inputParams[0];
                var user = inputParams[1];
                var duration = int.Parse(inputParams[2]);

                if (!userLogs.ContainsKey(user))
                {
                    userLogs.Add(user, new SortedDictionary<string, int>());
                }

                if (!userLogs[user].ContainsKey(ipAddress))
                {
                    userLogs[user].Add(ipAddress, duration);
                }
                else
                {
                    userLogs[user][ipAddress] += duration;
                }
            }

            foreach (var log in userLogs)
            {
                var user = log.Key;
                var ipAdresses = log.Value.Keys.ToArray();
                var totalDuration = log.Value.Values.Sum();

                Console.WriteLine($"{user}: {totalDuration} [{string.Join(", ", ipAdresses)}]");
            }
        }
    }
}
