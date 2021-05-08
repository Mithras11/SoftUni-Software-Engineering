namespace FishTests
{
    using Aquariums;
    using NUnit.Framework;

    [TestFixture]
    public class Tests
    {
        private Fish fish;
        private string name;



        [SetUp]
        public void Setup()
        {
            this.name = "Nemo";

            this.fish = new Fish(name);
        }

        [Test]
        public void Test_Constructor()
        {

            Assert.IsNotNull(new Fish("Memo"));
        }

        [Test]
        public void Test_Name_Getter()
        {
            Assert.AreEqual(name, fish.Name);
        }

        [Test]
        public void Setter_Should_Change_Name()
        {
            fish.Name = "Lemo";

            Assert.AreEqual("Lemo", fish.Name);
        }

        [Test]
        public void Test_Availability_Getter()
        {
            Assert.AreEqual(true, fish.Available);
        }

        [Test]
        public void Setter_Should_Change_Availability()
        {
            fish.Available = false;

            Assert.AreEqual(false, fish.Available);
        }


    }
}