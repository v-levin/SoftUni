using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var carModel = carInfo[0];
                var fuelAmount = double.Parse(carInfo[1]);
                var fuelConsumptionFor1km = double.Parse(carInfo[2]);

                var car = new Car(carModel, fuelAmount, fuelConsumptionFor1km);

                cars.Add(car);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split();
                var carModel = commandArgs[1];
                var amountOfKm = int.Parse(commandArgs[2]);

                cars.Where(c => c.Model == carModel).ToList().ForEach(c => c.Drive(amountOfKm));
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTravelled}");
            }
        }
    }
}
