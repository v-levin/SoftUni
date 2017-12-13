using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.StudentsByGroup
{
    public class StudentsByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Trim();

            var students = new Dictionary<string, int>();

            while (input != "END")
            {
                var lastIndexOfSpace = input.LastIndexOf(' ');
                var studentFullName = input.Substring(0, lastIndexOfSpace);
                var groupNumber = int.Parse(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Last());

                students.Add(studentFullName, groupNumber);

                input = Console.ReadLine().Trim();
            }

            var result = students.Where(s => s.Value == 2)
                .Select(s => s.Key)
                .OrderBy(s => s)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
