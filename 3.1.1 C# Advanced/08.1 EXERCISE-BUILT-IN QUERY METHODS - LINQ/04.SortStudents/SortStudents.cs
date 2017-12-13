using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortStudents
{
    public class SortStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<KeyValuePair<string, string>>();

            while (input != "END")
            {
                var tokens = input.Split();
                var firstName = tokens[0];
                var lastName = tokens[1];

                students.Add(new KeyValuePair<string, string>(firstName, lastName));

                input = Console.ReadLine();
            }

            var result = students.OrderBy(s => s.Value)
                .ThenByDescending(s => s.Key)
                .Select(s => $"{s.Key} {s.Value}")
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
