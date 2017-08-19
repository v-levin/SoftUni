using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main()
        {
            var figure = Console.ReadLine();

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
            }
            else if (figure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var length = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(width * length, 3));
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * radius * radius, 3));
            }
            else if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * height / 2, 3));
            }
        }
    }
}