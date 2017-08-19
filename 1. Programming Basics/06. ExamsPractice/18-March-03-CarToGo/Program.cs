using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_March_03_CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            if (budget > 0 && budget <= 100)
            {
                var carClass = "Economy class";

                if (season == "summer")
                {
                    var carType = "Cabrio";
                    var price = budget * 35 / 100;
                    Console.WriteLine($"{carClass}");
                    Console.WriteLine($"{carType} - {price:f2}");
                }
                else if (season == "winter")
                {
                    var carType = "Jeep";
                    var price = budget * 65 / 100;
                    Console.WriteLine($"{carClass}");
                    Console.WriteLine($"{carType} - {price:f2}");
                }
            }

            if (budget > 100 && budget <= 500)
            {
                var carClass = "Compact class";

                if (season == "summer")
                {
                    var carType = "Cabrio";
                    var price = budget * 45 / 100;
                    Console.WriteLine($"{carClass}");
                    Console.WriteLine($"{carType} - {price:f2}");
                }
                else if (season == "winter")
                {
                    var carType = "Jeep";
                    var price = budget * 80 / 100;
                    Console.WriteLine($"{carClass}");
                    Console.WriteLine($"{carType} - {price:f2}");
                }
            }

            if (budget > 500)
            {
                var carClass = "Luxury class";
                var carType = "Jeep";
                var price = budget * 90 / 100;
                Console.WriteLine($"{carClass}");
                Console.WriteLine($"{carType} - {price:f2}");
            }
        }
    }
}
