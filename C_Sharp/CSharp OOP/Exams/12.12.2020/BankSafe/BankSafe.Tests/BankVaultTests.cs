using NUnit.Framework;
using System;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bankVault;
        private string cellKey;
        private Item item;

        [SetUp]
        public void Setup()
        {
            this.bankVault = new BankVault();
            this.cellKey = "A1";
            item = new Item("Az", "123456");
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreEqual(12, this.bankVault.VaultCells.Count);
        }

        [Test]

        public void Test_AddItem_WithInvalidCell()
        {
            string invalidCellKey = "D1";

            var ex = Assert.Throws<ArgumentException>(() =>
                  {
                      this.bankVault.AddItem(invalidCellKey, item);
                  }
                 );

            Assert.AreEqual("Cell doesn't exists!", ex.Message);
        }


        [Test]

        public void Test_AddItem_WithInvalidItem()
        {

            this.bankVault.AddItem(cellKey, item);
            var newItem = new Item("Toy", "123245");


            var ex = Assert.Throws<ArgumentException>(() =>
                  {
                      this.bankVault.AddItem(cellKey, newItem);
                  }
                 );

            Assert.AreEqual("Cell is already taken!", ex.Message);
        }



        [Test]

        public void Test_AddItem_WthItemAlreadyInCell()
        {

            this.bankVault.AddItem(cellKey, item);


            var ex = Assert.Throws<InvalidOperationException>(() =>
                  {
                      this.bankVault.AddItem("B1", item);
                  }
                 );

            Assert.AreEqual("Item is already in cell!", ex.Message);
        }


        [Test]

        public void Test_AddItem()
        {

            var message = this.bankVault.AddItem(cellKey, item);


            Assert.AreEqual($"Item:{item.ItemId} saved successfully!", message);
        }


        [Test]
        public void Test_RemoveItem_WithInvalidCell()
        {
            this.bankVault.AddItem(cellKey, item);

            string invalidCellKey = "D1";

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                this.bankVault.RemoveItem(invalidCellKey, item);
            }
                 );

            Assert.AreEqual("Cell doesn't exists!", ex.Message);
        }


        [Test]

        public void Test_RemoveItem_WithInvalidItem()
        {

            this.bankVault.AddItem(cellKey, item);
            var newItem = new Item("Toy", "123245");


            var ex = Assert.Throws<ArgumentException>(() =>
            {
                this.bankVault.RemoveItem(cellKey, newItem);
            }
                 );

            Assert.AreEqual($"Item in that cell doesn't exists!", ex.Message);
        }


        [Test]
        public void Test_RemoveItem()
        {
            this.bankVault.AddItem(cellKey, item);
            var message = this.bankVault.RemoveItem(cellKey, item);


            Assert.AreEqual($"Remove item:{item.ItemId} successfully!", message);
        }

    }
}