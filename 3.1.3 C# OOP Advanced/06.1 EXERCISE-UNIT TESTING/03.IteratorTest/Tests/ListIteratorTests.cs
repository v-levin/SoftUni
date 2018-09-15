using IteratorTest.Models;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection;

namespace IteratorTest.Tests
{
    [TestFixture]
    public class ListIteratorTests
    {
        private ListIterator listIterator;
        private string[] initializeCollection;

        [SetUp]
        public void TestInit()
        {
            this.initializeCollection = new string[] { "John", "Mike", "Scott" };
            this.listIterator = new ListIterator(this.initializeCollection);
        }

        [Test]
        public void ConstructorShouldThrowExceptionWhenNullCollectionIsPassed()
        {
            Assert.Throws<ArgumentNullException>(() => new ListIterator(null));
        }

        [Test]
        public void MoveMethodReturnsTrueIfSuccessful()
        {
            Assert.AreEqual(true, this.listIterator.Move());
        }

        [Test]
        public void MoveMethodReturnsFalseIfThereIsNoMoreElements()
        {
            // Act
            this.listIterator.Move();
            this.listIterator.Move();

            // Assert
            Assert.AreEqual(false, this.listIterator.Move());
        }

        [Test]
        public void MoveMethodMovesInternalIndexToTheNextElementInCollection()
        {
            // Act
            this.listIterator.Move();
            var internalIndex = this.listIterator.GetType()
                                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                                .First(f => f.Name == "currentIndex")
                                .GetValue(this.listIterator);

            // Assert
            Assert.AreEqual(1, internalIndex);
        }

        [Test]
        public void HasNextMethodReturnsTrueIfThereIsNextElement()
        {
            // Act
            this.listIterator.Move();

            // Assert
            Assert.IsTrue(this.listIterator.HasNext());
        }

        [Test]
        public void HasNextMethodReturnsFalseIfThereIsNoNextElement()
        {
            // Act
            this.listIterator.Move();
            this.listIterator.Move();

            // Assert
            Assert.IsFalse(this.listIterator.HasNext());
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void PrintReturnsAnElementAtCurrentIndex(int index)
        {
            // Act
            for (int i = 0; i < index; i++)
                this.listIterator.Move();

            // Assert
            Assert.AreEqual(this.initializeCollection[index], this.listIterator.Print());
        }

        [Test]
        public void PrintThrowsExceptionIfCollectionHasNoElements()
        {
            // Arrange
            this.listIterator = new ListIterator(new string[0]);

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.listIterator.Print());
        }
    }
}
