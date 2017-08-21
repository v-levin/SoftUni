using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            var integerList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (integerList.Count % 2 == 0)
            {
                for (int i = 1; i <= integerList.Count / 2 - 1; i++)
                {
                    GetResult(integerList, i);
                }
            }
            else
            {
                for (int i = 1; i <= integerList.Count / 2; i++)
                {
                    GetResult(integerList, i);
                }
            }

            Console.WriteLine(string.Join(" ", integerList.Select(x => x.ToString())));
        }

        private static void GetResult(List<int> integerList, int i)
        {
            var leftSwitch = integerList[i];
            var rightSwitch = integerList[integerList.Count - i - 1];

            integerList.RemoveAt(i);
            integerList.Insert(i, rightSwitch);

            integerList.RemoveAt(integerList.Count - i - 1);
            integerList.Insert(integerList.Count - i, leftSwitch);
        }
    }
}
