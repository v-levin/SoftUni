using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_StuckZipper
{
    class StuckZipper
    {
        static void Main()
        {
            var firstNumberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondNumberList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var minFirstList = firstNumberList.Min();
            var minSecondList = secondNumberList.Min();
            var minOveral = 0;

            if (minFirstList < minSecondList) minOveral = minFirstList;
            else minOveral = minSecondList;

            bool checkFirstValidNumbers = firstNumberList.Any(number => Math.Abs(number).ToString().Length > Math.Abs(minOveral).ToString().Length);
            bool checkSecondValidNumbers = secondNumberList.Any(number => Math.Abs(number).ToString().Length > Math.Abs(minOveral).ToString().Length);

            if (checkFirstValidNumbers) firstNumberList = GetModifiedList(firstNumberList, minOveral);
            if (checkSecondValidNumbers) secondNumberList = GetModifiedList(secondNumberList, minOveral);

            var countFirstList = firstNumberList.Count;
            var countSecondList = secondNumberList.Count;
            var result = new List<int>();

            GetResult(firstNumberList, secondNumberList, countFirstList, countSecondList, result);

            Console.WriteLine(string.Join(" ", result));
        }

        private static void GetResult(List<int> firstNumberList, List<int> secondNumberList, int countFirstList, int countSecondList, List<int> result)
        {
            if (countFirstList == countSecondList)
            {
                for (int i = 0; i < countFirstList; i++)
                {
                    result.Add(secondNumberList[i]);
                    result.Add(firstNumberList[i]);
                }
            }
            else if (countFirstList > countSecondList)
            {
                for (int i = 0; i < countSecondList; i++)
                {
                    result.Add(secondNumberList[i]);
                    result.Add(firstNumberList[i]);
                }

                for (int j = countSecondList; j < countFirstList; j++)
                {
                    result.Add(firstNumberList[j]);
                }
            }
            else if (countFirstList < countSecondList)
            {
                for (int i = 0; i < countFirstList; i++)
                {
                    result.Add(secondNumberList[i]);
                    result.Add(firstNumberList[i]);
                }

                for (int j = countFirstList; j < countSecondList; j++)
                {
                    result.Add(secondNumberList[j]);
                }
            }
        }

        private static List<int> GetModifiedList(List<int> numberList, int minOveral)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                var currentNumber = numberList[i];

                if (Math.Abs(currentNumber).ToString().Length > Math.Abs(minOveral).ToString().Length)
                {
                    numberList.RemoveAt(i);
                    i--;
                }
            }

            return numberList;
        }
    }
}
