using Moq;
using NUnit.Framework;
using Skeleton.Interfaces;
using Skeleton.Tests.FakeObjects;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        private const string HeroName = "Juggernaut";

        [Test]
        public void HeroGainsExperenceAfterAttackIfTargetDies()
        {
            // Arrange
            var fakeTarget = new FakeTarget();
            var fakeWeapon = new FakeWeapon();
            var hero = new Hero(HeroName, fakeWeapon);

            // Act
            hero.Attack(fakeTarget);
            var expectedExperence = fakeTarget.GiveExperience();

            // Assert
            Assert.AreEqual(expectedExperence, hero.Experience);
        }

        [Test]
        public void HeroGainsExperenceAfterAttackIfTargetDiesMoqVersion()
        {
            // Arrange
            Mock<ITarget> fakeTarget = new Mock<ITarget>();
            fakeTarget.Setup(p => p.Health).Returns(0);
            fakeTarget.Setup(p => p.GiveExperience()).Returns(20);
            fakeTarget.Setup(p => p.IsDead()).Returns(true);

            Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
            Hero hero = new Hero(HeroName, fakeWeapon.Object);

            // Act
            hero.Attack(fakeTarget.Object);

            // Assert
            Assert.AreEqual(20, hero.Experience);
        }
    }
}
