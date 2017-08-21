using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.OptimizedBankingSystem
{
    public class OptimizedBankingSystem
    {
        public class BankAccount
        {
            public string Name { get; set; }

            public string Bank { get; set; }

            public decimal Balance { get; set; }
        }

        public static void Main()
        {
            var accounts = new List<BankAccount>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = inputParams[0];
                var accountName = inputParams[1];
                var accountBlance = decimal.Parse(inputParams[2]);

                var account = new BankAccount();

                account.Name = accountName;
                account.Bank = bank;
                account.Balance = accountBlance;

                accounts.Add(account);

                inputLine = Console.ReadLine();
            }

            accounts.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length).ToList().ForEach(x => Console.WriteLine($"{x.Name} -> {x.Balance} ({x.Bank})"));
        }
    }
}
