using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.DefaultValues
{
    public class DefaultValues
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var key = inputParams[0];
                var value = inputParams[1];

                dictionary[key] = value;

                inputLine = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .Select(x => x.Key + " <-> " + x.Value)
                .ToList()
                .ForEach(Console.WriteLine);

            dictionary
                .Where(x => x.Value == "null")
                .Select(x => x.Key + " <-> " + defaultValue)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
