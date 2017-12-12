using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.FirstName
{
    public class FirstName
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split()
                .OrderBy(n => n)
                .ToList();

            var letters = Console.ReadLine()
                .Split()
                .Select(l => l.ToLower())
                .OrderBy(l => l)
                .ToList();

            var result = new List<string>();

            foreach (var letter in letters)
            {
                result.AddRange(names.Where(n => n.ToLower().StartsWith(letter)));
            }

            if (result.Any())
            {
                Console.WriteLine(result.First());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
