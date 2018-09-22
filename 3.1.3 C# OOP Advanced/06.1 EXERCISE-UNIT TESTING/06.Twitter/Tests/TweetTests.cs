using Moq;
using NUnit.Framework;
using Twitter.Interfaces;
using Twitter.Models;

namespace Twitter.Tests
{
    [TestFixture]
    public class TweetTests
    {
        [Test]
        public void ReceiveMessageShouldInvokeItsClientToWriteTheMessage()
        {
            // Arrange
            var client = new Mock<IClient>();
            client.Setup(c => c.WriteTweet(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            // Act
            tweet.ReceiveMessage("Test");

            // Assert
            client.Verify(c => c.WriteTweet(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void ReceiveMessageShouldInvokeItsClientToSendTheMessageToTheServer()
        {
            // Arrange
            var client = new Mock<IClient>();
            client.Setup(c => c.SendTweetToServer(It.IsAny<string>()));
            var tweet = new Tweet(client.Object);

            // Act
            tweet.ReceiveMessage("Test");

            // Assert
            client.Verify(c => c.SendTweetToServer(It.IsAny<string>()), Times.Once);
        }
    }
}
