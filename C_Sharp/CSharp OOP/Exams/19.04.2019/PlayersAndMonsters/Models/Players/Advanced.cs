using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters.Models.Players
{
    public class Advanced : Player
    {
        public Advanced(ICardRepository cardRepository, string username) 
            : base(cardRepository, username, 250)
        {
        }
    }
}
