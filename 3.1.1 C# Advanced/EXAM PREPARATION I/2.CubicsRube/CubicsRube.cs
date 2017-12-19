using System;
using System.Linq;

namespace _2.CubicsRube
{
    public class CubicsRube
    {
        public static void Main()
        {
            var cubeDimension = int.Parse(Console.ReadLine());

            var sumOfParticles = 0L;
            var changedCells = 0;
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Analyze")
            {
                var tokens = inputLine
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (tokens.Take(3).Any(p => p < 0 || p >= cubeDimension))
                {
                    continue;
                }

                if (tokens.Last() != 0)
                {
                    sumOfParticles += tokens.Last();
                    changedCells++;
                }
            }

            Console.WriteLine(sumOfParticles);
            Console.WriteLine(Math.Pow(cubeDimension, 3) - changedCells);
        }
    }
}
