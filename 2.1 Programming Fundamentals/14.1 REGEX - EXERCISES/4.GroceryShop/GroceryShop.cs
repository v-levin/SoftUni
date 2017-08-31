using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4.GroceryShop
{
    public class GroceryShop
    {
        public static void Main()
        {
            var products = new Dictionary<string, double>();

            var product = Console.ReadLine();

            var pattern = @"^([A-Z][a-z]+):(\d+\.\d{2}$)";
            var regex = new Regex(pattern);

            while (product != "bill")
            {
                if (regex.IsMatch(product))
                {
                    var prod = regex.Match(product).Groups[1].Value;
                    var price = double.Parse(regex.Match(product).Groups[2].Value);

                    if (!products.ContainsKey(prod))
                    {
                        products[prod] = 0;
                    }

                    products[prod] = price;
                }

                product = Console.ReadLine();
            }

            foreach (var item in products.OrderByDescending(p => p.Value))
            {
                var prod = item.Key;
                var price = item.Value;

                Console.WriteLine($"{prod} costs {price:0.00}");
            }
        }
    }
}
