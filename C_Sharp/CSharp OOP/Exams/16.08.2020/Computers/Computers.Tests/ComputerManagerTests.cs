using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Computers.Tests
{
    [TestFixture]
    public class Tests
    {
        private ComputerManager computerMenager;
        private Computer computer;

        [SetUp]
        public void Setup()
        {
            this.computerMenager = new ComputerManager();
            this.computer = new Computer("Dell", "SomeModel", 2000M);

        }

        [Test]
        public void ComputerMenager()
        {
            var anotherMenager = new ComputerManager();

            Assert.IsNotNull(anotherMenager);
        }

        [Test]
        public void Test_Computer()
        {
            Assert.IsNotNull(computer);
        }


        [Test]
        public void Test_Counter()
        {
            Assert.AreEqual(0, this.computerMenager.Computers.Count);
        }

        [Test]
        public void Test_Computers()
        {
            Assert.IsNotNull(this.computerMenager.Computers);
        }

        [Test]
        public void Test_AddComputer_WithInvalidArguments()
        {
            this.computerMenager.AddComputer(computer);

            var ex = Assert.Throws<ArgumentException>(() =>
             {
                 this.computerMenager.AddComputer(computer);
             });

            Assert.AreEqual("This computer already exists.", ex.Message);
        }

        [Test]
        public void Test_AddComputer_WithNullArguments()
        {
            Computer invalidComputer = null;

            Assert.That(() => this.computerMenager.AddComputer(invalidComputer),
                Throws.ArgumentNullException.With.Message.EqualTo("Can not be null! (Parameter 'computer')"));
        }

        [Test]
        public void Test_AddComputer()
        {
            this.computerMenager.AddComputer(computer);

            Assert.AreEqual(1, this.computerMenager.Computers.Count);
        }


        [Test]
        public void Test_RemoveComputerExceptionIfComputerNull()
        {

            this.computerMenager.AddComputer(computer);

            Assert.That(() => computerMenager.RemoveComputer(null, null), Throws.ArgumentNullException);
        }

        [Test]
        public void RemovingNonExistingComputer_Should_Throw()
        {
            computerMenager.AddComputer(computer);

            Assert.Throws<ArgumentException>(() =>
            {
                computerMenager.RemoveComputer("Samsung", "iComputer");
            });
        }


        [Test]
        public void Test_RemoveComputer()
        {
            this.computerMenager.AddComputer(computer);

            var targetComputer = this.computerMenager.RemoveComputer("Dell", "SomeModel");

            Assert.AreEqual(targetComputer, computer);
        }

        [Test]
        public void Test_RemoveComputerDecreaseCount()
        {
            computerMenager.AddComputer(computer);

            computerMenager.RemoveComputer("Dell", "SomeModel");
            Assert.AreEqual(0, computerMenager.Computers.Count);
        }

        [Test]
        public void Test_GetComputer_WithInvalidArguments()
        {
            this.computerMenager.AddComputer(computer);

            var ex = Assert.Throws<ArgumentException>(() =>
              {
                  this.computerMenager.GetComputer("Hp", "SomeOtherModel");
              });

            Assert.AreEqual("There is no computer with this manufacturer and model.", ex.Message);
        }

        [Test]
        public void Test_GetComputer()
        {
            this.computerMenager.AddComputer(computer);

            var targetComputer = this.computerMenager.GetComputer("Dell", "SomeModel");

            Assert.AreEqual(computer, targetComputer);
        }

        [Test]
        public void Test_GetComputerReturnsExceptionWithFirstFieldNull()
        {
            computerMenager.AddComputer(computer);

            Assert.That(() =>
                computerMenager.GetComputer(null, "Gosho"),
                Throws.ArgumentNullException);
        }
        [Test]
        public void Test_GetComputerReturnsExceptionWithSecondFieldNull()
        {
            computerMenager.AddComputer(computer);

            Assert.That(() =>
                computerMenager.GetComputer("Test", null),
                Throws.ArgumentNullException);
        }

        [Test]
        public void Test_GetComputersByManufacturer()
        {
            var anotherComputer = new Computer("Dell", "SomeOtherModel", 2400M);

            this.computerMenager.AddComputer(computer);
            this.computerMenager.AddComputer(anotherComputer);

            var expectedList = new List<Computer>() { computer, anotherComputer };
            var result = this.computerMenager.GetComputersByManufacturer("Dell");

            CollectionAssert.AreEqual(expectedList, result);
        }


        [Test]
        public void Test_GetComputersByManufactorerReturnsEmptyCollection()
        {
            computerMenager.AddComputer(computer);
            computerMenager.AddComputer(new Computer("Hp", "SomeOtherModel", 2300M));

            var emptyCollection = new List<Computer>();

            CollectionAssert.AreEqual(emptyCollection, computerMenager.GetComputersByManufacturer("Asus"));
        }

        [Test]
        public void Test_ValidateNullValue()
        {
            Computer invalidComputer = null;

            Assert.That(() =>
            this.computerMenager.AddComputer(invalidComputer), Throws.ArgumentNullException);
        }




    }
}