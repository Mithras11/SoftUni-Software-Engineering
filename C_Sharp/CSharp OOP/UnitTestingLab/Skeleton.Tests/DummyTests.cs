using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private const int HEALTH = 10;
    private const int EXPERIENCE = 10;
    private const int ATTACKPOINTS = 10;

    Dummy dummy;


    [SetUp]
    public void Init()
    {        
        dummy = new Dummy(10, 10);
    }

    [Test]
    public void DummyLoosesHealthAfterAttack()
    {
       

        dummy.TakeAttack(ATTACKPOINTS);

        Assert.That(dummy.Health, Is.EqualTo(0), "Dummy Healt doesn't change after attack");
    }


    [Test]
    public void DummyThrowsExceptionIfAttacked()
    {


        dummy.TakeAttack(ATTACKPOINTS);

        var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(ATTACKPOINTS));

        Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));

    }


    [Test]
    public void DummyCanGiveExperience()
    {
        var hero = new Hero("Pepi");

        hero.Attack(dummy);

        Assert.That(hero.Experience, Is.EqualTo(10), "Dummy doesn't give experience when dead");
    }

    [Test]
    public void AliveDummyCantGiveExperience()
    {
        var hero = new Hero("Pepi");

        dummy = new Dummy(20, 10);

        hero.Attack(dummy);

        var ex = Assert.Throws<InvalidOperationException>((() => dummy.GiveExperience()));

        Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
    }



}
