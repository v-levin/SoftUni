using System;
using System.Linq;

namespace _05_SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers.Select(x => x.ToString())));
        }
    }
}
