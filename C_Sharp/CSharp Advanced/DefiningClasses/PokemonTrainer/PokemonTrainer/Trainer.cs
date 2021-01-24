using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badgesNumber;
        private List<Pokemon> pokemons;

        public string Name { get; set; }
        public int BadgesNumber { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();
        }


        public void ProcessCommand(string command)
        {
            if (this.Pokemons.Exists(p => p.Element == command))
            {
                this.BadgesNumber++;
            }
            else
            {
                foreach (var pokemon in this.Pokemons)
                {
                    pokemon.Health -= 10;
                }

                if (this.Pokemons.Exists(p => p.Health <= 0))
                {
                    this.Pokemons.RemoveAll(p => p.Health <= 0);

                }

            }
        }
    }
}
