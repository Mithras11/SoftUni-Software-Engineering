using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;

        private const string warriorName = "Somebody";
        private const int warriorDamage = 50;
        private const int warriorHP = 100;

        private Warrior warrior;


        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            warrior = new Warrior(warriorName, warriorDamage, warriorHP);
        }

        [Test]
        public void TestConstructor()
        {
            var expectedAmount = 0;

            Assert.AreEqual(expectedAmount, arena.Count);
        }

        [Test]
        public void TestEnroll()
        {

            var expectedWarrior = warrior;

            Assert.AreEqual(expectedWarrior.Name, warrior.Name);

        }

        [Test]
        public void TestEnrollIfaleradyContainsWarrior()
        {

            arena.Enroll(warrior);

            Warrior secondWarrior = new Warrior("Somebody", 50, 100);

            Assert.Throws<InvalidOperationException>(() => arena.Enroll(secondWarrior));

        }



        [Test]
        public void TestCount()
        {
            arena.Enroll(warrior);

            var expectedAmount = 1;

            Assert.AreEqual(expectedAmount, arena.Count);
        }

        [Test]

        public void TestFight()
        {
            var anotherWarrior = new Warrior("Nobody", 40, 60);

            arena.Enroll(warrior);
            arena.Enroll(anotherWarrior);

            var expectedResult = warrior.HP - anotherWarrior.Damage;

            arena.Fight(anotherWarrior.Name, warrior.Name);

            Assert.That(warrior.HP, Is.EqualTo(expectedResult));

        }


        [Test]
        [TestCase("Somebody", "Nemo")]
        [TestCase("Nero", "Nemo")]

        public void TestFightWithNullWarriors(string attackerName, string defenderName)
        {

            arena.Enroll(warrior);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(attackerName, defenderName);
            });

        }






    }
}
