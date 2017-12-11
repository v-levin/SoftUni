using System;
using System.Linq;

namespace _13.TriFunction
{
    public class TriFunction
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();

            Func<string, int, bool> isValidWord = (str, num) => str.ToCharArray().Select(c => (int)c).Sum() >= num;
            Func<string[], int, Func<string, int, bool>, string> firstValidName = (namesArr, num, func) => namesArr.FirstOrDefault(str => func(str, num));

            var result = firstValidName(names, n, isValidWord);
            Console.WriteLine(result);
        }
    }
}
