using NUnit.Framework;
using System.Linq;

namespace Tests
{

    using System;
    using Database;

    public class DatabaseTests
    {
        private Database database;
        private int expectedResult;


        [SetUp]
        public void Setup()
        {
            var arr = Enumerable.Range(1, 15).ToArray();
            this.database = new Database(arr);
        }

        [Test]
        public void Database_Count_Should_Be_Correct()
        {
            expectedResult = 15;

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        [TestCase(5)]
        public void Add_Operation_Should_Add_An_Element_In_The_Next_Free_Sell(int number)
        {
            database.Add(number);

            expectedResult = 16;

            Assert.That(database.Count, Is.EqualTo(expectedResult));

        }

        [Test]
        [TestCase(16, 17)]
        public void Add_Operation_Should_Throw_Exception_If_Capacity_Limit_Is_Reached(int num, int extraNum)
        {
            database.Add(num);

            var ex = Assert.Throws<InvalidOperationException>(() => database.Add(extraNum));

            Assert.That(ex.Message, Is.EqualTo("Array's capacity must be exactly 16 integers!"));

        }

        [Test]

        public void Remove_Operation_Should_Remove_Only_An_Element_At_The_Last_Index()
        {
            database.Remove();

            expectedResult = 14;

            Assert.AreEqual(expectedResult, database.Count);
        }

        [Test]
        public void Remove_Operation_ShouldThrowException_If_Database_Is_Empty()
        {
            database = new Database();

            var ex = Assert.Throws<InvalidOperationException>(() => database.Remove());

            Assert.That(ex.Message, Is.EqualTo("The collection is empty!"));

        }

        [Test]
        public void Constructor_Should_Take_As_Parameters_Only_Integeres()
        {
            var arrOutOfRange = Enumerable.Range(1, 17).ToArray();
            Assert.That(() => new Database(arrOutOfRange), Throws.InvalidOperationException);
        }

        [Test]
        public void Fetch_Method_Should_Return_Elements_As_Array()
        {
            var arr = Enumerable.Range(1, 15).ToArray();

            var result = database.Fetch();

            Assert.AreEqual(arr, result);
        }

    }
}