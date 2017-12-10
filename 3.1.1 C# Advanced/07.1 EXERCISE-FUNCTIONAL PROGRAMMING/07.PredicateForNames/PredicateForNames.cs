using System;

namespace _07.PredicateForNames
{
    public class PredicateForNames
    {
        public static void Main()
        {
            var nameLength = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, bool> isValidName = n => n.Length <= nameLength;

            PrintResult(names, isValidName);
        }

        private static void PrintResult(string[] names, Func<string, bool> isValidName)
        {
            foreach (var name in names)
            {
                if (isValidName(name))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
