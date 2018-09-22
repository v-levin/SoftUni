using Twitter.Interfaces;

namespace Twitter.Models
{
    public class MicrowaveOven : IClient
    {
        private readonly IWriter writer;
        private readonly ITweetRepository tweetRepo;

        public MicrowaveOven(IWriter writer, ITweetRepository tweetRepo)
        {
            this.writer = writer;
            this.tweetRepo = tweetRepo;
        }

        public void SendTweetToServer(string message) => this.tweetRepo.SaveTweet(message);

        public void WriteTweet(string message) => this.writer.WriteLine(message);
    }
}
