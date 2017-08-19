using System;
using System.Collections.Generic;

namespace _2.Key_KeyValue_Value
{
    class KeyKeValueValue
    {
        public static void Main()
        {
            var keyValueDict = new Dictionary<string, List<string>>();

            var key = Console.ReadLine();
            var value = Console.ReadLine();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                var inputKey = input[0];
                var inputValue = input[1].Split(';');

                if (!keyValueDict.ContainsKey(inputKey))
                {
                    keyValueDict[inputKey] = new List<string>();
                }

                foreach (var val in inputValue)
                {
                    keyValueDict[inputKey].Add(val);
                }
            }

            foreach (var keyInDict in keyValueDict)
            {
                var keyDict = keyInDict.Key;
                var valuesDict = keyInDict.Value;

                if (keyDict.Contains(key))
                {
                    var valuesToPrint = new List<string>();

                    foreach (var val in valuesDict)
                    {
                        if (val.Contains(value))
                        {
                            valuesToPrint.Add(val);
                        }
                    }

                    Console.WriteLine($"{keyDict}:");

                    foreach (var val in valuesToPrint)
                    {
                        Console.WriteLine($"-{val}");
                    }
                }
            }
        }
    }
}
