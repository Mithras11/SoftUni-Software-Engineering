using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string trainerName = tokens[0];

                string pokemonName = tokens[1];
                string element = tokens[2];
                int health = int.Parse(tokens[3]);

                if (trainers.Exists(t => t.Name == trainerName) == false)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                trainers.Find(t => t.Name == trainerName).Pokemons.Add(pokemon);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.ProcessCommand(command);
                }
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.BadgesNumber))
            {
                Console.WriteLine($"{trainer.Name} {trainer.BadgesNumber} {trainer.Pokemons.Count}");
            }

        }
    }
}
