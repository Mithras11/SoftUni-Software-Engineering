using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> party;
        private List<Item> itemPool;

        //public SerializationInfo ExceptionMessage { get; private set; }

        public WarController()
        {
            this.party = new List<Character>();
            this.itemPool = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            var characterType = args[0];
            var name = args[1];


            if (characterType != "Priest" && characterType != "Warrior")
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType), characterType);
                throw new ArgumentException($"Invalid character type \"{characterType}\"!");
            }

            Character character = null;

            if (characterType == "Priest")
            {
                character = new Priest(name);
            }
            else if (characterType == "Warrior")
            {
                character = new Warrior(name);
            }

            party.Add(character);

            return $"{name} joined the party!";

        }

        public string AddItemToPool(string[] args)
        {
            var itemName = args[0];

            if (itemName != "FirePotion" && itemName != "HealthPotion")
            {
                // throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem), itemName);
                throw new ArgumentException($"Invalid item \"{itemName}\"!");
            }


            Item item = null;

            if (itemName == "FirePotion")
            {
                item = new FirePotion();
            }
            else if (itemName == "HealthPotion")
            {
                item = new HealthPotion();
            }

            itemPool.Add(item);

            return $"{itemName} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            var characterName = args[0];

            if (this.party.Any(c => c.Name == characterName) == false)
            {
                throw new ArgumentException($"Character {characterName} not found!");
            }
            if (this.itemPool.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            Character character = party.FirstOrDefault(c => c.Name == characterName);
            Item lastItem = itemPool[itemPool.Count - 1];

            character.Bag.AddItem(lastItem);
            itemPool.RemoveAt(itemPool.Count - 1);

            return $"{characterName} picked up {lastItem.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            var characterName = args[0];
            var itemName = args[1];

            if (this.party.Any(c => c.Name == characterName) == false)
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), characterName);
                throw new ArgumentException($"Character {characterName} not found!");
            }

            var character = this.party.FirstOrDefault(c => c.Name == characterName);
            var item = character.Bag.GetItem(itemName);

            character.UseItem(item);

            return $"{characterName} used {item.GetType().Name}.";
        }

        public string GetStats()
        {
            var orderedParty = this.party.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health);

            var sb = new StringBuilder();

            foreach (var character in orderedParty)
            {
                sb.AppendLine(character.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            var attackerName = args[0];
            var receiverName = args[1];

            if (this.party.Any(c => c.Name == attackerName) == false)
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), attackerName);
                throw new ArgumentException($"Character {attackerName} not found!");
            }
            if (this.party.Any(c => c.Name == receiverName) == false)
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), receiverName);
                throw new ArgumentException($"Character {attackerName} not found!");
            }


            var attacker = this.party.FirstOrDefault(c => c.Name == attackerName);
            var receiver = this.party.FirstOrDefault(c => c.Name == receiverName);

            if (attacker.GetType().Name != "Warrior")
            {
                // throw new ArgumentException(string.Format(ExceptionMessages.AttackFail), attacker.Name);
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            Warrior warrior = (Warrior)attacker;

            warrior.Attack(receiver);

            var sb = new StringBuilder();

            sb.AppendLine($"{attackerName} attacks {receiverName} for {attacker.AbilityPoints} hit points! {receiverName} has {receiver.Health}/{receiver.BaseHealth} HP and {receiver.Armor}/{receiver.BaseArmor} AP left!");

            if (receiver.Health == 0)
            {
                sb.AppendLine($"{receiver.Name} is dead!");
            }

            return sb.ToString().TrimEnd();

        }

        public string Heal(string[] args)
        {
            var healerName = args[0];
            var healingReceiverName = args[1];

            if (this.party.Any(c => c.Name == healerName) == false)
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), healerName
                throw new ArgumentException($"Character {healerName} not found!");
            }
            if (this.party.Any(c => c.Name == healingReceiverName) == false)
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty), healingReceiverName);

                throw new ArgumentException($"Character {healingReceiverName} not found!");
            }


            var healer = this.party.FirstOrDefault(c => c.Name == healerName);
            var receiver = this.party.FirstOrDefault(c => c.Name == healingReceiverName);

            if (healer.GetType().Name != "Priest")
            {
                //throw new ArgumentException(string.Format(ExceptionMessages.AttackFail), healer.Name);

                throw new ArgumentException($"{healer.Name} cannot heal!");
            }

            Priest priest = (Priest)healer;

            priest.Heal(receiver);

            return $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";



        }
    }
}
