using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.JSONStringify
{
    public class JSONStringify
    {
        public class Student
        {
            public string Name { get; set; }

            public int Age { get; set; }

            public List<int> Grades { get; set; }
        }

        static List<Student> students = new List<Student>();

        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "stringify")
            {
                var inputParams = inputLine.Split(new[] { ':', '-', '>', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = inputParams[0].Trim();
                var age = int.Parse(inputParams[1].Trim());
                var grades = inputParams.Skip(2).Select(int.Parse).ToList();

                AddStudent(name, age, grades);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(",", students.Select(x => $"{{name:\"{x.Name}\",age:{x.Age},grades:[{string.Join(", ", x.Grades)}]}}")) + "]");
        }

        private static void AddStudent(string name, int age, List<int> grades)
        {
            var student = new Student()
            {
                Name = name,
                Age = age,
                Grades = new List<int>(grades)
            };

            students.Add(student);
        }
    }
}
