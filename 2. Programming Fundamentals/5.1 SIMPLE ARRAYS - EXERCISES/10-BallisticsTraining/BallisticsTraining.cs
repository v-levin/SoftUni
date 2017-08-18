using System;
using System.Linq;

namespace _10_BallisticsTraining
{
    class BallisticsTraining
    {
        static void Main()
        {
            double[] coordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            string[] commands = Console.ReadLine().Split(' ');

            double coordinateX = 0;
            double coordinateY = 0;

            for (int i = 0; i < commands.Length - 1; i += 2)
            {
                if (commands[i] == "up")
                {
                    coordinateY += double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    coordinateY -= double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "left")
                {
                    coordinateX -= double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "right")
                {
                    coordinateX += double.Parse(commands[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{coordinateX}, {coordinateY}]");

            if (coordinates[0] == coordinateX && coordinates[1] == coordinateY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
