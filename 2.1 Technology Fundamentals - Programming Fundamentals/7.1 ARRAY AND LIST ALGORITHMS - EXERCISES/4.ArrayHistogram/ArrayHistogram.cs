using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main()
        {
            var stringArray = Console.ReadLine()
                .Split()
                .ToArray();

            var stringArrayLength = stringArray.Length;

            List<string> words = new List<string>();
            List<int> occurencesCount = new List<int>();
            List<double> percentages = new List<double>();

            CountWords(stringArray, words, occurencesCount);

            SortCountResult(words, occurencesCount);

            CalculateStatistics(stringArrayLength, occurencesCount, percentages);

            PrintResult(words, occurencesCount, percentages);
        }

        static void PrintResult(List<string> words, List<int> occurencesCount, List<double> percentages)
        {
            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {occurencesCount[i]} times ({percentages[i]:F2}%)");
            }
        }

        static void CalculateStatistics(int stringArrayLength, List<int> occurencesCount, List<double> percentages)
        {
            for (int i = 0; i < occurencesCount.Count; i++)
            {
                var currentCount = occurencesCount[i];
                double percentage = (double)currentCount / stringArrayLength * 100;
                percentages.Add(percentage);
            }
        }

        static void SortCountResult(List<string> words, List<int> occurencesCount)
        {
            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < occurencesCount.Count - 1; i++)
                {
                    var currentIndex = i;
                    var nextIndex = i + 1;
                    if (occurencesCount[currentIndex] < occurencesCount[nextIndex])
                    {
                        var tempO = occurencesCount[currentIndex];
                        occurencesCount[currentIndex] = occurencesCount[nextIndex];
                        occurencesCount[nextIndex] = tempO;

                        var tempW = words[currentIndex];
                        words[currentIndex] = words[nextIndex];
                        words[nextIndex] = tempW;

                        swapped = true;
                    }
                }

            } while (swapped);
        }

        static void CountWords(string[] stringArray, List<string> words, List<int> occurencesCount)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                var currentWord = stringArray[i];

                if (!words.Exists(word => word == currentWord))
                {
                    words.Add(currentWord);
                    occurencesCount.Add(1);
                }
                else
                {
                    int index = words.IndexOf(currentWord);
                    occurencesCount[index] += 1;
                }
            }
        }
    }
}
