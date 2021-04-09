using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsPerBarrel;
        private int capacity;//?
        private int totalBullets;



        public Gun(string name, int bulletsPerBarrel, int totalBullets)
        {
            this.Name = name;
            this.BulletsPerBarrel = bulletsPerBarrel;
            this.capacity = bulletsPerBarrel;
            this.TotalBullets = totalBullets;
        }




        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value))// isNullOrWhiteSpace???
                {
                    throw new ArgumentException("Name cannot be null or a white space!");
                }

                this.name = value;
            }
        }

        public int BulletsPerBarrel
        {
            get => this.bulletsPerBarrel;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below zero!");
                }

                this.bulletsPerBarrel = value;
            }
        }

        public int TotalBullets
        {
            get => this.totalBullets;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Total bullets cannot be below zero!");
                }

                this.totalBullets = value;
            }
        }
              

        public bool CanFire => this.TotalBullets > 0;

        public abstract int Fire();


        protected void Relod()
        {
            this.BulletsPerBarrel = this.capacity;
            this.TotalBullets -= this.capacity;

        }
    }
}
