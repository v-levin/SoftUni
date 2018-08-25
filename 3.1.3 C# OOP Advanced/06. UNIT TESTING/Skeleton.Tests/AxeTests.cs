﻿using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    private const int AxeAttack = 1;
    private const int AxeDurability = 1;
    private const int DummyHealth = 10;
    private const int DummyExperience = 10;

    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void TestInit()
    {
        // Arrange
        axe = new Axe(AxeAttack, AxeDurability);
        dummy = new Dummy(DummyHealth, DummyExperience);
    }

    [Test]
    public void AxeLosesDurabilityAfterAttack()
    {
        // Act
        axe.Attack(dummy);

        // Assert
        Assert.AreEqual(0, axe.DurabilityPoints, "Axe Durability doesn`t change after attack");
    }

    [Test]
    public void AttackWithBrokenWeapon()
    {
        // Act
        axe.Attack(dummy);

        // Assert
        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        Assert.That(ex.Message, Is.EqualTo("Axe is broken."));
    }
}
