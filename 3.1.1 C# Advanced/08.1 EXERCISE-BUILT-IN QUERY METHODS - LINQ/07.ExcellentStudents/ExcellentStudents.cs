using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ExcellentStudents
{
    public class ExcellentStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string>();

            while (input != "END")
            {
                students.Add(input);

                input = Console.ReadLine();
            }

            var excellentStudents = students
                .Where(s => s.Contains("6"))
                .Select(s => s.Split())
                .Select(s => $"{s[0]} {s[1]}")
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, excellentStudents));
        }
    }
}
