using System;

namespace TileRepair
{
    class Program
    {
        static void Main()
        {
            var squareSide = int.Parse(Console.ReadLine());
            var tileWidth = double.Parse(Console.ReadLine());
            var tileLength = double.Parse(Console.ReadLine());
            var benchWidth = int.Parse(Console.ReadLine());
            var benchLength = int.Parse(Console.ReadLine());

            var squareArea = squareSide * squareSide;
            var benchArea = benchWidth * benchLength;
            var tileArea = tileWidth * tileLength;
            var totalCoverArea = squareArea - benchArea;
            var totalTiles = totalCoverArea / tileArea;
            var totalTime = totalTiles * 0.2;

            Console.WriteLine(totalTiles);
            Console.WriteLine(totalTime);

        }
    }
}