using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private const int ATTACKPOINTS = 10;
    private const int DURABILITY = 10;

    private const int TARGET_HEALTH = 10;
    private const int TARGET_EXPERIENCE = 10;

    Axe axe;
    Dummy dummy;


    [SetUp]
    public void Init()
    {
         axe = new Axe(ATTACKPOINTS, DURABILITY);
         dummy = new Dummy(TARGET_HEALTH, TARGET_EXPERIENCE);

    }

    [Test]
    public void AxeLoosesDurabilityAfterAttack()
    {
        
        axe.Attack(dummy);

        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe Durability doesn't change after attack");
    }


    [Test]
    public void BrokenAxeCantAttack()
    {
        axe = new Axe(1, 1);
        
        // Act
        axe.Attack(dummy);
       

        // Assert
        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }
}