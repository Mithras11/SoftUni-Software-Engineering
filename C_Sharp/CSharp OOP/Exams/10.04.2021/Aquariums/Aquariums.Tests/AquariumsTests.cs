namespace Aquariums.Tests
{
    using NUnit.Framework;
    using System;


    [TestFixture]
    public class AquariumsTests
    {
        private Aquarium aquarium;
        private string name;
        private int capacity;
        private Fish fish;
        private string fishName;


        [SetUp]
        public void SetUp()
        {
            this.name = "Bowl";
            this.capacity = 2;
            this.fishName = "Nemo";

            this.aquarium = new Aquarium(name, capacity);
            this.fish = new Fish(fishName);
        }

        [Test]
        public void Constructor_Should_Be_Working_Properly()
        {
            Assert.IsNotNull(aquarium);

        }


        [Test]
        public void Test_Name_Getter()
        {
            Assert.AreEqual("Bowl", aquarium.Name);
        }

        [Test]
        public void Test_Capacity_Getter()
        {
            Assert.AreEqual(2, aquarium.Capacity);
        }

        [Test]
        public void Test_Counter_Of_Fish()
        {
            Assert.AreEqual(0, aquarium.Count);

        }

        [Test]
        public void Exception_Should_Be_Thrown_When_Count_Reaches_Capacity()
        {
            aquarium.Add(fish);
            aquarium.Add(new Fish("Memo"));

            Assert.That(() => aquarium.Add(new Fish("Lemo")), Throws.InvalidOperationException);
        }

        [Test]
        public void Exception_Should_Be_Throw_When_Name_Is_Null()
        {

            Assert.That(() =>
            new Aquarium("", capacity),
            Throws.ArgumentNullException);

            Assert.That(() =>
            new Aquarium(null, capacity),
            Throws.ArgumentNullException);
        }

        [Test]
        public void Exception_Should_Be_Throw_When_Capacity_Is_Negative_Number()
        {
            Assert.That(() =>
           new Aquarium(name, -1),
           Throws.ArgumentException);
        }

        [Test]
        public void Add_Method_Should_Increase_Count()
        {
            aquarium.Add(fish);

            Assert.AreEqual(1, aquarium.Count);
        }

        [Test]
        public void Remove_Method_Should_Decrease_Count()
        {
            aquarium.Add(fish);
            aquarium.RemoveFish("Nemo");

            Assert.AreEqual(0, aquarium.Count);
        }

        [Test]
        public void Remove_Should_Throw_Exception_When_Fish_Is_Nonexistent()
        {
            aquarium.Add(fish);

            Assert.That(() => aquarium.RemoveFish("Memo"), Throws.InvalidOperationException);
        }

        [Test]
        public void Test_SellFish_Method()
        {
            aquarium.Add(fish);

            var targetFish = aquarium.SellFish("Nemo");

            Assert.AreSame(fish, targetFish);
        }

        [Test]
        public void SellFish_Should_Throw_Exception_When_Fish_Is_Nonexistent()
        {
            aquarium.Add(fish);

            Assert.That(() => aquarium.SellFish("Memo"), Throws.InvalidOperationException);
        }

        [Test]
        public void SellFish_Changes_Availabilty()
        {
            aquarium.Add(fish);

            aquarium.SellFish("Nemo");

            Assert.AreEqual(false, fish.Available);
        }

        [Test]
        public void Test_Report()
        {
            var anotherFish = new Fish("Memo");

            aquarium.Add(fish);
            aquarium.Add(anotherFish);

            string expectedMeassege = $"Fish available at {aquarium.Name}: {fish.Name}, {anotherFish.Name}";

            Assert.That(aquarium.Report(), Is.EqualTo(expectedMeassege));

        }

    }
}
