using System;

namespace EqualWords
{
    class Program
    {
        static void Main()
        {
            var firstWord = Console.ReadLine();
            firstWord = firstWord.ToLower();
            var secondWord = Console.ReadLine();
            secondWord = secondWord.ToLower();

            if (firstWord == secondWord)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");      
            }
        }
    }
}