using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.GroupByGroup
{
    public class Person
    {
        public string name;

        public int group;

        public Person(string name, int group)
        {
            this.name = name;
            this.group = group;
        }
    }

    public class GroupByGroup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<Person>();

            while (input != "END")
            {
                var lastSpaceIndex = input.LastIndexOf(' ');
                var fullName = input.Substring(0, lastSpaceIndex);
                var group = int.Parse(input.Split().Last());

                var student = new Person(fullName, group);

                students.Add(student);

                input = Console.ReadLine();
            }

            var sorted = students
                .GroupBy(s => s.group)
                .OrderBy(s => s.Key);

            foreach (var outerElement in sorted)
            {
                Console.Write($"{outerElement.Key} - ");

                var sb = new StringBuilder();
                foreach (var student in outerElement)
                {
                    sb.Append($"{student.name}, ");
                }

                sb.Remove(sb.Length - 2, 1);
                Console.WriteLine(sb);
            }
        }
    }
}
