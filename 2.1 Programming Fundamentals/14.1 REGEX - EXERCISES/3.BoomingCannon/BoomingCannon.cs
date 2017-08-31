using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.BoomingCannon
{
    public class BoomingCannon
    {
        public static void Main()
        {
            var destroyedTargets = new List<string>();

            var integers = Console.ReadLine().Split();
            var n = int.Parse(integers[0]);
            var m = int.Parse(integers[1]);

            var @string = Console.ReadLine();

            var pattern = $"\\\\<<<\\w{{{n}}}(\\w{{0,{m}}})";

            var matchedCannons = Regex.Matches(@string, pattern);

            foreach (Match cannon in matchedCannons)
            {
                if (cannon.Groups[1].Value != string.Empty)
                {
                    destroyedTargets.Add(cannon.Groups[1].Value);
                }
            }

            Console.WriteLine(string.Join("/\\", destroyedTargets));
        }
    }
}
