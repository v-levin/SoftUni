using System;

namespace PointOnRectangleBorder
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
            var xBorder = (x == x1 || x == x2) && insideVertical;
            var yBorder = (y == y1 || y == y2) && insideHorizontal;

            if (!(xBorder || yBorder))
            {
                Console.WriteLine("Inside / Outside");
            }
            else
            {
                Console.WriteLine("Border");
            }
        }
    }
}