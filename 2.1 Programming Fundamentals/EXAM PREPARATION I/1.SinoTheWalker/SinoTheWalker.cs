using System;
using System.Globalization;

namespace _1.SinoTheWalker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var timeFormat = "HH:mm:ss";
            var timeLeaves = DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
            var numberOfSteps = decimal.Parse(Console.ReadLine());
            var secondsPerStep = decimal.Parse(Console.ReadLine());

            var secondsInADay = 60 * 60 * 24;
            var totalSeconds = (int)(numberOfSteps * secondsPerStep % secondsInADay);

            var arrivalTime = timeLeaves.AddSeconds(totalSeconds);

            Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");
        }
    }
}
