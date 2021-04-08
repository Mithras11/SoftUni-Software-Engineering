using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer.GetType().Name == "Beginner")
            {
                IncreaseHealth(attackPlayer);
            }
            if (enemyPlayer.GetType().Name == "Beginner")
            {
                IncreaseHealth(enemyPlayer);
            }

            GetBonusHealthPoints(attackPlayer);
            GetBonusHealthPoints(enemyPlayer);

            while (!attackPlayer.IsDead && !enemyPlayer.IsDead)
            {
                var attackerPower = GetDamagePoints(attackPlayer);
                var enemyPower = GetDamagePoints(enemyPlayer);

                enemyPlayer.TakeDamage(attackerPower);

                if (enemyPlayer.IsDead)
                {
                    continue;
                }

                attackPlayer.TakeDamage(enemyPower);

            }


        }

        private void IncreaseHealth(IPlayer player)
        {
            player.Health += 40;
            foreach (var card in player.CardRepository.Cards)
            {
                card.DamagePoints += 30;
            }
        }

        private void GetBonusHealthPoints(IPlayer player)
        {
            player.Health += player.CardRepository.Cards.Sum(x => x.HealthPoints);
        }

        private int GetDamagePoints(IPlayer player)
        {
            return player.CardRepository.Cards.Sum(x => x.DamagePoints);
        }
    }
}
