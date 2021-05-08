using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Heroes
{
    public class Paladin : BaseHero
    {
        private const int power = 100;

        public Paladin(string name) : base(name)
        {
        }

        public override int Power => power;

        public override string CastAbility()
        {
            return $"{ this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
