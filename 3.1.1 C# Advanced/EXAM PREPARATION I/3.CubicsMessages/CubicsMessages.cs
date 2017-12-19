using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3.CubicsMessages
{
    public class CubicsMessages
    {
        public static void Main()
        {
            var pattern = @"^\d+([a-zA-Z]+)[^a-zA-Z]*$";
            var regex = new Regex(pattern);

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Over!")
            {
                var messageLength = int.Parse(Console.ReadLine());

                var cubicMessage = regex.Match(inputLine);
                if (cubicMessage.Success)
                {
                    var message = cubicMessage.Groups[1].Value;
                    if (message.Length == messageLength)
                    {
                        List<int> indexes = GetIndexes(cubicMessage.Value);

                        var verificationCode = string.Empty;
                        for (int i = 0; i < indexes.Count; i++)
                        {
                            if (indexes[i] <= message.Length - 1)
                            {
                                verificationCode += message[indexes[i]];
                            }
                            else
                            {
                                verificationCode += " ";
                            }
                        }

                        Console.WriteLine($"{message} == {verificationCode}");
                    }
                }
            }
        }

        private static List<int> GetIndexes(string message)
        {
            var digits = Regex.Matches(message, @"\d");
            var indexes = new List<int>();
            foreach (Match digit in digits)
            {
                indexes.Add(int.Parse(digit.Value));
            }

            return indexes;
        }
    }
}
