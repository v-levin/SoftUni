using System;
using System.Collections.Generic;
using System.Linq;

namespace RectangleIntersection
{
    public class StartUp
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split();
            var rectanglesCount = int.Parse(inputParams[0]);
            var intersectionChecks = int.Parse(inputParams[1]);

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                var rectangleInfo = Console.ReadLine().Split();
                var id = rectangleInfo[0];
                var width = double.Parse(rectangleInfo[1]);
                var height = double.Parse(rectangleInfo[2]);
                var x = double.Parse(rectangleInfo[3]);
                var y = double.Parse(rectangleInfo[4]);

                var rectangle = new Rectangle(id, width, height, x, y);

                rectangles.Add(rectangle);
            }

            for (int i = 0; i < intersectionChecks; i++)
            {
                var idsToCheck = Console.ReadLine().Split();
                var firstRectangle = rectangles.FirstOrDefault(r => r.Id == idsToCheck[0]);
                var secondRectangle = rectangles.FirstOrDefault(r => r.Id == idsToCheck[1]);

                var intersect = firstRectangle.IntersectsWith(secondRectangle);

                Console.WriteLine(intersect.ToString().ToLower());
            }
        }
    }
}
