using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Models.Tables
{
    public abstract class Table : ITable
    {
        private int tableNumber;
        private int capacity;
        private int numberOfPeople;
        private decimal pricePerPerson;
        private bool isReserved;
        //private decimal price;

        private ICollection<IBakedFood> foodOrders;
        private ICollection<IDrink> drinkOrders;


        protected Table(int tableNumber, int capacity, decimal pricePerPerson)
        {
            this.TableNumber = tableNumber;
            this.Capacity = capacity;
            this.PricePerPerson = pricePerPerson;
            this.foodOrders = new List<IBakedFood>();
            this.drinkOrders = new List<IDrink>();
        }


        public int TableNumber
        {

            get => this.tableNumber;
            private set
            {
                this.tableNumber = value;
            }
        }

        public int Capacity
        {
            get => this.capacity;

            private set
            {
                if (value < 0)//?
                {
                    throw new ArgumentException(ExceptionMessages.InvalidTableCapacity);
                }

                this.capacity = value;
            }
        }


        public int NumberOfPeople
        {
            get => this.numberOfPeople;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidNumberOfPeople);
                }

                this.numberOfPeople = value;
            }
        }

        public decimal PricePerPerson
        {


            get => this.pricePerPerson;
            private set
            {
                this.pricePerPerson = value;
            }
        }

        public bool IsReserved
        {
            get => this.isReserved;
            private set
            {
                this.isReserved = value;
            }
        }

        public decimal Price
        {
            get => this.foodOrders.Sum(f => f.Price) + this.drinkOrders.Sum(d => d.Price) + this.NumberOfPeople * this.PricePerPerson;
        }
            
        





        public void Clear()
        {
            this.foodOrders.Clear();
            this.drinkOrders.Clear();
            this.IsReserved = false;
            this.Capacity = 0;
        }

        public decimal GetBill()
        {
            
            return this.Price;
        }

        public string GetFreeTableInfo()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Table: {this.TableNumber}");
            sb.AppendLine($"Type: {this.GetType().Name}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Price per Person: {this.PricePerPerson}");

            return sb.ToString().TrimEnd();
        }

        public void OrderDrink(IDrink drink)
        {
            this.drinkOrders.Add(drink);
        }

        public void OrderFood(IBakedFood food)
        {
            this.foodOrders.Add(food);
        }

        public void Reserve(int numberOfPeople)
        {
            this.NumberOfPeople = numberOfPeople;
            this.IsReserved = true;
        }
    }
}
