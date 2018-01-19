using System;
using System.Text;

namespace Mankind
{
    public class Worker : Human
    {
        private static int workingDays = 5;

        private decimal weekSalary;
        private decimal workingHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workingHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkingHoursPerDay = workingHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkingHoursPerDay
        {
            get { return this.workingHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHoursPerDay = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            return this.WeekSalary / (this.WorkingHoursPerDay * workingDays);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkingHoursPerDay:f2}")
                .Append($"Salary per hour: {this.GetSalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}
