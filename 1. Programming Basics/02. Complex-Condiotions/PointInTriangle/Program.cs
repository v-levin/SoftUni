using System;

namespace PointInTriangle
{
    class Program
    {
        static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            var insideHorizontal = x >= x1 && x <= x2;
            var insideVertical = y >= y1 && y <= y2;
            var inside = insideHorizontal && insideVertical;

            if (inside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}