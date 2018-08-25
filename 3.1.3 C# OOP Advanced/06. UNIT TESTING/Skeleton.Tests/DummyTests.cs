using NUnit.Framework;
using System;

[TestFixture]
public class DummyTests
{
    private const int AttackPoints = 10;
    private const int DummyHealth = 25;
    private const int DummyExperience = 10;

    private Dummy dummy;

    [SetUp]
    public void InitDummy()
    {
        // Arrange
        dummy = new Dummy(DummyHealth, DummyExperience);
    }

    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        // Act
        dummy.TakeAttack(AttackPoints);
        
        // Assert
        Assert.AreEqual(15, dummy.Health);
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        // Act
        while (!dummy.IsDead())
            dummy.TakeAttack(AttackPoints);

        // Assert
        var ex = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(AttackPoints));
        Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyCanGiveExperience()
    {
        // Act
        while (!dummy.IsDead())
            dummy.TakeAttack(AttackPoints);

        var gotExperience = dummy.GiveExperience();

        // Assert
        Assert.AreEqual(DummyExperience, gotExperience, "Dead dummy doesn't give experience");
    }

    [Test]
    public void AliveDummyCannotGiveExperience()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
    }
}
