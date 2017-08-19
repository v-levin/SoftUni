using System;
using System.Linq;

namespace _3_Camel_sBack
{
    class Program
    {
        static void Main()
        {
            var buildings = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var camelBackSize = int.Parse(Console.ReadLine());

            var rounds = 0;

            if (buildings.Count == camelBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
            else
            {
                while (buildings.Count != camelBackSize)
                {
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);
                    rounds++;
                }

                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
        }
    }
}
