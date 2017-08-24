using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.DeserializeString
{
    public class DeserializeString
    {
        public static void Main()
        {
            var indexOfLetters = new Dictionary<int, string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(':');
                var letter = inputParams[0];
                var positions = inputParams[1].Split('/');

                foreach (var position in positions)
                {
                    var index = int.Parse(position);

                    indexOfLetters[index] = letter;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var letter in indexOfLetters.OrderBy(l => l.Key))
            {
                Console.Write(letter.Value);
            }

            Console.WriteLine();
        }
    }
}
