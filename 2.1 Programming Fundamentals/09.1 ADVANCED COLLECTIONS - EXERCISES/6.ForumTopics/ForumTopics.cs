using System;
using System.Collections.Generic;

namespace _6.ForumTopics
{
    class ForumTopics
    {
        public static void Main()
        {
            var forumTopics = new Dictionary<string, List<string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "filter")
            {
                var tokens = inputLine.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var topic = tokens[0];
                var tags = tokens[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics[topic] = new List<string>();
                }

                foreach (var tag in tags)
                {
                    if (!forumTopics[topic].Contains(tag))
                    {
                        forumTopics[topic].Add(tag);
                    }
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            var tagsToSearch = inputLine.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            bool containsAll = false;
            foreach (var topic in forumTopics.Keys)
            {
                foreach (var tag in tagsToSearch)
                {
                    if (!forumTopics[topic].Contains(tag))
                    {
                        containsAll = false;
                        break;
                    }

                    containsAll = true;
                }

                if (containsAll)
                {
                    var values = string.Empty;

                    foreach (var tag in forumTopics[topic])
                    {
                        values += "#" + tag + " ";
                    }

                    var tags = values.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    Console.WriteLine($"{topic} | {string.Join(", ", tags)}");
                }
            }
        }
    }
}
