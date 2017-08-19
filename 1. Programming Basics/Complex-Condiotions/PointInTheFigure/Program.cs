using System;

namespace PointInTheFigure
{
    class Program
    {
        static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var insideHorizontalBlock = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var insideVerticallBlock = (x > h && x < 2 * h) && (y > 0 && y < 4 * h);
            var inside = insideHorizontalBlock || insideVerticallBlock;

            var borderHorizontalBlock = (x >= 0 && x <= 3 * h && y == 0) || 
                                        (y == h && x >= 0 && x <= h) || 
                                        (y == h && x >= 2 * h && x <= 3 * h) || 
                                        (x == 0 && y >= 0 && y <= h) || 
                                        (x == 3 * h && y >= 0 && y <= h);
            var borderVerticalBlock = (x == h && y >= h && y <= 4 * h) || (x == 2 * h && y >= h && y <= 4 * h) || (x >= h && x <= 2 * h && y == 4 * h);
            var border = borderHorizontalBlock || borderVerticalBlock;

            if (inside)
            {
                Console.WriteLine("inside");
            }
            else if (border)
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}