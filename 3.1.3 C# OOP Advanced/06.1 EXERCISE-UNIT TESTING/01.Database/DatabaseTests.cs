using NUnit.Framework;
using System;

namespace Database
{
    [TestFixture]
    public class DatabaseTests
    {
        private const int MaxCapacity = 16;
        private const int ValidLength = 5;
        private const int TestNumber = 12;

        private Database database;

        [SetUp]
        public void InitDatabase()
        {
            this.database = new Database(new int[ValidLength]);
        }

        [Test]
        public void ThrownExceptionIfMoreElelemtsThenTheCapasityArePassedThroughConstructor()
        {
            Assert.Throws<InvalidOperationException>(() => new Database(new int[MaxCapacity + 1]));
        }

        [Test]
        public void AddElementShouldAddInTheNextFreeCell()
        {
            // Act
            this.database.Add(TestNumber);
            var firstIndex = database.Index;
            this.database.Add(TestNumber);
            var secondIndex = database.Index;

            // Assert
            Assert.AreEqual(firstIndex, secondIndex - 1);
        }

        [Test]
        public void ExceptionThrownIfTryToInsertMoreElementsThanCapacity()
        {
            // Arrange
            this.database = new Database(new int[MaxCapacity]);
            
            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(TestNumber));
        }

        [Test]
        public void RemoveElementShouldRemoveOnlyLastElement()
        {
            // Act
            this.database.Add(TestNumber);
            var lastIndex = this.database.Index;
            this.database.Remove();
            var currentIndex = this.database.Index;

            // Assert
            Assert.AreEqual(lastIndex, currentIndex + 1);
        }

        [Test]
        public void ExceptionThrownWhenTryToRemoveElementFromEmptyDatabase()
        {
            // Arranage
            this.database = new Database(new int[0]);

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void FetchMethodShouldReturnElemetsAsArray()
        {
            // Assert
            Assert.That(this.database.Fetch() is Array);
        }
    }
}
