using System;

namespace Journey
{
    class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            var destinantion = "";

            if (budget <= 100 && season == "summer")
            {
                destinantion = "Bulgaria";
                Console.WriteLine($"Somewhere in {destinantion}");
                Console.WriteLine($"Camp - {budget * 30 / 100:f2}");
            }
            else if (budget <= 100 && season == "winter")
            {
                destinantion = "Bulgaria";
                Console.WriteLine($"Somewhere in {destinantion}");
                Console.WriteLine($"Hotel - {budget * 70 / 100:f2}");
            }

            if (budget > 100 && budget <= 1000 && season == "summer")
            {
                destinantion = "Balkans";
                Console.WriteLine($"Somewhere in {destinantion}");
                Console.WriteLine($"Camp - {budget * 40 / 100:f2}");
            }
            else if (budget > 100 && budget <= 1000 && season == "winter")
            {
                destinantion = "Balkans";
                Console.WriteLine($"Somewhere in {destinantion}");
                Console.WriteLine($"Hotel - {budget * 80 / 100:f2}");
            }

            if (budget > 1000)
            {
                destinantion = "Europe";
                Console.WriteLine($"Somewhere in {destinantion}");
                Console.WriteLine($"Hotel - {budget * 90 / 100:f2}");
            }

        }
    }
}