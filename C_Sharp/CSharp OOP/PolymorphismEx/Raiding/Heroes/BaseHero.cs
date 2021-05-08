using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Heroes
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public  string Name { get;  private set; }

        public abstract int Power { get; }

        public abstract string CastAbility();
    }
}
