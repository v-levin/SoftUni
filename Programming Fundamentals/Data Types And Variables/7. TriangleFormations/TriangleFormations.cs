using System;

namespace TriangleFormations
{
    class TriangleFormations
    {
        static void Main()
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            bool valid = sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;

            if (valid)
            {
                Console.WriteLine("Triangle is valid.");

                bool rightAngleAB = Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);
                bool rightAngleAC = Math.Pow(sideC, 2) + Math.Pow(sideA, 2) == Math.Pow(sideB, 2);
                bool rightAngleBC = Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2);

                if (rightAngleAB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (rightAngleAC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (rightAngleBC)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
