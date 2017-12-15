using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {

        }

        private static void OrderAndTake(Dictionary<string, List<int>> wantedData, int studentsToTake, 
            Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        {

        }

        private static int CompareInOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        {
            int totalOdFirstMarks = 0;
            foreach (var i in firstValue.Value)
            {
                totalOdFirstMarks += i;
            }

            int totalOfSecondMarks = 0;
            foreach (var i in secondValue.Value)
            {
                totalOfSecondMarks += i;
            }

            return totalOfSecondMarks.CompareTo(totalOdFirstMarks);
        }

        private static int CompareDescendingOrder(KeyValuePair<string, List<int>> firstValue, KeyValuePair<string, List<int>> secondValue)
        {
            int totalOdFirstMarks = 0;
            foreach (var i in firstValue.Value)
            {
                totalOdFirstMarks += i;
            }

            int totalOfSecondMarks = 0;
            foreach (var i in secondValue.Value)
            {
                totalOfSecondMarks += i;
            }

            return totalOdFirstMarks.CompareTo(totalOfSecondMarks);
        }

        private static Dictionary<string, List<int>> GetSortedStudents(Dictionary<string, List<int>> studentsWanted, int takeCount,
            Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> Comparison)
        {
            return null;
        }
    }
}
