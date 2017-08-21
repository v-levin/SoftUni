using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.Messages
{
    public class Messages
    {
        public class User
        {
            public string Username { get; set; }

            public List<Message> ReceivedMessages { get; set; }
        }

        public class Message
        {
            public string Content { get; set; }

            public User Sender { get; set; }
        }

        public static void Main()
        {
            var users = new Dictionary<string, User>();

            var inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                var inputParams = inputLine.Split();

                if (inputParams[0] == "register")
                {
                    var username = inputParams[1];

                    var user = new User()
                    {
                        Username = username,
                        ReceivedMessages = new List<Message>()
                    };

                    users.Add(username, user);
                }
                else
                {
                    var sender = inputParams[0];
                    var recipient = inputParams[2];
                    var message = inputParams[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        var userSender = users[sender];
                        var userMessage = new Message()
                        {
                            Content = message,
                            Sender = userSender
                        };

                        users[recipient].ReceivedMessages.Add(userMessage);
                    }
                }

                inputLine = Console.ReadLine();
            }

            var chatters = Console.ReadLine();

            var usernames = chatters.Split();
            var firstUser = usernames[0];
            var secondUser = usernames[1];

            var firstUserMessages = users[secondUser].ReceivedMessages.Where(x => x.Sender.Username == firstUser).ToArray();
            var secondUserMessages = users[firstUser].ReceivedMessages.Where(x => x.Sender.Username == secondUser).ToArray();

            if (firstUserMessages.Length == 0 && secondUserMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            var index = 0;
            while (index < firstUserMessages.Length && index < secondUserMessages.Length)
            {
                Console.WriteLine($"{firstUser}: {firstUserMessages[index].Content}");
                Console.WriteLine($"{secondUserMessages[index].Content} :{secondUser}");
                index++;
            }

            while (index < firstUserMessages.Length)
            {
                Console.WriteLine($"{firstUser}: {firstUserMessages[index].Content}");
                index++;
            }

            while (index < secondUserMessages.Length)
            {
                Console.WriteLine($"{secondUserMessages[index].Content} :{secondUser}");
                index++;
            }
        }   
    }
}
