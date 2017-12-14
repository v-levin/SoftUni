using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.WeakStudents
{
    public class WeakStudents
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string[]>();

            while (input != "END")
            {
                var inputArgs = input.Split();

                students.Add(inputArgs);

                input = Console.ReadLine();
            }

            students
                .Where(s => s.Skip(2).Count(n => int.Parse(n) <= 3) >= 2)
                .Select(s => $"{s[0]} {s[1]}")
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
