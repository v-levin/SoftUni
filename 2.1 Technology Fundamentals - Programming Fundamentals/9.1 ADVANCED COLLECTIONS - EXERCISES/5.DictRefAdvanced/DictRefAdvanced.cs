using System;
using System.Collections.Generic;

namespace _5.DictRefAdvanced
{
    class DictRefAdvanced
    {
        public static void Main()
        {
            var refDict = new Dictionary<string, List<int>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var tokens = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var value = tokens[1];

                int number = 0;
                if (int.TryParse(value, out number))
                {
                    if (!refDict.ContainsKey(name))
                    {
                        refDict[name] = new List<int>();
                    }

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        var currentValue = int.Parse(tokens[i]);
                        refDict[name].Add(currentValue);
                    }
                }
                else
                {
                    if (refDict.ContainsKey(value))
                    {
                        refDict[name] = new List<int>(refDict[value]);
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var data in refDict)
            {
                var name = data.Key;
                var values = data.Value;

                Console.WriteLine($"{name} === {string.Join(", ", values)}");
            }
        }
    }
}
