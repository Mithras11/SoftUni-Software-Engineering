using Bakery.Core.Contracts;
using Bakery.Models.BakedFoods;
using Bakery.Models.BakedFoods.Contracts;
using Bakery.Models.Drinks;
using Bakery.Models.Drinks.Contracts;
using Bakery.Models.Tables;
using Bakery.Models.Tables.Contracts;
using Bakery.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bakery.Core
{
    public class Controller : IController
    {
        private ICollection<BakedFood> bakedFoods;
        private ICollection<Drink> drinks;
        private ICollection<Table> tables;

        private decimal totalBill = 0M;

        public Controller()
        {
            this.bakedFoods = new List<BakedFood>();
            this.drinks = new List<Drink>();
            this.tables = new List<Table>();
        }


        public string AddDrink(string type, string name, int portion, string brand)
        {
            Drink drink = null;

            if (type == "Tea")
            {
                drink = new Tea(name, portion, brand);
            }
            else if (type == "Water")
            {
                drink = new Water(name, portion, brand);
            }
            else
            {
                throw new ArgumentException();
            }

            this.drinks.Add(drink);


            return string.Format(OutputMessages.DrinkAdded, name, brand);
        }

        public string AddFood(string type, string name, decimal price)
        {
            BakedFood food = null;

            if (type == "Bread")
            {
                food = new Bread(name, price);
            }
            else if (type == "Cake")
            {
                food = new Cake(name, price);
            }
            else
            {
                throw new ArgumentException();
            }

            this.bakedFoods.Add(food);


            return string.Format(OutputMessages.FoodAdded, name, food.GetType().Name);
        }

        public string AddTable(string type, int tableNumber, int capacity)
        {
            Table table = null;

            if (type == "InsideTable")
            {
                table = new InsideTable(tableNumber, capacity);
            }
            else if (type == "OutsideTable")
            {
                table = new OutsideTable(tableNumber, capacity);
            }
            else
            {
                throw new ArgumentException();
            }

            this.tables.Add(table);


            return string.Format(OutputMessages.TableAdded, tableNumber);
        }

        public string GetFreeTablesInfo()
        {
            var freeTables = this.tables.Where(t => t.IsReserved == false);

            var sb = new StringBuilder();

            foreach (var table in freeTables)
            {
                sb.AppendLine(table.GetFreeTableInfo());
            }

            return sb.ToString().TrimEnd();
        }

        public string GetTotalIncome()
        {
            return $"Total income: {totalBill:f2}lv";
        }

        public string LeaveTable(int tableNumber)
        {
            var table = this.tables.FirstOrDefault(f => f.TableNumber == tableNumber);
            var bill = table.GetBill();
            totalBill += bill;

            table.Clear();

            var sb = new StringBuilder();
            sb.AppendLine($"Table: {tableNumber}");
            sb.AppendLine($"Bill: {bill:f2}");

            return sb.ToString().TrimEnd();

        }



        public string OrderDrink(int tableNumber, string drinkName, string drinkBrand)
        {
            string message = string.Empty;
            bool tableExists = false;
            bool drinkExists = false;


            if (this.tables.Any(t => t.TableNumber == tableNumber))
            {
                tableExists = true;

            }


            if (this.drinks.Any(d => d.Name == drinkName && d.Brand == drinkBrand))
            {
                drinkExists = true;

            }


            if (tableExists && drinkExists)
            {
                var targetTable = tables.FirstOrDefault(x => x.TableNumber == tableNumber);
                var targetDrink = drinks.FirstOrDefault(x => x.Name == drinkName && x.Brand == drinkBrand);
                targetTable.OrderDrink(targetDrink);

                message = $"Table {tableNumber} ordered {drinkName} {drinkBrand}";
            }
            else if (tableExists == false)
            {
                message = string.Format(OutputMessages.WrongTableNumber,tableNumber);
            }
            else if (drinkExists == false)
            {
                message = $"There is no {drinkName} {drinkBrand} available";
            }

            return message;
        }

        public string OrderFood(int tableNumber, string foodName)
        {
            string message = string.Empty;
            bool tableExists = false;
            bool mealExistins = false;


            if (this.tables.Any(t => t.TableNumber == tableNumber))
            {
                tableExists = true;

            }


            if (this.bakedFoods.Any(f => f.Name == foodName))
            {
                mealExistins = true;

            }

            if (mealExistins && tableExists)
            {
                Table targetTable = tables.Where(x => x.TableNumber == tableNumber).FirstOrDefault();
                BakedFood targetFood = bakedFoods.Where(x => x.Name == foodName).FirstOrDefault();
                targetTable.OrderFood(targetFood);

                message = $"Table {tableNumber} ordered {foodName}";
            }
            else if (tableExists == false)
            {
                message = string.Format(OutputMessages.WrongTableNumber, tableNumber);
            }
            else if (mealExistins == false)
            {
                message = $"No {foodName} in the menu";
            }

            return message;
        }

        public string ReserveTable(int numberOfPeople)
        {
            var table = this.tables.FirstOrDefault(x => x.IsReserved == false && x.Capacity >= numberOfPeople);

            if (table == null)
            {
                return string.Format(OutputMessages.ReservationNotPossible, numberOfPeople);
            }
            else
            {
                table.Reserve(numberOfPeople);
                return string.Format(OutputMessages.TableReserved, table.TableNumber, numberOfPeople);
            }
        }
    }
}
