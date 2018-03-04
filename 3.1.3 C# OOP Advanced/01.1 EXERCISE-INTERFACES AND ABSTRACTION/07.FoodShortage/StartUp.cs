using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        public static void Main()
        {
            var citizens = new List<Citizen>();
            var rebels = new List<Rebel>();

            var numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                var inputTokens = Console.ReadLine().Split();

                if (inputTokens.Length > 3)
                {
                    var citizenName = inputTokens[0];
                    var citizenAge = int.Parse(inputTokens[1]);
                    var citizenId = inputTokens[2];
                    var citizenBirthday = inputTokens[3];

                    var citizen = new Citizen(citizenName, citizenAge, citizenId, citizenBirthday);
                    citizens.Add(citizen);
                }
                else
                {
                    var rebelName = inputTokens[0];
                    var rebelAge = int.Parse(inputTokens[1]);
                    var rebelGroup = inputTokens[2];

                    var rebel = new Rebel(rebelName, rebelAge, rebelGroup);
                    rebels.Add(rebel);
                }
            }

            int citizenSum = 0;
            int rebelSum = 0;
            string personWhoBoughtFood;
            while ((personWhoBoughtFood = Console.ReadLine()) != "End")
            {
                if (citizens.Any(c => c.CitizenName == personWhoBoughtFood))
                {
                    foreach (var citizen in citizens)
                    {
                        citizenSum = citizen.BuyFood();
                    }
                }

                if (rebels.Any(r => r.Name == personWhoBoughtFood))
                {
                    foreach (var rebel in rebels)
                    {
                        rebelSum = rebel.BuyFood();
                    }
                }
            }

            var totalSum = citizenSum + rebelSum;
            Console.WriteLine(totalSum);
        }
    }
}
