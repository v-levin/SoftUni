using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ParkingSystem
{
    public class ParkingSystem
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var row = matrixSize[0];
            var col = matrixSize[1];

            var parkingLot = new Dictionary<int, HashSet<int>>();

            var coordinates = Console.ReadLine();

            while (coordinates != "stop")
            {
                var coordinatesParams = coordinates.Split();
                var entryRow = int.Parse(coordinatesParams[0]);
                var desiredRow = int.Parse(coordinatesParams[1]);
                var desiredCol = int.Parse(coordinatesParams[2]);

                var parkColumn = 0;

                if (!IsOccupied(parkingLot, desiredRow, desiredCol))
                {
                    parkColumn = desiredCol;
                }
                else
                {
                    for (int i = 1; i < col - 1; i++)
                    {
                        if (desiredCol - i > 0 && !IsOccupied(parkingLot, desiredRow, desiredCol - i))
                        {
                            parkColumn = desiredCol - i;
                            break;
                        }
                        else if (desiredCol + i < col && !IsOccupied(parkingLot, desiredRow, desiredCol + i))
                        {
                            parkColumn = desiredCol + i;
                            break;
                        }
                    }
                }

                if (parkColumn == 0)
                {
                    Console.WriteLine($"Row {desiredRow} full");
                }
                else
                {
                    parkingLot[desiredRow].Add(parkColumn);
                    var distanceTravelled = Math.Abs(entryRow - desiredRow) + 1 + parkColumn;

                    Console.WriteLine(distanceTravelled);
                }

                coordinates = Console.ReadLine();
            }
        }

        private static bool IsOccupied(Dictionary<int, HashSet<int>> parkingLot, int desiredRow, int desiredCol)
        {
            if (parkingLot.ContainsKey(desiredRow))
            {
                if (parkingLot[desiredRow].Contains(desiredCol))
                {
                    return true;
                }
            }
            else
            {
                parkingLot.Add(desiredRow, new HashSet<int>());
            }

            return false;
        }
    }
}
