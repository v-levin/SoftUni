using System;

namespace _01.ActionPrint
{
    public class ActionPrint
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split();
            Action<string> print = n => Console.WriteLine(n);
            PrintAllNames(names, print);
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
