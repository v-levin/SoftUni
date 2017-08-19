using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.LINQuistics
{
    public class LINQuistics
    {
        public static void Main()
        {
            var linquistic = new Dictionary<string, List<string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                var inputParams = inputLine.Split(new[] { '.', '(', ')', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var digit = 0;
                if (inputParams.Length > 1)
                {
                    var collection = inputParams[0];
                    var methods = inputParams.Skip(1).ToList();

                    if (!linquistic.ContainsKey(collection))
                    {
                        linquistic[collection] = new List<string>();
                    }

                    foreach (var method in methods)
                    {
                        if (!linquistic[collection].Contains(method))
                        {
                            linquistic[collection].Add(method);
                        }
                    }
                }
                else if (int.TryParse(inputLine, out digit))
                {
                    var collectionWithMostMethods = linquistic.OrderByDescending(x => x.Value.Count).Select(x => x.Key).First();

                    if (linquistic[collectionWithMostMethods].Count < digit)
                    {
                        linquistic[collectionWithMostMethods].OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine($"* {x}"));
                    }
                    else
                    {
                        linquistic[collectionWithMostMethods].OrderBy(x => x.Length).Take(digit).ToList().ForEach(x => Console.WriteLine($"* {x}"));
                    }
                }
                else
                {
                    var collection = inputLine;

                    if (linquistic.ContainsKey(collection))
                    {
                        linquistic[collection].OrderByDescending(x => x.Length).ThenByDescending(x => x.Distinct().Count()).ToList().ForEach(x => Console.WriteLine($"* {x}"));
                    }
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            var inputParameters = inputLine.Split();
            var methodToCheck = inputParameters[0];
            var selection = inputParameters[1];

            switch (selection)
            {
                case "all":
                    GetAllCollectionsAndMethods(linquistic, methodToCheck);
                    break;
                case "collection":
                    GetAllCollections(linquistic, methodToCheck);
                    break;
            }
        }

        static void GetAllCollections(Dictionary<string, List<string>> linquistic, string methodToCheck)
        {
            linquistic.Where(x => x.Value.Contains(methodToCheck)).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value.Min()).Select(x => x.Key).ToList().ForEach(Console.WriteLine);
        }

        static void GetAllCollectionsAndMethods(Dictionary<string, List<string>> linquistic, string methodToCheck)
        {
            var linquisticKeys = linquistic.Where(x => x.Value.Contains(methodToCheck)).OrderByDescending(x => x.Value.Count).ThenByDescending(x => x.Value.Min()).Select(x => x.Key).ToList();

            foreach (var linquisticKey in linquisticKeys)
            {
                Console.WriteLine($"{linquisticKey}");

                linquistic[linquisticKey].OrderByDescending(x => x.Length).ToList().ForEach(x => Console.WriteLine($"* {x}"));
            }
        }
    }
}
