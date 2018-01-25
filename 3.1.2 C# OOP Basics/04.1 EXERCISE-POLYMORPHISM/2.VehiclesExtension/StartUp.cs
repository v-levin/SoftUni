using System;
using VehiclesExtension.Models;

namespace VehiclesExtension
{
    public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            var truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            var busInfo = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            var numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                try
                {
                    var commandTokens = Console.ReadLine().Split();
                    var vehicleType = commandTokens[1];
                    if (vehicleType == "Car")
                    {
                        ExecuteAction(car, commandTokens[0], double.Parse(commandTokens[2]));
                    }
                    else if (vehicleType == "Truck")
                    {
                        ExecuteAction(truck, commandTokens[0], double.Parse(commandTokens[2]));
                    }
                    else if (vehicleType == "Bus")
                    {
                        ExecuteAction(bus, commandTokens[0], double.Parse(commandTokens[2]));
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
        {
            switch (command)
            {
                case "Drive":
                    Console.WriteLine(vehicle.TryTravelDistance(parameter));
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
                case "DriveEmpty":
                    Console.WriteLine(vehicle.TryTravelDistance(parameter, false));
                    break;
            }
        }
    }
}
