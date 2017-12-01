using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var usernames = Console.ReadLine().Split(new[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            var validUsernames = new List<string>();
            var pattern = @"^[a-zA-Z]\w{2,24}$";
            var regex = new Regex(pattern);

            // check for valid usernames
            foreach (var username in usernames)
            {
                var isMatch = regex.IsMatch(username);

                if (isMatch)
                {
                    validUsernames.Add(username);
                }
            }

            var biggestSum = 0;
            var firstUsername = string.Empty;
            var secondUsername = string.Empty;

            // check for 2 valid usernames with biggest sum
            for (int i = 1; i < validUsernames.Count; i++)
            {
                var currnetSum = validUsernames[i - 1].Length + validUsernames[i].Length;

                if (biggestSum < currnetSum)
                {
                    biggestSum = currnetSum;
                    firstUsername = validUsernames[i - 1];
                    secondUsername = validUsernames[i];
                }
            }

            Console.WriteLine($"{firstUsername}\n{secondUsername}");
        }
    }
}
