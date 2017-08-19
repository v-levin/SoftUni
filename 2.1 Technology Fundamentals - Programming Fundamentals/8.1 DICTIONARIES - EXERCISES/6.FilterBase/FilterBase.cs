using System;
using System.Collections.Generic;

namespace _6.FilterBase
{
    class FilterBase
    {
        public static void Main()
        {
            var ageDict = new Dictionary<string, int>();
            var salaryDict = new Dictionary<string, double>();
            var positionDict = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "filter base")
            {
                var currentInput = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = currentInput[0];
                var employeeInformation = currentInput[1];

                int age = 0;
                double salary = 0;

                if (int.TryParse(employeeInformation, out age))
                {
                    if (!ageDict.ContainsKey(name))
                    {
                        ageDict[name] = age;
                    }

                    ageDict[name] = age;
                }
                else if (double.TryParse(employeeInformation, out salary))
                {
                    if (!salaryDict.ContainsKey(name))
                    {
                        salaryDict[name] = salary;
                    }

                    salaryDict[name] = salary;
                }
                else
                {
                    var position = employeeInformation;

                    if (!positionDict.ContainsKey(name))
                    {
                        positionDict[name] = position;
                    }

                    positionDict[name] = position;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            switch (input)
            {
                case "Age":
                    foreach (var kvp in ageDict)
                    {
                        var name = kvp.Key;
                        var age = kvp.Value;

                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Age: {age}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;

                case "Salary":
                    foreach (var kvp in salaryDict)
                    {
                        var name = kvp.Key;
                        var salary = kvp.Value;

                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Salary: {salary:F2}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;

                case "Position":
                    foreach (var kvp in positionDict)
                    {
                        var name = kvp.Key;
                        var position = kvp.Value;

                        Console.WriteLine($"Name: {name}");
                        Console.WriteLine($"Position: {position}");
                        Console.WriteLine(new string('=', 20));
                    }
                    break;
            }
        }
    }
}
