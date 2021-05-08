using NUnit.Framework;

namespace Tests
{
    using ExtendedDatabase;
    using System;
    using System.Linq;

    public class ExtendedDatabaseTests
    {
        private Person Pepi;
        private Person Gogi;
        private ExtendedDatabase database;

        private int expectedResult;


        [SetUp]
        public void Setup()
        {
            Pepi = new Person(123456789, "Pepi");
            Gogi = new Person(123456789, "Gogi");
            this.database = new ExtendedDatabase();
        }

        [Test]
        public void Database_Count_Should_Be_Correct()
        {
            expectedResult = 1;

            database.Add(Pepi);

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void Add_Operation_Should_Throw_Exception_If_Person_With_Username_Already_Exists()
        {
            database.Add(Pepi);

            var Doppelganger = new Person(123456789, "Pepi");

            var ex = Assert.Throws<InvalidOperationException>(() =>
             {
                 database.Add(Doppelganger);
             });

            Assert.AreEqual("There is already user with this username!", ex.Message);

        }

        [Test]
        public void Add_Operation_Should_Throw_Exception_If_Person_With_ID_Already_Exists()
        {
            database.Add(Pepi);

            var ex = Assert.Throws<InvalidOperationException>(() =>
             {
                 database.Add(Gogi);
             });

            Assert.AreEqual("There is already user with this Id!", ex.Message);

        }

        [Test]
        public void Add_Should_Throw_Exeption_If_Count_Is_16()
        {
            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, $"Somebody{i})"));
            }

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                database.Add(Gogi);
            });

            Assert.AreEqual("Array's capacity must be exactly 16 integers!", ex.Message);

        }

        [Test]
        public void Remove_Method_Should_Throw_Exception_If_Database_Is_Empty()
        {
            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }


        [Test]
        public void Remove_Method_Should_Decrease_Count()
        {
            database.Add(Pepi);
            
            var expectedResult = 0;

            database.Remove();

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void FindByUsername_Should_Throw_Exception_If_No_User_Is_Present_WIth_Name()
        {
            database.Add(Pepi);

            var ex = Assert.Throws<InvalidOperationException>(() =>
            {
                Person somebody = database.FindByUsername("Gogi");
            });

            Assert.That(ex.Message, Is.EqualTo("No user is present by this username!"));
        }

        [Test]
        [TestCase(null)]
        public void FindByUsername_Should_Throw_Exception_If_Parameter_Is_Null(string name)
        {
           Assert.Throws<ArgumentNullException>(() => database.FindByUsername(name));

            //Assert.That(ex.Message, Is.EqualTo("Username parameter is null!"));
        }

        [Test]
        public void FindByUsername_Should_Return_Person()
        {
            database.Add(Pepi);
            var wanted = database.FindByUsername("Pepi");

            Assert.AreEqual(wanted.UserName, Pepi.UserName );

        }

        [Test]
        public void FindByUsername_Should_Be_Case_Sensitive()
        {
            database.Add(Gogi);
            var wanted = new Person(123456789, "Gogi");

           var ex = Assert.Throws<InvalidOperationException>(() => database.FindByUsername("gOgI"));

            Assert.That(ex.Message, Is.EqualTo("No user is present by this username!"));
        }

        [Test]
        public void FindById_Should_Throw_Exception_If_No_User_Is_Present_With_ID()
        {
            database.Add(Pepi);

            var ex= Assert.Throws<InvalidOperationException>(() =>
            {
                Person somebody = database.FindById(123456780);
            });

            Assert.That(ex.Message, Is.EqualTo("No user is present by this ID!"));
        }

        [Test]
        public void FindById_Should_Throw_Exception_If_ID_Is_Negative()
        {           

             Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Person somebody = database.FindById(-123456789);
            });

           // Assert.That(ex.Message, Is.EqualTo("Id should be a positive number!"));

        }


        [Test]
        public void FindById_Should_Return_Person()
        {
            database.Add(Pepi);
            var wanted = database.FindById(123456789);

            Assert.AreEqual(wanted.Id, Pepi.Id);

        }




    }
}