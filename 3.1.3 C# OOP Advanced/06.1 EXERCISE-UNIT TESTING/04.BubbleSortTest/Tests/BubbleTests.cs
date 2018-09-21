using NUnit.Framework;

namespace BubbleSortTest.Tests
{
    [TestFixture]
    public class BubbleTests
    {
        [Test]
        [TestCase(8, 2, 3, 4, 5, 6, 7, 9, 1)]
        [TestCase(9, 8, 7, 6, 5, 4, 3, 2, 1)]
        public void BubbleShouldSortCollectionCorrectly(params int[] numbers)
        {
            // Arrange
            var bubble = new Bubble();
            var sortedNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            bubble.Sort(numbers);

            // Assert
            CollectionAssert.AreEqual(sortedNumbers, numbers);
        }
    }
}
