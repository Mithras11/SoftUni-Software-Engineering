using FakeAxeAndDummy.Tests.Fakes;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void WhenTargetDies()
    {
        FakeTarget target = new FakeTarget();
        FakeWeapon wepon = new FakeWeapon();

        Hero hero = new Hero("Gogi", wepon);

        hero.Attack(target);
       
        Assert.That(hero.Experience,Is.EqualTo(20));
    }
}