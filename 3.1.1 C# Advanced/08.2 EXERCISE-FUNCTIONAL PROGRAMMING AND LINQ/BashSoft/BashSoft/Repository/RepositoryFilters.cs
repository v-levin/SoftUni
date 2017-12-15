using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class RepositoryFilters
    {
        public static void FilterAndTake(Dictionary<string, List<int>> wantedData, string wantedFilter, int sstudentsToTake)
        {

        }

        private static void FilterAndTake(Dictionary<string, Predicate<double>> givenFilter, int sstudentsToTake)
        {

        }

        private static bool ExcellentFilter(double mark)
        {
            return mark >= 5.0;
        }

        private static bool AverageFilter(double mark)
        {
            return mark < 5.0 && mark >= 3.5;
        }

        private static bool PoorFilter(double mark)
        {
            return mark < 3.5;
        }

        private static double Average(List<int> scoresOnTasks)
        {
            int totalScore = 0;
            foreach (var score in scoresOnTasks)
            {
                totalScore += score;
            }

            var percentageOfAll = totalScore / (scoresOnTasks.Count * 100);
            var mark = percentageOfAll * 4 + 2;

            return mark;
        }
    }
}
