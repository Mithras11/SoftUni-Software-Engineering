using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        private string make;
        private string model;
        private double fuelConsumption;
        private double fuelCapacity;


        [SetUp]
        public void Setup()
        {
            make = "Make";
            model = "Model";
            fuelConsumption = 10;
            fuelCapacity = 100;
        }

        [Test]
        public void TestMake()
        {
            make = null;


            var ex = Assert.Throws<ArgumentException>(() =>
             {
                 car = new Car(make, model, fuelConsumption, fuelCapacity);
             });

            Assert.AreEqual(ex.Message, "Make cannot be null or empty!");
        }

        [Test]
        public void TestModel()
        {
            model = null;

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, model, fuelConsumption, fuelCapacity);
            });

            Assert.AreEqual(ex.Message, "Model cannot be null or empty!");
        }


        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void TestFuelConsumption(double consumption)
        {
            this.fuelConsumption = consumption;


            var ex = Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, model, fuelConsumption, fuelCapacity);
            });

            Assert.AreEqual(ex.Message, "Fuel consumption cannot be zero or negative!");
        }


        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void TestFuelCapacity(double capacity)
        {
            this.fuelCapacity = capacity;


            var ex = Assert.Throws<ArgumentException>(() =>
            {
                car = new Car(make, model, fuelConsumption, fuelCapacity);
            });

            Assert.AreEqual(ex.Message, "Fuel capacity cannot be zero or negative!");
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void TestRefuelIfNullOrNegative(double fuelToRefuel)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);

            var ex = Assert.Throws<ArgumentException>(() =>
            {
                car.Refuel(fuelToRefuel);
            });

            Assert.AreEqual(ex.Message, "Fuel amount cannot be zero or negative!");
        }

        [Test]
        [TestCase(10)]

        public void TestRefuel(double fuelToRefuel)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(fuelToRefuel);

            var expectedAmount = 10;

            Assert.AreEqual(expectedAmount, car.FuelAmount);
        }

        [Test]
        [TestCase(150)]

        public void TestRefuelIfAmountIsBiggerThanCapacity(double fuelToRefuel)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);

            car.Refuel(fuelToRefuel);

            var expectedAmount = car.FuelCapacity;

            Assert.AreEqual(expectedAmount, car.FuelAmount);
        }

        [Test]
        [TestCase(20)]
        public void TestDriveIfTankIsEmpty(double distance)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                car.Drive(distance);
            });

            Assert.AreEqual("You don't have enough fuel to drive!", ex.Message);
        }


        [Test]
        [TestCase(20)]
        public void TestDrive(double distance)
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(50);


            var fuelNeeded = (distance / 100) * car.FuelConsumption;

            var expectedResult = car.FuelAmount - fuelNeeded;
            

            car.Drive(distance);

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }


        [Test]
        public void TestConstructors()
        {
            car = new Car(make, model, fuelConsumption, fuelCapacity);

            var expectedMake = "Make";
            var expectedModel = "Model";
            var expectedConsumption = 10;
            var expectedCapacity = 100;
            var expectedAmount = 0;

            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedConsumption, car.FuelConsumption);
            Assert.AreEqual(expectedCapacity, car.FuelCapacity);
            Assert.AreEqual(expectedAmount, car.FuelAmount);

        }




    }
}