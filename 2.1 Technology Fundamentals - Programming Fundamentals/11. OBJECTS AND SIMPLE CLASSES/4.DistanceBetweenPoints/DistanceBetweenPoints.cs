using System;
using System.Linq;

namespace _4.DistanceBetweenPoints
{
    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            var pointNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            return new Point
            {
                X = pointNumbers[0],
                Y = pointNumbers[1]
            };
        }
    }
}
