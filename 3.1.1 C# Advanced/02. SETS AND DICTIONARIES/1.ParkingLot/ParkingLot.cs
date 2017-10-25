namespace _1.ParkingLot
{
    using System;
    using System.Collections.Generic;

    public class ParkingLot
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var parkedCars = new SortedSet<string>(); 

            while (!input.Equals("END"))
            {
                var inputParams = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var direcrion = inputParams[0];
                var carNumber = inputParams[1];

                if (direcrion.Equals("IN"))
                {
                    parkedCars.Add(carNumber);
                }
                else if (direcrion.Equals("OUT"))
                {
                    if (parkedCars.Contains(carNumber))
                    {
                        parkedCars.Remove(carNumber);
                    }
                }

                input = Console.ReadLine();
            }

            if (parkedCars.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, parkedCars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
