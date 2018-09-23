using NUnit.Framework;
using System;

namespace DateTimeNowAddDays.Tests
{
    [TestFixture]
    public class AddDaysTests
    {
        private IDateTime date;

        [SetUp]
        public void TestInit()
        {
            this.date = new MyDateTime();
        }

        [Test]
        public void NowShouldReturnCurrentDate()
        {
            // Arrange 
            var expectedValue = DateTime.Now.Date;

            // Assert
            Assert.AreEqual(expectedValue, this.date.Now().Date);
        }

        [Test]
        public void AddingADayToTheLastOneOfAMonthShouldResultInTheFirstDayOfTheNextMonth()
        {
            // Arrange
            var testDate = new DateTime(2000, 10, 31);
            var expectedDate = new DateTime(2000, 11, 1);

            // Act
            testDate = testDate.AddDays(1);

            // Assert
            Assert.AreEqual(expectedDate, testDate);
        }
    }
}
