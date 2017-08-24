using System;
using System.Collections.Generic;

namespace _2.DiamondProblem
{
    public class DiamondProblem
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var diamonds = new List<string>();

            var tempString = string.Empty;

            while (inputLine.Contains("<"))
            {
                var openedDiamondIndex = inputLine.IndexOf("<");
                tempString = inputLine.Substring(openedDiamondIndex, inputLine.Length - openedDiamondIndex);

                if (tempString.Contains(">"))
                {
                    var closedDiamondIndex = tempString.IndexOf(">");

                    tempString = tempString.Substring(0, closedDiamondIndex + 1);

                    diamonds.Add(tempString);
                }

                inputLine = inputLine.Replace(tempString, string.Empty);
            }

            if (diamonds.Count > 0)
            {
                foreach (var diamond in diamonds)
                {
                    var carats = 0;
                    carats = FindCarats(diamond, carats);

                    Console.WriteLine($"Found {carats} carat diamond");
                }
            }
            else
            {
                Console.WriteLine("Better luck next time");
            }
        }

        private static int FindCarats(string diamond, int carats)
        {
            foreach (var character in diamond)
            {
                var digit = 0;
                if (int.TryParse(character.ToString(), out digit))
                {
                    carats += digit;
                }
            }

            return carats;
        }
    }
}
