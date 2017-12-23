using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var trainersAndPokemons = new Dictionary<string, List<Pokemon>>();

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "Tournament")
        {
            var inputArgs = inputLine.Split();
            var trainerName = inputArgs[0];
            var pokemonName = inputArgs[1];
            var pokemonElement = inputArgs[2];
            var pokemonHealth = int.Parse(inputArgs[3]);

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

            if (!trainersAndPokemons.ContainsKey(trainerName))
            {
                trainersAndPokemons.Add(trainerName, new List<Pokemon>());
            }

            trainersAndPokemons[trainerName].Add(pokemon);
        }

        var trainers = new List<Trainer>();
        var badges = 0;
        foreach (var trainerAndPokemons in trainersAndPokemons)
        {
            var trainerName = trainerAndPokemons.Key;
            var pokemons = new List<Pokemon>(trainerAndPokemons.Value);

            var trainer = new Trainer(trainerName, badges, pokemons);

            trainers.Add(trainer);
        }

        string element;

        while ((element = Console.ReadLine()) != "End")
        {
            switch (element)
            {
                case "Fire":
                    SumBadges(trainers, element);
                    break;
                case "Water":
                    SumBadges(trainers, element);
                    break;
                case "Electricity":
                    SumBadges(trainers, element);
                    break;
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    private static void SumBadges(List<Trainer> trainers, string element)
    {
        foreach (var trainer in trainers)
        {
            if (trainer.Pokemons.Any(p => p.Element == element))
            {
                // add badges if have pokemon with same element
                trainer.Badges++;
            }
            else
            {
                // remove 10 health from all pokemons
                trainer.Pokemons.ToList().ForEach(p => p.Health -= 10);
            }

            // remove popkemons with health equal or below 0
            if (trainer.Pokemons.Any(p => p.Health <= 0))
            {
                var pokemonsToDelete = trainer.Pokemons.Where(p => p.Health <= 0).ToList();

                foreach (var pokemon in pokemonsToDelete)
                {
                    trainer.Pokemons.Remove(pokemon);
                }
            }
        }
    }
}
