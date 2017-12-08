using System;
using System.Collections.Generic;

namespace _5.FilterByAge
{
    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                people.Add(input[0], int.Parse(input[1]));
            }

            var condition = Console.ReadLine();
            var ageFilter = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int, bool> tester = CreateTester(condition, ageFilter);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            PrintFilteredStudents(people, tester, printer);
        }

        private static Func<int, bool> CreateTester(string condition, int ageFilter)
        {
            switch (condition)
            {
                case "younger": return x => x < ageFilter;
                case "older": return x => x >= ageFilter;
                default: return null;
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => Console.WriteLine($"{p.Key}");
                case "age":
                    return p => Console.WriteLine($"{p.Value}");
                case "name age":
                    return p => Console.WriteLine($"{p.Key} - {p.Value}");
                default: return null;
            }
        }

        private static void PrintFilteredStudents(Dictionary<string, int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }
    }
}
