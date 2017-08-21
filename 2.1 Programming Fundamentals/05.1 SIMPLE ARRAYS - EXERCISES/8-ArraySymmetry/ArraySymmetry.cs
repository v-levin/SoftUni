using System;
using System.Linq;

namespace _8_ArraySymmetry
{
    class ArraySymmetry
    {
        static void Main()
        {
            string[] strings = Console.ReadLine().Split(' ');

            bool isSymmetry = true;

            for (int i = 0; i < strings.Length / 2; i++)
            {
                string firstWord = strings[i];
                string secondWord = strings[strings.Length - 1 - i];

                if (firstWord != secondWord)
                {
                    isSymmetry = false;
                    break;
                }
            }

            if (isSymmetry)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
