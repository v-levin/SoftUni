using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_AppendLists
{
    class AppendLists
    {
        static void Main()
        {
            var listOfNumbers = Console.ReadLine()
                .Split('|')
                .ToList();

            listOfNumbers.Reverse();

            var result = new List<string>();

            foreach (var number in listOfNumbers)
            {
                var nums = number.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                        result.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
