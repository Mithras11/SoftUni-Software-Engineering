using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int BulletsShot = 1;

        public Pistol(string name)
            : base(name, 10, 100)
        {
        }

        public override int Fire()
        {
            if (this.CanFire)
            {
                if (this.BulletsPerBarrel <= 0)//?
                {
                    Relod();
                }

                this.BulletsPerBarrel -= BulletsShot;

                return BulletsShot;
            }

            return 0;
        }
    }
}
