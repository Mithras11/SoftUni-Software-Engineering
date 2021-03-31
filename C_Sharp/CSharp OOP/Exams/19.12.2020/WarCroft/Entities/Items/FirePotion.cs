using WarCroft.Entities.Characters.Contracts;

namespace WarCroft.Entities.Items
{
    public class FirePotion : Item
    {
        private const int CurrentWeight = 5;

        public FirePotion()
            : base(CurrentWeight)
        {
        }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            if (character.Health > 20)
            {
                character.Health -= 20; // implement Health property

            }
            else
            {
                character.Health = 0;
                character.IsAlive = false;
            }



        }
    }
}
