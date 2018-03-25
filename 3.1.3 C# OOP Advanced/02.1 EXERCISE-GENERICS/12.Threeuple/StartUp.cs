using System;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split();
            var fullName = $"{inputTokens[0]} {inputTokens[1]}";
            var address = inputTokens[2];
            var town = inputTokens[3];
            var nameAddressTown = new Threeuple<string, string, string>(fullName, address, town);
            Console.WriteLine(nameAddressTown);

            inputTokens = Console.ReadLine().Split();
            var name = inputTokens[0];
            var beerLiters = int.Parse(inputTokens[1]);
            var isDrunk = (inputTokens[2] == "drunk") ? true : false;
            var nameBeerLitersIsDrunk = new Threeuple<string, int, bool>(name, beerLiters, isDrunk);
            Console.WriteLine(nameBeerLitersIsDrunk);

            inputTokens = Console.ReadLine().Split();
            name = inputTokens[0];
            var accountBalance = double.Parse(inputTokens[1]);
            var bankName = inputTokens[2];
            var nameAccountBalanceBank = new Threeuple<string, double, string>(name, accountBalance, bankName);
            Console.WriteLine(nameAccountBalanceBank);
        }
    }
}
