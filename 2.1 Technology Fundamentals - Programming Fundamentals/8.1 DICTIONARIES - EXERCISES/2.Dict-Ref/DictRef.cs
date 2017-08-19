using System;
using System.Collections.Generic;

namespace _2.Dict_Ref
{
    class DictRef
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, int>();

            while (!input.Equals("end"))
            {
                var currentInput = input.Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var key = currentInput[0];
                var value = currentInput[1];

                var number = 0;
                if (int.TryParse(value, out number))
                {
                    result[key] = number;
                }
                else
                {
                    if (result.ContainsKey(value))
                    {
                        var referencedValue = result[value];
                        result[key] = referencedValue;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                var key = kvp.Key;
                var value = kvp.Value;

                Console.WriteLine($"{key} === {value}");
            }
        }
    }
}
