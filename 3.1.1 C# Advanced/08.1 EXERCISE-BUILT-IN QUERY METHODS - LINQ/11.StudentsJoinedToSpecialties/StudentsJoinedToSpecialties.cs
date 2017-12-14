using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.StudentsJoinedToSpecialties
{
    public class StudentSpecialty
    {
        public string specialtyName;

        public int facultyNumber;

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.specialtyName = specialtyName;
            this.facultyNumber = facultyNumber;
        }
    }

    public class Student
    {
        public string studentName;

        public int facultyNumber;

        public Student(string studentName, int facultyNumber)
        {
            this.studentName = studentName;
            this.facultyNumber = facultyNumber;
        }
    }

    public class StudentsJoinedToSpecialties
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var specialties = new List<StudentSpecialty>();
            var students = new List<Student>();

            while (input != "Students:")
            {
                var inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var specialtyName = inputArgs[0] + " " + inputArgs[1];
                var facultyNumber = int.Parse(inputArgs[2]);

                var studentSpecialty = new StudentSpecialty(specialtyName, facultyNumber);
                specialties.Add(studentSpecialty);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                var inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var studentName = inputArgs[1] + " " + inputArgs[2];
                var facultyNumber = int.Parse(inputArgs[0]);

                var student = new Student(studentName, facultyNumber);
                students.Add(student);

                input = Console.ReadLine();
            }

            specialties.Join(students, sp => sp.facultyNumber, st => st.facultyNumber,
                (sp, st) => new
                {
                    Name = st.studentName,
                    FacNumber = st.facultyNumber,
                    Spec = sp.specialtyName
                })
                .OrderBy(s => s.Name)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} {s.FacNumber} {s.Spec}"));
        }
    }
}
