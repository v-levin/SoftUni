using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.SocialMediaPosts
{
    class SocialMediaPosts
    {
        static Dictionary<string, Dictionary<string, string>> postComments = new Dictionary<string, Dictionary<string, string>>();
        static Dictionary<string, int> postLikes = new Dictionary<string, int>();
        static Dictionary<string, int> postDislikes = new Dictionary<string, int>();

        public static void Main()
        {
            var comments = new Dictionary<string, Dictionary<string, string>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "drop the media")
            {
                var inputTokens = inputLine.Split(' ');
                var command = inputTokens[0];
                var postName = inputTokens[1];

                switch (command)
                {
                    case "post":
                        CreatePost(postName);
                        break;
                    case "like":
                        LikePost(postName);
                        break;
                    case "dislike":
                        DislikePost(postName);
                        break;
                    case "comment":
                        var commentatorName = inputTokens[2];
                        var commentContent = string.Join(" ", inputTokens.Skip(3));
                        CommentPost(postName, commentatorName, commentContent);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var postCommentData in postComments)
            {
                var postName = postCommentData.Key;
                var likes = postLikes[postName];
                var dislikes = postDislikes[postName];

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                if (postCommentData.Value.Count == 0)
                {
                    Console.WriteLine("None");
                    continue;
                }

                foreach (var commentsData in postCommentData.Value)
                {
                    var commentatorName = commentsData.Key;
                    var commentContent = commentsData.Value;

                    Console.WriteLine($"*  {commentatorName}: {commentContent}");
                }
            }
        }

        static void CreatePost(string postName)
        {
            postComments.Add(postName, new Dictionary<string, string>());
            postLikes.Add(postName, 0);
            postDislikes.Add(postName, 0);
        }

        static void LikePost(string postName)
        {
            postLikes[postName]++;
        }

        static void DislikePost(string postName)
        {
            postDislikes[postName]++;
        }

        static void CommentPost(string postName, string commentatorNmae, string commentContent)
        {
            postComments[postName].Add(commentatorNmae, commentContent);
        }
    }
}
