using System;

namespace FruitShop
{
    class Program
    {
        static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            var price = -1.0;

            if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                if (fruit == "banana") price = 2.50;
                if (fruit == "apple") price = 1.20;
                if (fruit == "orange") price = 0.85;
                if (fruit == "grapefruit") price = 1.45;
                if (fruit == "kiwi") price = 2.70;
                if (fruit == "pineapple") price = 5.50;
                if (fruit == "grapes") price = 3.85;
            }
            else if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                if (fruit == "banana") price = 2.70;
                if (fruit == "apple") price = 1.25;
                if (fruit == "orange") price = 0.90;
                if (fruit == "grapefruit") price = 1.60;
                if (fruit == "kiwi") price = 3.00;
                if (fruit == "pineapple") price = 5.60;
                if (fruit == "grapes") price = 4.20;
            }

            if (price >= 0)
            {
                Console.WriteLine($"{price * quantity:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}