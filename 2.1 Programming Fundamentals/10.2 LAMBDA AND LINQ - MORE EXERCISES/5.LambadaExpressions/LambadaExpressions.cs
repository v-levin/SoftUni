using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.LambadaExpressions
{
    public class LambadaExpressions
    {
        public static void Main()
        {
            var lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "lambada")
            {
                if (inputLine != "dance")
                {
                    var inputParams = inputLine.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                    var selector = inputParams[0];
                    var selectorObject = inputParams[1];
                    var property = inputParams[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions[selector] = new Dictionary<string, string>();
                    }

                    lambadaExpressions[selector][selectorObject] = property;

                }
                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }

                inputLine = Console.ReadLine();
            }

            lambadaExpressions.ToList().ForEach(selector => selector.Value.ToList().ForEach(selectorObject => Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}")));
        }
    }
}
