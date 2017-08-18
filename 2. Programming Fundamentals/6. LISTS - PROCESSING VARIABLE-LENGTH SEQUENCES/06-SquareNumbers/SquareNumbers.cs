using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SquareNumbers
{
    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            foreach (var number in numbers)
            {
                var sqrt = Math.Sqrt(number);
                if (sqrt == (int)sqrt)
                {
                    result.Add(number);
                }
            }

            result.Sort();
            result.Reverse();

            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString())));
        }
    }
}
