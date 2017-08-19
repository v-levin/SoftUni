using System;
using System.Linq;

namespace _3.ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => w.Length < 5)
                .Select(w => w.ToLower())
                .OrderBy(s => s)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
