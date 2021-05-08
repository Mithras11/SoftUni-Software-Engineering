using NUnit.Framework;
using System;
//using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;

        private UnitCar car;
        private string model;
        private int horsePower;
        private double cubicCentimeters;

        private UnitDriver driver;
        private string name;


        [SetUp]
        public void Setup()
        {
            this.raceEntry = new RaceEntry();

            this.model = "Wagen";
            this.horsePower = 200;
            this.cubicCentimeters = 300;

            this.car = new UnitCar(model, horsePower, cubicCentimeters);

            this.name = "Pepi";
            this.driver = new UnitDriver(name, car);
        }

        [Test]
        public void Test_Constructor()
        {
            var someRaceEntry = new RaceEntry();
            var count= someRaceEntry.Counter;

            Assert.That(count, Is.EqualTo(0));

        }

        [Test]
        public void Test_AddDriver()
        {
            var message = raceEntry.AddDriver(driver);

            Assert.AreEqual("Driver Pepi added in race.", message);
        }
        
        [Test]
        public void Test_AddDriver_WithNullArgument()
        {
            UnitDriver invalidDriver = null;

            var ex = Assert.Throws<InvalidOperationException>(() =>
             {
                 raceEntry.AddDriver(invalidDriver);
             });

            Assert.AreEqual("Driver cannot be null.", ex.Message);


        }
        
        [Test]
        public void Test_AddDriver_WithExistingDriver()
        {
            raceEntry.AddDriver(driver);

            var ex = Assert.Throws<InvalidOperationException>(() =>
             {
                 raceEntry.AddDriver(driver);
             });

            Assert.AreEqual("Driver Pepi is already added.", ex.Message);

        }

        [Test]
        public void Test_CalculateAverageHorsePower_WithInvalidNumberOfDrivers()
        {
            raceEntry.AddDriver(driver);

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                raceEntry.CalculateAverageHorsePower();
            });

            Assert.AreEqual($"The race cannot start with less than 2 participants.", ex.Message);
        }

         [Test]
        public void Test_CalculateAverageHorsePower()
        {
            var anotherDriver = new UnitDriver("Gepi", new UnitCar("Auto", 400, 150));

            raceEntry.AddDriver(driver);
            raceEntry.AddDriver(anotherDriver);

            var result = raceEntry.CalculateAverageHorsePower();

            Assert.AreEqual(300, result);
        }



    }
}