using System;
using System.Linq;

namespace _6.Batteries
{
    class Batteries
    {
        static void Main()
        {
            var batteryCapacities = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var usagePerHour = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var amountOfHours = int.Parse(Console.ReadLine());

            for (int i = 0; i < batteryCapacities.Length; i++)
            {
                var currentCapcity = batteryCapacities[i];
                var currentUsagePerHour = usagePerHour[i];
                var batteryStatus = currentCapcity - currentUsagePerHour * amountOfHours;

                if (batteryStatus >= 0)
                {
                    var percentage = batteryStatus / currentCapcity * 100;

                    Console.WriteLine($"Battery {i + 1}: {batteryStatus:F2} mAh ({percentage:F2})%");
                }
                else
                {
                    var hoursLasted = Math.Ceiling(currentCapcity / currentUsagePerHour);

                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursLasted} hours)");
                }
            }
        }
    }
}
