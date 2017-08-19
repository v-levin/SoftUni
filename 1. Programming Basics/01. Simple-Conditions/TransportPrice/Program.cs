using System;

namespace TransportPrice
{
    class Program
    {
        static void Main()
        {
            var numberOfKilometers = int.Parse(Console.ReadLine());
            var periodOfDay = Console.ReadLine();
            var price = 0.0;

            if (numberOfKilometers < 20)
            {
                if (periodOfDay == "day")
                {
                    price = 0.70 + numberOfKilometers * 0.79;
                }
                else
                {
                    price = 0.70 + numberOfKilometers * 0.90;
                }
            }
            else if (numberOfKilometers >= 20 && numberOfKilometers < 100)
            {
                price = numberOfKilometers * 0.09;
            }
            else
            {
                price = numberOfKilometers * 0.06;
            }

            Console.WriteLine(price);
        }
    }
}