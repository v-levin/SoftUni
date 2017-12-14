using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.LittleJohn
{
    public class LittleJohn
    {
        public static void Main()
        {
            var smallArrow = ">----->";
            var mediumArrow = ">>----->";
            var largeArrow = ">>>----->>";

            var pattern = $@"(?:{smallArrow}|{mediumArrow}|{largeArrow})";
            var arrowsMatch = new Regex(pattern);

            var smallArrowsCount = 0;
            var mediumArrowsCount = 0;
            var largeArrowsCount = 0;

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                var isMatch = arrowsMatch.IsMatch(input);

                if (isMatch)
                {
                    var matches = arrowsMatch.Matches(input);

                    foreach (Match match in matches)
                    {
                        if (match.Value == smallArrow)
                        {
                            smallArrowsCount++;
                        }
                        else if (match.Value == mediumArrow)
                        {
                            mediumArrowsCount++;
                        }
                        else if (match.Value == largeArrow)
                        {
                            largeArrowsCount++;
                        }
                    }
                }
            }


            var numAsString = $"{smallArrowsCount}{mediumArrowsCount}{largeArrowsCount}";

            var decNumber = int.Parse(numAsString);

            var binNumber = Convert.ToString(decNumber, 2);
            var reversedBin = new string(binNumber.Reverse().ToArray());
            var totalBin = binNumber + reversedBin;

            var encryptedCountOfArrows = Convert.ToInt32(totalBin, 2);

            Console.WriteLine(encryptedCountOfArrows);
        }
    }
}
