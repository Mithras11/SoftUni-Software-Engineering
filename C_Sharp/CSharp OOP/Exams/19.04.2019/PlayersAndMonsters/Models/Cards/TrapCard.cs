using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Cards
{
    public class TrapCard : Card
    {
        public TrapCard(string name)
            : base(name, 120, 5)
        {
        }
    }
}
