using System;

namespace CardRank
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Console.WriteLine($"{input}:");
            
            foreach (var value in Enum.GetValues(typeof(CardRank)))
            {
                Console.WriteLine($"Ordinal value: {(int)value}; Name value: {value}");
            }
        }
    }
}
