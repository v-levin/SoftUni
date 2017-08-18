using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_Winecraft
{
    class Winecraft
    {
        static List<int> grapes;

        static void Main()
        {
            grapes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var growthDays = int.Parse(Console.ReadLine());

            bool isLessThanGrowthDays = grapes.Where(e => e > growthDays).Count() >= growthDays;

            do
            {
                for (int rount = 0; rount < growthDays; rount++)
                {
                    IncrementGrapes();

                    ProcessGrapes();
                }

                SetToZeroGrapesSmallerThanGrowthDays(growthDays);

                isLessThanGrowthDays = grapes.Where(e => e > growthDays).Count() >= growthDays;
            }
            while (isLessThanGrowthDays);

            Console.WriteLine(string.Join(" ", grapes.Where(e => e > growthDays)));
        }

        private static void SetToZeroGrapesSmallerThanGrowthDays(int growthDays)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                var currentGrape = grapes[i];
                if (currentGrape <= growthDays)
                {
                    grapes[i] = 0;
                }
            }
        }

        private static void ProcessGrapes()
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                var isFirstElement = i == 0;
                var isLastElement = i == grapes.Count - 1;

                if (!isFirstElement && !isLastElement)
                {
                    var currentIndex = i;
                    var previousIndex = i - 1;
                    var nextIndex = i + 1;

                    var isGreaterThanPrevious = grapes[currentIndex] > grapes[previousIndex];
                    var isGreaterThanNext = grapes[currentIndex] > grapes[nextIndex];
                    var isGreaterGrape = isGreaterThanPrevious && isGreaterThanNext;

                    if (isGreaterGrape)
                    {
                        if (grapes[previousIndex] > 0)
                        {
                            grapes[currentIndex]++;
                            grapes[previousIndex] = Math.Max(grapes[previousIndex] - 2, 0);
                        }

                        if (grapes[nextIndex] > 0)
                        {
                            grapes[currentIndex]++;
                            grapes[nextIndex] = Math.Max(grapes[nextIndex] - 2, 0);
                        }
                    }
                }
            }
        }

        private static void IncrementGrapes()
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] != 0)
                {
                    grapes[i]++;
                }
            }
        }
    }
}
