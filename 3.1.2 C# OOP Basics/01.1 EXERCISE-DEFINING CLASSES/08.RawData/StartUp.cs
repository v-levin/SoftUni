using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        private const int numberOfTyres = 4;
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
                var tyre1Pressure = double.Parse(carInfo[5]);
                var tyre1Age = int.Parse(carInfo[6]);
                var tyre2Pressure = double.Parse(carInfo[7]);
                var tyre2Age = int.Parse(carInfo[8]);
                var tyre3Pressure = double.Parse(carInfo[9]);
                var tyre3Age = int.Parse(carInfo[10]);
                var tyre4Pressure = double.Parse(carInfo[11]);
                var tyre4Age = int.Parse(carInfo[12]);

                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoWeight, cargoType);
                var tyres = new Tyre[numberOfTyres];
                tyres[0] = new Tyre(tyre1Pressure, tyre1Age);
                tyres[1] = new Tyre(tyre2Pressure, tyre2Age);
                tyres[2] = new Tyre(tyre3Pressure, tyre3Age);
                tyres[3] = new Tyre(tyre4Pressure, tyre4Age);

                var car = new Car(carModel, engine, cargo, tyres);

                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == command && c.Tyres.Any(p => p.Pressure < maxPressure))
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
