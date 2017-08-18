using System;

namespace _5_CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double triangleArea = CalculateArea(width, height);

            Console.WriteLine(triangleArea);
        }

        private static double CalculateArea(double width, double height)
        {
            double area = (width * height) / 2;
            return area;
        }
    }
}
