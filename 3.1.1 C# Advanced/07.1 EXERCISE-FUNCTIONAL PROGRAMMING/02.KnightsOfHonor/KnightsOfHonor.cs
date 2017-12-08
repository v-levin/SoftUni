using System;

namespace _02.KnightsOfHonor
{
    public class KnightsOfHonor
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            Action<string> printWithPrefix = n => Console.WriteLine($"Sir {n}");
            PrintAllNames(names, printWithPrefix);
        }

        private static void PrintAllNames(string[] names, Action<string> print)
        {
            foreach (var name in names)
            {
                print(name);
            }
        }
    }
}
