using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FilterStudentsByPhone
{
    public class FilterStudentsByPhone
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var studentsPhone = new Dictionary<string, string>();

            while (input != "END")
            {
                var indexOfLastSpace = input.LastIndexOf(' ');
                var fullName = input.Substring(0, indexOfLastSpace);
                var phoneNumber = input.Split().Last();

                studentsPhone.Add(fullName, phoneNumber);

                input = Console.ReadLine();
            }

            var result = studentsPhone
                .Where(s => s.Value.StartsWith("02") || s.Value.StartsWith("+3592"))
                .Select(s => s.Key)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
