using System;
using System.Collections.Generic;
using System.Linq;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag : IBag
    {
        private int capacity;
        private ICollection<Item> items;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
            this.items = new List<Item>();
        }

        public int Capacity
        {
            get => this.capacity;

            set
            {
                if (value <= 100)
                {
                    this.capacity = value;
                }

            }

        }

        public int Load => this.Items.Sum(i => i.Weight);

        public IReadOnlyCollection<Item> Items => this.items.ToList().AsReadOnly();

        public void AddItem(Item item)
        {
            if (item.Weight + this.Load > this.Capacity)
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            this.items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (this.items.Any() == false)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }

            if (this.items.Any(i => i.GetType().Name == name) == false)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            var item = this.items.FirstOrDefault(i => i.GetType().Name == name);
            this.items.Remove(item);

            return item;
        }
    }
}
