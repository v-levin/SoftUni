using System;
using System.Linq;

namespace _3.CountUppercaseWords
{
    public class CountUppercaseWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> checker = w => w[0] == w.ToUpper()[0];

            words.Where(checker).ToList().ForEach(w => Console.WriteLine(w));
        }
    }
}
