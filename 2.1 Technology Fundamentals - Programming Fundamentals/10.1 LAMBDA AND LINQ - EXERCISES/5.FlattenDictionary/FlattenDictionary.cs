using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.FlattenDictionary
{
    public class FlattenDictionary
    {
        public static void Main()
        {
            var productsDict = new Dictionary<string, Dictionary<string, string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split();

                if (inputParams[0] != "flatten")
                {
                    var product = inputParams[0];
                    var makeName = inputParams[1];
                    var productName = inputParams[2];

                    if (!productsDict.ContainsKey(product))
                    {
                        productsDict[product] = new Dictionary<string, string>();
                    }

                    productsDict[product][makeName] = productName;
                }
                else
                {
                    var product = inputParams[1];

                    productsDict[product] = productsDict[product].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                inputLine = Console.ReadLine();
            }

            var counter = 1;

            foreach (var product in productsDict.Keys.OrderByDescending(x => x.Length))
            {
                Console.WriteLine(product);

                productsDict[product]
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{counter++}. {x.Key} - {x.Value}"));

                productsDict[product]
                    .Where(x => x.Value == "flattened")
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{counter++}. {x.Key}"));

                counter = 1;
            }
        }
    }
}
