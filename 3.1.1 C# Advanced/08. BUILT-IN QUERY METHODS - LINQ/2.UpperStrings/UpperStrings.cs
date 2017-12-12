using System;
using System.Linq;

namespace _2.UpperStrings
{
    public class UpperStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .ToList();

            words.Select(n => n.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));
        }
    }
}
