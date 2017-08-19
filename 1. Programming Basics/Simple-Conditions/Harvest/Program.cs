using System;

namespace Harvest
{
    class Program
    {
        static void Main()
        {
            var X = int.Parse(Console.ReadLine());
            var Y = double.Parse(Console.ReadLine());
            var Z = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());

            var totalGrape = X * Y;
            var vine = 40 * totalGrape / 100 / 2.5;

            if (vine >= Z)
            {
                var litersLeft = vine - Z;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersLeft)} liters left -> {Math.Ceiling(litersLeft / numberOfWorkers)} liters per person.");
            }
            else
            {
                var litersNeeded = Z - vine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersNeeded)} liters wine needed.");
            }
        }
    }
}