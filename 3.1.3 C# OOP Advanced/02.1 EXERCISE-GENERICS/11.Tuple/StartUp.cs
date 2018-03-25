using System;

namespace Tuple
{
    public class StartUp
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split();
            var names = $"{inputTokens[0]} {inputTokens[1]}";
            var address = inputTokens[2];
            var namesAddress = new Tuple<string, string>(names, address);
            Console.WriteLine(namesAddress);

            inputTokens = Console.ReadLine().Split();
            var name = inputTokens[0];
            var amountOfBeer = int.Parse(inputTokens[1]);
            var nameAmountOfBeer = new Tuple<string, int>(name, amountOfBeer);
            Console.WriteLine(nameAmountOfBeer);

            inputTokens = Console.ReadLine().Split();
            var intParam = int.Parse(inputTokens[0]);
            var doubleParam = double.Parse(inputTokens[1]);
            var intDouble = new Tuple<int, double>(intParam, doubleParam);
            Console.WriteLine(intDouble);
        }
    }
}
