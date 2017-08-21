using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.ClosestTwoPoints
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
    
    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentNumber = ReadPoint();
                points.Add(currentNumber);
            }

            var minDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            FindClosestPoint(points, ref minDistance, ref firstPointResult, ref secondPointResult);

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }

        private static void FindClosestPoint(List<Point> points, ref double minDistance, ref Point firstPointResult, ref Point secondPointResult)
        {
            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var distance = Distance(firstPoint, secondPoint);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }
        }

        public static double Distance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return result;
        }

        public static Point ReadPoint()
        {
            var pointNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var x = pointNumbers[0];
            var y = pointNumbers[1];

            return new Point
            {
                X = x,
                Y = y
            };
        }
    }
}
