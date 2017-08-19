using System;
using System.Collections.Generic;

namespace _5.Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }

        public Point UpperRight { get; set; }

        public Point BottomLeft { get; set; }

        public Point BottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }
    }

    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public static int CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);

            var result = Math.Sqrt(squareX + squareY);

            return (int)result;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var boxes = new List<Box>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { ' ', ':', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var box = GetBox(inputParams);

                boxes.Add(box);

                inputLine = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
                var perimeter = Box.CalculatePerimeter(width, height);
                var area = Box.CalculateArea(width, height);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.WriteLine($"Area: {area}");
            }
        }

        static Box GetBox(string[] inputParams)
        {
            return new Box()
            {
                UpperLeft = new Point()
                {
                    X = int.Parse(inputParams[0]),
                    Y = int.Parse(inputParams[1])
                },

                UpperRight = new Point()
                {
                    X = int.Parse(inputParams[2]),
                    Y = int.Parse(inputParams[3])
                },

                BottomLeft = new Point()
                {
                    X = int.Parse(inputParams[4]),
                    Y = int.Parse(inputParams[5])
                },

                BottomRight = new Point()
                {
                    X = int.Parse(inputParams[6]),
                    Y = int.Parse(inputParams[7])
                }
            };
        }
    }
}
