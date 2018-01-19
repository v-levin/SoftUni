using System;

namespace Mankind
{
    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var studentInfo = Console.ReadLine().Split();
                var studentFirstName = studentInfo[0];
                var studentLastName = studentInfo[1];
                var facultyNumber = studentInfo[2];

                var student = new Student(studentFirstName, studentLastName, facultyNumber);

                var workerInfo = Console.ReadLine().Split();
                var workerFirstName = workerInfo[0];
                var workerLastName = workerInfo[1];
                var salary = decimal.Parse(workerInfo[2]);
                var workingHours = decimal.Parse(workerInfo[3]);

                var worker = new Worker(workerFirstName, workerLastName, salary, workingHours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
