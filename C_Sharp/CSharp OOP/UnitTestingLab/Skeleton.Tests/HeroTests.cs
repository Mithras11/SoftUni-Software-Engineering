using NUnit.Framework;

[TestFixture]
public class HeroTests
{

    [Test]
    public void HeroShouldReceiveExperienceAfterAttack()
    {
        var hero = new Hero("Pepi");
        var axe = new Axe(10, 10);
        var dummy = new Dummy(10, 10);


        hero.Attack(dummy);

        var expectedExp = 10;

        Assert.AreEqual(expectedExp, hero.Experience, "Target is not dead.");
    }
}