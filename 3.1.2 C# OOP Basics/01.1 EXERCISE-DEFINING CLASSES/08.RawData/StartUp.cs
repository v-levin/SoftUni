using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        private const int numberOfTires = 4;
        private const int maxPressure = 1;
        private const int minPower = 250;

        public static void Main()
        {
            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();
                var carModel = carInfo[0];
                var engineSpeed = int.Parse(carInfo[1]);
                var enginePower = int.Parse(carInfo[2]);
                var cargoWeight = int.Parse(carInfo[3]);
                var cargoType = carInfo[4];
                var tire1Pressure = double.Parse(carInfo[5]);
                var tire1Age = int.Parse(carInfo[6]);
                var tire2Pressure = double.Parse(carInfo[7]);
                var tire2Age = int.Parse(carInfo[8]);
                var tire3Pressure = double.Parse(carInfo[9]);
                var tire3Age = int.Parse(carInfo[10]);
                var tire4Pressure = double.Parse(carInfo[11]);
                var tire4Age = int.Parse(carInfo[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tires = new Tire[numberOfTires];
                tires[1] = new Tire(tire2Pressure, tire2Age);
                tires[0] = new Tire(tire1Pressure, tire1Age);
                tires[2] = new Tire(tire3Pressure, tire3Age);
                tires[3] = new Tire(tire4Pressure, tire4Age);

                var car = new Car(carModel, engine, cargo, tires);

                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == command && c.Tires.Any(p => p.Pressure < maxPressure))
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.Cargo.Type == command && c.Engine.Power > minPower)
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
