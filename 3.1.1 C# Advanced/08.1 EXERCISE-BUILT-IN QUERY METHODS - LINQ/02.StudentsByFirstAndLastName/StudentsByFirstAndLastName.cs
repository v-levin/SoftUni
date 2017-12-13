using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StudentsByFirstAndLastName
{
    public class StudentsByFirstAndLastName
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

            var result = students.Where(s => s.Key.CompareTo(s.Value) == -1)
                .ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Key} {student.Value}");
            }
        }
    }
}
