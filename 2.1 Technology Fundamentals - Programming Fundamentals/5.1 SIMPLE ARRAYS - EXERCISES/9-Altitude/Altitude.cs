using System;
using System.Linq;

namespace _9_Altitude
{
    class Altitude
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ');

            double altitude = double.Parse(commands[0]);
            bool isCrashed = false;

            for (int i = 1; i <= commands.Length - 1; i += 2)
            {
                if (commands[i] == "up")
                {
                    altitude += double.Parse(commands[i + 1]);
                }
                else if (commands[i] == "down")
                {
                    altitude -= double.Parse(commands[i + 1]);
                }

                if (altitude <= 0)
                {
                    isCrashed = true;
                    break;
                }
            }

            if (isCrashed)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
