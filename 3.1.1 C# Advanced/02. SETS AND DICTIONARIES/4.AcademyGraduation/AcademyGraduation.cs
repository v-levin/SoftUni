using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.AcademyGraduation
{
    public class AcademyGraduation
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());
            var students = new SortedDictionary<string, double[]>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var studentName = Console.ReadLine();
                var studentScores = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

                students.Add(studentName, studentScores);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
