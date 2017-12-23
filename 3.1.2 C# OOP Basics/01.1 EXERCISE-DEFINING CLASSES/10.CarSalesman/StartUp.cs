using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            var numberOfEngines = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();
            GetEngines(numberOfEngines, engines);

            var numberOfCars = int.Parse(Console.ReadLine());

            var cars = new List<Car>();
            GetCars(engines, numberOfCars, cars);

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        private static void GetCars(List<Engine> engines, int numberOfCars, List<Car> cars)
        {
            for (int i = 0; i < numberOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = carInfo[0];
                var carEngine = engines.Where(e => e.Model == carInfo[1]).FirstOrDefault();

                var car = new Car(carModel, carEngine);

                if (carInfo.Length == 4)
                {
                    var carWeight = int.Parse(carInfo[2]);
                    var carColor = carInfo[3];

                    car.Weight = carWeight;
                    car.Color = carColor;
                }
                else if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int carWeight))
                    {
                        car.Weight = carWeight;
                    }
                    else
                    {
                        var carColor = carInfo[2];
                        car.Color = carColor;
                    }
                }

                cars.Add(car);
            }
        }

        private static void GetEngines(int numberOfEngines, List<Engine> engines)
        {
            for (int i = 0; i < numberOfEngines; i++)
            {
                var engineInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var engineModel = engineInfo[0];
                var enginePower = int.Parse(engineInfo[1]);

                var engine = new Engine(engineModel, enginePower);

                if (engineInfo.Length == 4)
                {
                    var engineDisplacement = int.Parse(engineInfo[2]);
                    var engineEfficiency = engineInfo[3];

                    engine.Displacement = engineDisplacement;
                    engine.Efficiency = engineEfficiency;
                }
                else if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int engineDisplacement))
                    {
                        engine.Displacement = engineDisplacement;
                    }
                    else
                    {
                        var engineEfficiency = engineInfo[2];
                        engine.Efficiency = engineEfficiency;
                    }
                }

                engines.Add(engine);
            }
        }
    }
}
