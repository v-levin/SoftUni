using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                var employeeInfo = Console.ReadLine().Split();
                var name = employeeInfo[0];
                var salary = decimal.Parse(employeeInfo[1]);
                var position = employeeInfo[2];
                var department = employeeInfo[3];

                var employee = new Employee(name, salary, position, department);

                if (employeeInfo.Length > 4)
                {
                    if (int.TryParse(employeeInfo[4], out int age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        var email = employeeInfo[4];
                        employee.Email = email;
                    }
                }

                if (employeeInfo.Length > 5)
                {
                    var age = int.Parse(employeeInfo[5]);
                    employee.Age = age;
                }

                employees.Add(employee);
            }

            var highestAverageSalaryDepartment = employees
                .GroupBy(em => em.Department)
                .Select(gr => new
                {
                    Name = gr.Key,
                    AverageSalary = gr.Average(em => em.Salary),
                    Employees = gr
                })
                .OrderByDescending(gr => gr.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Name}");

            foreach (var emp in highestAverageSalaryDepartment.Employees.OrderByDescending(em => em.Salary))
            {
                Console.WriteLine(emp.PrintEmployeeInfo());
            }
        }
    }
}
