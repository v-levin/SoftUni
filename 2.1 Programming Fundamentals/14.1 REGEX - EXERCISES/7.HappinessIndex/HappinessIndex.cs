using System;
using System.Text.RegularExpressions;

namespace _7.HappinessIndex
{
    public class HappinessIndex
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var pattern = @"(?<happy>:\)|:D|;\)|:\*|:\]|;\]|:\}|;\}|\(:|\*:|c:|\[:|\[;)|(?<sad>:\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];)";
            var matchedEmoticons = Regex.Matches(inputLine, pattern);

            var happyEmoticonsCount = GetHappyEmoticons(matchedEmoticons);
            var sadEmoticonsCount = GetSadEmoticons(matchedEmoticons);

            var happinessIndex = (double)happyEmoticonsCount / sadEmoticonsCount;
            
            var emoticonScore = GetEmotconScore(happinessIndex);

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticonScore}");
            Console.WriteLine($"[Happy count: {happyEmoticonsCount}, Sad count: {sadEmoticonsCount}]");
        }

        private static string GetEmotconScore(double happinessIndex)
        {
            string emoticonScore;

            if (happinessIndex >= 2)
            {
                emoticonScore = ":D";
            }
            else if (happinessIndex > 1)
            {
                emoticonScore = ":)";
            }
            else if (happinessIndex == 1)
            {
                emoticonScore = ":|";
            }
            else
            {
                emoticonScore = ":(";
            }

            return emoticonScore;
        }

        private static int GetSadEmoticons(MatchCollection matchedEmoticons)
        {
            var sadEmoticonsCount = 0;

            foreach (Match emoticon in matchedEmoticons)
            {
                if (emoticon.Groups["sad"].Value.Contains(emoticon.ToString()))
                {
                    sadEmoticonsCount++;
                }
            }

            return sadEmoticonsCount;
        }

        private static int GetHappyEmoticons(MatchCollection matchedEmoticons)
        {
            var happyEmoticonsCount = 0;

            foreach (Match emoticon in matchedEmoticons)
            {
                if (emoticon.Groups["happy"].Value.Contains(emoticon.ToString()))
                {
                    happyEmoticonsCount++;
                }
            }

            return happyEmoticonsCount;
        }
    }
}
