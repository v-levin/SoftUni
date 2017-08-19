using System;
using System.Collections.Generic;

namespace _3.MixedPhones
{
    class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new SortedDictionary<string, long>();

            while (!input.Equals("Over"))
            {
                var currentLine = input.Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var key = currentLine[0];
                var value = currentLine[1];

                var number = 0L;
                if (long.TryParse(key, out number))
                {
                    result[value] = number;
                }
                else
                {
                    result[key] = long.Parse(value);
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                var name = kvp.Key;
                var phoneNumber = kvp.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}
