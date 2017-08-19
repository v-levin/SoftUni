using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_March_01_DogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideWallLenght = double.Parse(Console.ReadLine());
            var houseHeight = double.Parse(Console.ReadLine());

            var bothSides = 2 * sideWallLenght * (sideWallLenght / 2);
            var backSide = Math.Pow((sideWallLenght / 2), 2) + ((sideWallLenght / 2 * (houseHeight - sideWallLenght / 2) / 2));
            var frontSide = Math.Pow((sideWallLenght / 2), 2) + ((sideWallLenght / 2 * (houseHeight - sideWallLenght / 2) / 2)) - Math.Pow((sideWallLenght / 5), 2);
            var roof = bothSides;

            var greenColor = (bothSides + backSide + frontSide) / 3;
            var redColor = roof / 5;

            Console.WriteLine($"{greenColor:f2}");
            Console.WriteLine($"{redColor:f2}");
        }
    }
}
