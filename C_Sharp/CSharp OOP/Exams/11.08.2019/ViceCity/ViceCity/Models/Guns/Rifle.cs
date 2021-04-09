using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int BulletsShot = 5;

        public Rifle(string name)
            : base(name, 50, 500)
        {
        }

        public override int Fire()
        {
            if (this.CanFire)
            {
                if (this.BulletsPerBarrel == 0)
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
