using System;

namespace MatchTickets
{
    class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var numberOfPeople = int.Parse(Console.ReadLine());

            var normal = 249.99;
            var vip = 499.99;
            var percent75 = budget / 100 * 75;
            var percent60 = budget / 100 * 60;
            var percent50 = budget / 100 * 50;
            var percent40 = budget / 100 * 40;
            var percent25 = budget / 100 * 25;
            var money = 0.0;

            if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                if (category == "normal") money = (budget - percent75) - normal * numberOfPeople;
                else if (category == "vip") money = (budget - percent75) - vip * numberOfPeople;
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                if (category == "normal") money = (budget - percent60) - normal * numberOfPeople;
                else if (category == "vip") money = (budget - percent60) - vip * numberOfPeople;
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                if (category == "normal") money = (budget - percent50) - normal * numberOfPeople;
                else if (category == "vip") money = (budget - percent50) - vip * numberOfPeople;
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                if (category == "normal") money = (budget - percent40) - normal * numberOfPeople;
                else if (category == "vip") money = (budget - percent40) - vip * numberOfPeople;
            }
            else if (numberOfPeople >= 50)
            {
                if (category == "normal") money = (budget - percent25) - normal * numberOfPeople;
                else if (category == "vip") money = (budget - percent25) - vip * numberOfPeople;
            }

            if (money >= 0) Console.WriteLine($"Yes! You have {money:f2} leva left.");
            else Console.WriteLine($"Not enough money! You need {Math.Abs(money):f2} leva.");
        }
    }
}