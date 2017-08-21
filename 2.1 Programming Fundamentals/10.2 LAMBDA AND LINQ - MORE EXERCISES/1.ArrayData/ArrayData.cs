using System;
using System.Linq;

namespace _1.ArrayData
{
    public class ArrayData
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            var average = numbers.Average();

            switch (command)
            {
                case "Min":
                    var min = numbers.Where(x => x >= average).Min();
                    Console.WriteLine(min);
                    break;
                case "Max":
                    var max = numbers.Where(x => x >= average).Max();
                    Console.WriteLine(max);
                    break;
                case "All":
                    var all = numbers.Where(x => x > average).OrderBy(x => x).ToList();
                    Console.WriteLine(string.Join(" ", all));
                    break;
            }
        }
    }
}
