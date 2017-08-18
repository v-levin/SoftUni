
using System;

namespace _8_StringEncryption
{
    class StringEncryption
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string encryptedString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char currentLetter = char.Parse(Console.ReadLine());

                encryptedString += Encrypt(currentLetter);
            }

            Console.WriteLine(encryptedString);
        }

        static string Encrypt(char letter)
        {
            int asciiCode = letter;

            int firstDigit = GetFirstDigit(asciiCode);
            int lastDigit = GetLastDigit(asciiCode);

            char firstChar = (char)(asciiCode + lastDigit);
            char lastChar = (char)(asciiCode - firstDigit);

            string result = $"{firstChar}{firstDigit}{lastDigit}{lastChar}";

            return result;
        }

        static int GetLastDigit(int asciiCode)
        {
            int lastDigit = asciiCode % 10;

            return lastDigit;
        }

        static int GetFirstDigit(int asciiCode)
        {
            int firstDigit = asciiCode;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }

            return firstDigit;
        }
    }
}
