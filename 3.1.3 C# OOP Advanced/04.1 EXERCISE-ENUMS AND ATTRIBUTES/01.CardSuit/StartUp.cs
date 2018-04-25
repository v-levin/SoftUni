using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardSuit
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine($"{input}:");

            foreach (var value in Enum.GetValues(typeof(CardSuit)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
