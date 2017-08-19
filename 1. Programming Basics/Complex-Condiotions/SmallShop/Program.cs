using System;

namespace SmallShop
{
    class Program
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.5);
                if (product == "water") Console.WriteLine(quantity * 0.8);
                if (product == "beer") Console.WriteLine(quantity * 1.2);
                if (product == "sweets") Console.WriteLine(quantity * 1.45);
                if (product == "peanuts") Console.WriteLine(quantity * 1.6);
            }            
            if (city == "plovdiv")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.4);
                if (product == "water") Console.WriteLine(quantity * 0.7);
                if (product == "beer") Console.WriteLine(quantity * 1.15);
                if (product == "sweets") Console.WriteLine(quantity * 1.3);
                if (product == "peanuts") Console.WriteLine(quantity * 1.5);
            }
            if (city == "varna")
            {
                if (product == "coffee") Console.WriteLine(quantity * 0.45);
                if (product == "water") Console.WriteLine(quantity * 0.7);
                if (product == "beer") Console.WriteLine(quantity * 1.1);
                if (product == "sweets") Console.WriteLine(quantity * 1.35);
                if (product == "peanuts") Console.WriteLine(quantity * 1.55);
            }
        }
    }
}