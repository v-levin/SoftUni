using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.OrderedBankingSystem
{
    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var bankingSystemDict = new Dictionary<string, Dictionary<string, decimal>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = inputParams[0];
                var account = inputParams[1];
                var balance = decimal.Parse(inputParams[2]);

                if (!bankingSystemDict.ContainsKey(bank))
                {
                    bankingSystemDict[bank] = new Dictionary<string, decimal>();
                }

                if (!bankingSystemDict[bank].ContainsKey(account))
                {
                    bankingSystemDict[bank].Add(account, 0);
                }

                bankingSystemDict[bank][account] += balance;

                inputLine = Console.ReadLine();
            }

            bankingSystemDict
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList().ForEach(bank => bank.Value.OrderByDescending(account => account.Value).ToList()
                .ForEach(account => Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})")));
        }
    }
}
