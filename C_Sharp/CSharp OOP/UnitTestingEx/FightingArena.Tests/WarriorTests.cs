using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        private Warrior weakWarior;
        private Warrior strongWarior;
        private const string Name = "Caesar";

        private const int Damage = 10;
        private const int Hp = 80;

        [SetUp]
        public void Setup()
        {
            warrior = new Warrior(Name, Damage, Hp);
            this.weakWarior = new Warrior("Caligula", 5, 31);
            this.strongWarior = new Warrior("Cato", 100, 200);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.AreEqual(Name, warrior.Name);
            Assert.AreEqual(Damage, warrior.Damage);
            Assert.AreEqual(Hp, warrior.HP);
        }


        [Test]
        [TestCase(null, Damage, Hp)]
        [TestCase("", Damage, Hp)]
        [TestCase("Caesar", 0, Hp)]
        [TestCase("Caesar", -1, Hp)]
        [TestCase("Caesar", Damage, -1)]
        public void TestConstructorWithInvalidParameters(string name, int damage, int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                warrior = new Warrior(name, damage, hp);
            });
        }


        [Test]
        [TestCase(20)]
        [TestCase(30)]
        public void TestAttackIfHpIsInvalid(int invalidHp)
        {
            warrior = new Warrior(Name, Damage, invalidHp);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(weakWarior);
            });
        }


        [Test]
        [TestCase(20)]
        [TestCase(30)]
        public void TestAttackIfOponentHasInvalidHp(int invalidHp)
        {
            weakWarior = new Warrior("Caligula", 5, invalidHp);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(weakWarior);
            });
        }


        [Test]

        public void TestAttackIfOponentHasHigherDamage()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(strongWarior);
            });
        }

        [Test]
        public void TestHpAfterAttack()
        {
            var expectedResult = warrior.HP - weakWarior.Damage;

            warrior.Attack(weakWarior);

            Assert.AreEqual(expectedResult, warrior.HP);
        }

        [Test]
        public void TestHpWhenDamageIsBigger()
        {
            strongWarior.Attack(weakWarior);

            Assert.That(weakWarior.HP, Is.EqualTo(0));         


        }






    }
}