using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Websites
{
    public class Websites
    {
        public class Website
        {
            public string Host { get; set; }

            public string Domain { get; set; }

            public List<string> Queries { get; set; }
        }

        public static void Main()
        {
            var websites = new List<Website>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var host = inputParams[0];
                var domain = inputParams[1];
                var queries = inputParams.Skip(2).ToList();

                var website = new Website()
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };

                websites.Add(website);

                inputLine = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[" + string.Join("]&[", website.Queries) + "]");
                    
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
    }
}
