using System;
using System.Linq;

namespace _06_PowerPlants
{
    class PowerPlants
    {
        static void Main()
        {
            int[] powerLevel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int days = 0;
            int daysOfSeason = 0;
            int season = powerLevel.Length - 1;
            int seasons = 0;

            bool allZeros = powerLevel.All(x => x == 0);

            while (!allZeros)
            {
                allZeros = GetRestOfPower(powerLevel, daysOfSeason, allZeros);

                days++;
                daysOfSeason++;

                if (allZeros) break;

                GetSeasons(powerLevel, ref season, ref seasons, ref daysOfSeason);

                season--;
            }

            GetResult(days, seasons);
        }

        static void GetResult(int days, int seasons)
        {
            if (seasons == 1)
            {
                Console.WriteLine($"survived {days} days ({seasons} season)");
            }
            else
            {
                Console.WriteLine($"survived {days} days ({seasons} seasons)");
            }
        }

        static void GetSeasons(int[] powerLevel, ref int season, ref int seasons, ref int daysOfSeason)
        {
            if (season == 0)
            {
                for (int i = 0; i < powerLevel.Length; i++)
                {
                    if (powerLevel[i] > 0)
                    {
                        powerLevel[i]++;
                    }
                }

                seasons++;
                season = powerLevel.Length;
                daysOfSeason = 0;
            }
        }

        static bool GetRestOfPower(int[] powerLevel, int daysOfSeason, bool allZeros)
        {
            for (int i = 0; i < powerLevel.Length; i++)
            {

                if (i == daysOfSeason)
                {
                    powerLevel[i]++;
                }

                if (powerLevel[i] > 0)
                {
                    powerLevel[i]--;
                }
            }

            allZeros = powerLevel.All(x => x == 0);
            return allZeros;
        }
    }
}
