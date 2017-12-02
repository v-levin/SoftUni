using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _09.QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"([^&=?]*)=([^&=]*)";
            var regex = new Regex(pattern);
            

            while (input != "END")
            {
                var queries = new Dictionary<string, List<string>>();
                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    // replace '+' and '%20' with 'space' 
                    var whiteSpacePattern = @"(?:%20|\+)+";
                    var key = match.Groups[1].Value;
                    key = Regex.Replace(key, whiteSpacePattern, " ").Trim();
                    var value = match.Groups[2].Value;
                    value = Regex.Replace(value, whiteSpacePattern, " ").Trim();

                    if (!queries.ContainsKey(key))
                    {
                        queries.Add(key, new List<string>());
                    }

                    queries[key].Add(value);
                }

                foreach (var query in queries)
                {
                    Console.Write($"{query.Key}=[{string.Join(", ", query.Value)}]");
                }

                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
