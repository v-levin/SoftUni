using System;

namespace DailyEarnings
{
    class Program
    {
        static void Main()
        {
            var workDays = int.Parse(Console.ReadLine());
            var dailyWage = double.Parse(Console.ReadLine());
            var change = double.Parse(Console.ReadLine());

            var monthlyWage = workDays * dailyWage;
            var annualWage = monthlyWage * 12 + monthlyWage * 2.5;
            var tax = annualWage * 25 / 100;
            var yearlyEarnings = annualWage - tax;
            var yearlyEarningsInBGN = yearlyEarnings * change;
            var avgDailyEarnings = yearlyEarningsInBGN / 365;

            Console.WriteLine(Math.Round(avgDailyEarnings, 2));

        }
    }
}