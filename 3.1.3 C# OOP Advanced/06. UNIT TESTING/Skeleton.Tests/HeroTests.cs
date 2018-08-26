using NUnit.Framework;
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
    }
}
