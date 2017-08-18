using System;
using System.Linq;

namespace _4_UnunionLists
{
    class UnunionLists
    {
        static void Main()
        {
            var primalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var numOfLists = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfLists; i++)
            {
                var currnetSequence = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                foreach (var number in currnetSequence)
                {
                    if (primalList.Contains(number))
                    {
                        for (int j = 0; j < primalList.Count; j++)
                        {
                            var currentListNumber = primalList[j];
                            if (number == currentListNumber)
                            {
                                primalList.Remove(number);
                                j--;
                            }
                        }
                    }
                    else
                    {
                        primalList.Add(number);
                    }
                }
            }
            
            primalList.Sort();

            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
