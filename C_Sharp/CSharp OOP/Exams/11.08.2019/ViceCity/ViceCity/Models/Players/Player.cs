using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int lifePoints;
        private IRepository<IGun> gunRepo;


        public Player(string name, int lifePoints)
        {
            this.Name = name;
            this.LifePoints = lifePoints;
            this.gunRepo = new GunRepository();

        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Player's name cannot be null or a whitespace!");
                }

                this.name = value;
            }
        }

        public bool IsAlive => this.LifePoints > 0;

        public IRepository<IGun> GunRepository => this.gunRepo;

        public int LifePoints
        {
            get => this.lifePoints;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player life points cannot be below zero!");
                }

                this.lifePoints = value;
            }
        }

        public void TakeLifePoints(int points)
        {
            if (this.LifePoints > points)
            {
                this.LifePoints -= points;
            }
            else
            {
                this.LifePoints = 0;
            }
        }
    }
}
