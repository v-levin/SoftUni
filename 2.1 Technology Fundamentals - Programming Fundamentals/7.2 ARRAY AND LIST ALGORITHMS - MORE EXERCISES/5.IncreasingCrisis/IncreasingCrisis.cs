using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.IncreasingCrisis
{
    class IncreasingCrisis
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var sequenceOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            bool broken = false;

            CheckIfBroken(sequenceOfNums, ref broken);

            result = sequenceOfNums;

            for (int i = 1; i < num; i++)
            {
                broken = false;

                sequenceOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

                CheckIfBroken(sequenceOfNums, ref broken);

                var index = 0;
                for (int j = result.Count - 1; j >= 0; j--)
                {
                    if (result[j] <= sequenceOfNums[0])
                    {
                        index = j + 1;
                        break;
                    }
                }

                if (broken)
                {

                    for (int j = 0; j < sequenceOfNums.Count; j++)
                    {
                        result.Insert(index, sequenceOfNums[j]);
                        index++;
                    }

                    for (int j = index; j < result.Count; j++)
                    {
                        result.RemoveAt(j);
                        j--;
                    }
                }
                else
                {
                    for (int j = 0; j < sequenceOfNums.Count; j++)
                    {
                        result.Insert(index, sequenceOfNums[j]);
                        index++;
                    }

                    for (int j = 1; j < result.Count; j++)
                    {
                        if (result[j - 1] > result[j])
                        {
                            for (int k = j; k < result.Count; k++)
                            {
                                result.RemoveAt(k);
                                k--;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        static void CheckIfBroken(List<int> sequenceOfNums, ref bool broken)
        {
            for (int i = 1; i < sequenceOfNums.Count; i++)
            {
                if (sequenceOfNums[i] < sequenceOfNums[i - 1])
                {
                    for (int j = i; j < sequenceOfNums.Count; j++)
                    {
                        sequenceOfNums.RemoveAt(j);
                        j--;
                    }

                    broken = true;
                    break;
                }
            }
        }
    }
}