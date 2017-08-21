using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _1.RegisteredUsers
{
    public class RegisteredUsers
    {
        public static void Main()
        {
            var registeredUsernames = new Dictionary<string, DateTime>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var username = inputParams[0];
                var registeryDate = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registeredUsernames[username] = registeryDate;

                inputLine = Console.ReadLine();
            }

            var orderedUsernames = registeredUsernames
                .Reverse()
                .OrderBy(n => n.Value)
                .Take(5)
                .OrderByDescending(n => n.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine(string.Join(Environment.NewLine, orderedUsernames.Keys));
        }
    }
}
