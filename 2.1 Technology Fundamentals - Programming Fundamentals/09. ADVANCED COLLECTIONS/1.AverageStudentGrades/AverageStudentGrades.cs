using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.AverageStudentGrades
{
    class AverageStudentGrades
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var namesAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine().Split( ' ' );

                var name = input[0];
                var grade = double.Parse(input[1]);

                if (!namesAndGrades.ContainsKey(name))
                {
                    namesAndGrades[name] = new List<double>();
                }

                namesAndGrades[name].Add(grade);
            }

            foreach (var kvp in namesAndGrades)
            {
                var name = kvp.Key;
                var studentGrades = kvp.Value;
                var average = studentGrades.Average();

                Console.Write($"{name} -> ");

                foreach (var grade in studentGrades)
                    Console.Write($"{grade:F2} ");

                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
