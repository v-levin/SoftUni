using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.TruckTour
{
    public class TruckTour
    {
        static int n;
        static Queue<int[]> pumps;

        public static void Main()
        {
            n = int.Parse(Console.ReadLine());
            pumps = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pumpArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                pumps.Enqueue(pumpArgs);
            }

            for (int i = 0; i < pumps.Count; i++)
            {
                if (isSolution())
                {
                    Console.WriteLine(i);
                    break;
                }

                var startingPump = pumps.Dequeue();
                pumps.Enqueue(startingPump);
            }            
            
        }

        private static bool isSolution()
        {
            var truckFuel = 0;
            var isSolution = true;

            for (int i = 0; i < pumps.Count; i++)
            {
                var currentPump = pumps.Dequeue();

                truckFuel += currentPump[0] - currentPump[1];

                if (truckFuel < 0)
                {
                    isSolution = false;
                }

                pumps.Enqueue(currentPump);
            }


            if (isSolution)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
