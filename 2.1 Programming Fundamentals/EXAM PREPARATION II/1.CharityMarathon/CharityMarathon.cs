using System;

namespace _1.CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonLengthInDays = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageNumberOfLaps = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var trackCapacity = int.Parse(Console.ReadLine());
            var donatedMoneyPerKilometer = decimal.Parse(Console.ReadLine());

            trackCapacity = trackCapacity * marathonLengthInDays;

            numberOfRunners = Math.Min(trackCapacity, numberOfRunners);

            var totalMeters = (decimal)numberOfRunners * averageNumberOfLaps * trackLength;
            var totalKilometers = totalMeters / 1000;
            var moneyRaised = totalKilometers * donatedMoneyPerKilometer;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
