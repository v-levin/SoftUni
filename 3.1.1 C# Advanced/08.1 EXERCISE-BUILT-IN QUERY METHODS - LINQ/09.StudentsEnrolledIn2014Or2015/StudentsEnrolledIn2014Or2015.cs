using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StudentsEnrolledIn2014Or2015
{
    public class StudentsEnrolledIn2014Or2015
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<int[]>();

            while (input != "END")
            {
                var inputArgs = input.Split()
                    .Select(int.Parse)
                    .ToArray();

                students.Add(inputArgs);

                input = Console.ReadLine();
            }

            students
                .Where(s => s[0] % 100 == 14 || s[0] % 100 == 15)
                .Select(s => s.Skip(1))
                .ToList()
                .ForEach(s => Console.WriteLine(string.Join(" ", s)));
        }
    }
}
