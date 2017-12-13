using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterStudentsByEmailDomain
{
    public class FilterStudentsByEmailDomain
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var studentEmails = new Dictionary<string, string>();

            while (input != "END")
            {
                var lastSpaceIndex = input.LastIndexOf(' ');
                var fullName = input.Substring(0, lastSpaceIndex);
                var email = input.Split().Last();

                studentEmails.Add(fullName, email);

                input = Console.ReadLine();
            }

            var result = studentEmails
                .Where(s => s.Value.Contains("gmail"))
                .Select(s => s.Key)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
