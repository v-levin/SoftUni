using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    public class SetsOfElements
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = tokens[0];
            var m = tokens[1];

            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                nSet.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                var number = int.Parse(Console.ReadLine());
                mSet.Add(number);
            }

            Console.WriteLine(string.Join(" ", nSet.Intersect(mSet)));
        }
    }
}
