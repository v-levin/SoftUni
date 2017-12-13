using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.StudentsByAge
{
    public class StudentsByAge
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var students = new Dictionary<string, int>();

            while (input != "END")
            {
                var lastIndexOfSpace = input.LastIndexOf(' ');
                var studentFullName = input.Substring(0, lastIndexOfSpace);
                var age = int.Parse(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last());

                students.Add(studentFullName, age);

                input = Console.ReadLine();
            }

            var result = students.Where(s => s.Value >= 18 && s.Value <= 24)
                .Select(s => $"{s.Key} {s.Value}")
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
