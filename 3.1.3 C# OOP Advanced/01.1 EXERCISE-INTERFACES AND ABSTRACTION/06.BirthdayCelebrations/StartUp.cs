using BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        public static void Main()
        {
            List<Creature> creatures = new List<Creature>();

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "End")
            {
                var creatureTokens = inputLine.Split();
                var creatureType = creatureTokens[0];

                switch (creatureType)
                {
                    case "Citizen":
                        var citizenName = creatureTokens[1];
                        var citizenAge = int.Parse(creatureTokens[2]);
                        var id = creatureTokens[3];
                        var citizenBirthday = creatureTokens[4];

                        Creature citizen = new Creature(citizenName, citizenAge, id, citizenBirthday);
                        creatures.Add(citizen);
                        break;
                    case "Robot":
                        continue;
                    case "Pet":
                        var petName = creatureTokens[1];
                        var petBirthday = creatureTokens[2];

                        Creature pet = new Creature(petName, petBirthday);
                        creatures.Add(pet);
                        break;
                }
            }

            var specificYear = Console.ReadLine();

            var birthdays = creatures.Where(c => c.Birthday.Contains(specificYear)).Select(c => c.Birthday).ToArray();

            foreach (var birthday in birthdays)
                Console.WriteLine(birthday);
        }
    }
}
