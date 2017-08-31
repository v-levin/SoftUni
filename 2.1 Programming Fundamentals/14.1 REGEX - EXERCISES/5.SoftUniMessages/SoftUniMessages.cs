using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _5.SoftUniMessages
{
    public class SoftUniMessages
    {
        public static void Main()
        {
            var pattern = @"^(\d+)([A-Za-z]+)([^A-Za-z]+|\d+)$";
            var messagePattern = new Regex(pattern);

            var inputLine = Console.ReadLine();

            while (inputLine != "Decrypt!")
            {
                var length = int.Parse(Console.ReadLine());

                if (messagePattern.IsMatch(inputLine))
                {
                    var message = messagePattern.Match(inputLine).Groups[2].Value;

                    if (message.Length == length)
                    {
                        var leftPart = messagePattern.Match(inputLine).Groups[1].Value;
                        var rightPart = messagePattern.Match(inputLine).Groups[3].Value;
                        var allPartsWithDigits = leftPart + rightPart;

                        List<int> indices = GetIndices(allPartsWithDigits);

                        var decryptedMessage = DecryptMessage(message, indices);

                        Console.WriteLine($"{message} = {decryptedMessage}");
                    }
                }

                inputLine = Console.ReadLine();
            }
        }

        private static string DecryptMessage(string message, List<int> indices)
        {
            var decryptedMessage = string.Empty;

            foreach (var index in indices)
            {
                if (index < message.Length)
                {
                    decryptedMessage += message.ElementAt(index);
                }
            }

            return decryptedMessage;
        }

        private static List<int> GetIndices(string allPartsWithDigits)
        {
            var indices = new List<int>();

            foreach (var @char in allPartsWithDigits)
            {
                var digit = 0;
                if (int.TryParse(@char.ToString(), out digit))
                {
                    indices.Add(digit);
                }
            }

            return indices;
        }
    }
}
