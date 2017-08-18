using System;

namespace MoneyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgn = "BGN";
            var usd = "USD";
            var eur = "EUR";
            var gbp = "GBP";

            Console.Write("Enter the amount for converting: ");
            var value = double.Parse(Console.ReadLine());
            Console.Write("Currency from: ");
            var currencyFrom = Console.ReadLine();
            Console.Write("Currency to: ");
            var currencyTo = Console.ReadLine();

            if (currencyFrom == bgn && currencyTo == usd)
            {
                var result = Math.Round(value / 1.79549, 2);
                Console.WriteLine(result + " " + usd);
            }
            else if (currencyFrom == bgn && currencyTo == eur)
            {
                var result = Math.Round(value / 1.95583, 2);
                Console.WriteLine(result + " " + eur);
            }
            else if (currencyFrom == bgn && currencyTo == gbp)
            {
                var result = Math.Round(value / 2.53405, 2);
                Console.WriteLine(result + " " + gbp);
            }
            else if (currencyFrom == usd && currencyTo == bgn)
            {
                var result = Math.Round(value * 1.79549, 2);
                Console.WriteLine(result + " " + bgn);
            }
            else if (currencyFrom == usd && currencyTo == eur)
            {
                var result = Math.Round((value * 1.79549) / 1.95583, 2);
                Console.WriteLine(result + " " + eur);
            }
            else if (currencyFrom == usd && currencyTo == gbp)
            {
                var result = Math.Round((value * 1.79549) / 2.53405, 2);
                Console.WriteLine(result + " " + gbp);
            }
            else if (currencyFrom == eur && currencyTo == bgn)
            {
                var result = Math.Round(value * 1.95583, 2);
                Console.WriteLine(result + " " + bgn);
            }
            else if (currencyFrom == eur && currencyTo == usd)
            {
                var result = Math.Round((value * 1.95583) / 1.79549, 2);
                Console.WriteLine(result + " " + usd);
            }
            else if (currencyFrom == eur && currencyTo == gbp)
            {
                var result = Math.Round((value * 1.95583) / 2.53405, 2);
                Console.WriteLine(result + " " + gbp);
            }
            else if (currencyFrom == gbp && currencyTo == bgn)
            {
                var result = Math.Round(value * 2.53405, 2);
                Console.WriteLine(result + " " + bgn);
            }
            else if (currencyFrom == gbp && currencyTo == usd)
            {
                var result = Math.Round((value * 2.53405) / 1.79549, 2);
                Console.WriteLine(result + " " + usd);
            }
            else if (currencyFrom == gbp && currencyTo == eur)
            {
                var result = Math.Round((value * 2.53405) / 1.95583, 2);
                Console.WriteLine(result + " " + eur);
            }
            else
            {
                Console.WriteLine($"{value} {currencyTo}");
            }
        }
    }
}