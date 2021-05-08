using System;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        public Warrior(string name)
            : base(name, 100, 50, 40, new Satchel())
        {
        }

        public void Attack(Character character)
        {
            this.EnsureAlive();

            if (character.IsAlive == false)
            {

                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);

            }

            if (this.Name == character.Name)
            {
                throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
            }


            character.TakeDamage(this.AbilityPoints);

        }


    }
}
