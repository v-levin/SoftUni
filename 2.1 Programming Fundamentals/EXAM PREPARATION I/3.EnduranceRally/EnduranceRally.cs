using System;
using System.Linq;

namespace _3.EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var driversNames = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(z => double.Parse(z)).ToArray();
            var checkpointIndexes = Console.ReadLine().Split().Select(z => int.Parse(z)).ToArray();
            
            foreach (var driver in driversNames)
            {
                var success = true;
                var fuel = (double)driver[0];
                var zoneIndex = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpointIndexes.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel <= 0)
                    {
                        zoneIndex = i;
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {zoneIndex}");
                }
            }
        }
    }
}
