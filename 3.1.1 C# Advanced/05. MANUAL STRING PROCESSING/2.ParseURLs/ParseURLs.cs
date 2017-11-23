using System;
using System.Linq;

namespace _2.ParseURLs
{
    public class ParseURLs
    {
        public static void Main()
        {
            var url = Console.ReadLine();
            var separator = "://";

            var urlTokens = url.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            if (urlTokens.Length != 2 || !urlTokens[1].Contains('/'))
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var protocol = urlTokens[0];
            var indexResources = urlTokens[1].IndexOf('/');
            var server = urlTokens[1].Substring(0, indexResources);
            var resources = urlTokens[1].Substring(indexResources + 1);

            Console.WriteLine($"Protocol = {protocol}\nServer = {server}\nResources = {resources}");
        }
    }
}
