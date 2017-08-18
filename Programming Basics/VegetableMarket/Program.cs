using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main()
        {
            var vegetablePrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegetableKilograms = int.Parse(Console.ReadLine());
            var fruitKilograms = int.Parse(Console.ReadLine());

            var total = ((vegetablePrice * vegetableKilograms) + (fruitPrice * fruitKilograms)) / 1.94;

            Console.WriteLine(total);
        }
    }
}