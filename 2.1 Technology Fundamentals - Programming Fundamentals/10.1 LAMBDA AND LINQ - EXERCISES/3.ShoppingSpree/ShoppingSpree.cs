using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.ShoppingSpree
{
    public class ShoppingSpree
    {
        public static void Main()
        {
            var productsAndPrices = new Dictionary<string, decimal>();

            var budget = decimal.Parse(Console.ReadLine());

            var productAndPrice = Console.ReadLine();

            while (productAndPrice != "end")
            {
                var tokens = productAndPrice.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = string.Empty;
                var productPrice = 0m;
                var decimalPrice = 0m;

                if (decimal.TryParse(tokens[1], out decimalPrice))
                {
                    product = tokens[0];
                    productPrice = decimalPrice;
                }
                else
                {
                    product = string.Join(" ", tokens.Take(tokens.Length - 1));
                    productPrice = decimal.Parse(tokens[tokens.Length - 1]);
                }

                if (!productsAndPrices.ContainsKey(product))
                {
                    productsAndPrices[product] = productPrice;
                }
                else
                {
                    if (productsAndPrices[product] > productPrice)
                    {
                        productsAndPrices[product] = productPrice;
                    }
                }

                productAndPrice = Console.ReadLine();
            }

            var sum = productsAndPrices.Values.Sum();

            if (budget < sum)
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
            else
            {
                productsAndPrices
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key.Length)
                    .ToList()
                    .ForEach(x => Console.WriteLine($"{x.Key} costs {x.Value:f2}"));
            }
        }
    }
}
