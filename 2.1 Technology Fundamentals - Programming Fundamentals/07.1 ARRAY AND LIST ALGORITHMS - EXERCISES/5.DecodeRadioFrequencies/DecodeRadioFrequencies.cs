using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        static void Main()
        {
            var frequencies = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            List<int> frequenciesToInt = new List<int>();
            List<char> result = new List<char>();

            SeparateDecimals(frequencies, frequenciesToInt);

            ConvertToChar(frequenciesToInt, result);

            Console.WriteLine(string.Join("", result));
        }

        private static void SeparateDecimals(decimal[] frequencies, List<int> frequenciesToInt)
        {
            for (int i = 0; i < frequencies.Length; i++)
            {
                var currentNumber = frequencies[i];

                var separatedDecimal = currentNumber.ToString().Split('.');

                frequenciesToInt.Add(int.Parse(separatedDecimal[0]));
                frequenciesToInt.Add(int.Parse(separatedDecimal[1]));
            }
        }

        static void ConvertToChar(List<int> frequenciesToInt, List<char> result)
        {
            for (int i = 0; i < frequenciesToInt.Count; i += 2)
            {
                if (frequenciesToInt[i] < 32)
                {
                    continue;
                }
                else
                {
                    result.Add((char)frequenciesToInt[i]);
                }
            }

            for (int i = frequenciesToInt.Count - 1; i > 0; i -= 2)
            {
                if (frequenciesToInt[i] < 32)
                {
                    continue;
                }
                else
                {
                    result.Add((char)frequenciesToInt[i]);
                }
            }
        }
    }
}
