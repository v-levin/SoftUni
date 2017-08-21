using System;
using System.Collections.Generic;

namespace _4.ExamShopping
{
    class ExamShopping
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var stockProducts = new Dictionary<string, int>();

            StockProduct(input, stockProducts);

            input = Console.ReadLine();

            BuyProduct(input, stockProducts);

            PrintResult(stockProducts);
        }

        static void PrintResult(Dictionary<string, int> stockProducts)
        {
            foreach (var kvp in stockProducts)
            {
                var product = kvp.Key;
                var quantity = kvp.Value;

                if (quantity > 0)
                {
                    Console.WriteLine($"{product} -> {quantity}");
                }
            }
        }

        static void BuyProduct(string input, Dictionary<string, int> stockProducts)
        {
            while (!input.Equals("exam time"))
            {
                var currentLine = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = currentLine[1];
                var quantity = int.Parse(currentLine[2]);

                if (!stockProducts.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else if (stockProducts[product] <= 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else
                {
                    stockProducts[product] -= quantity;
                }

                input = Console.ReadLine();
            }
        }

        static void StockProduct(string input, Dictionary<string, int> stockProducts)
        {
            while (!input.Equals("shopping time"))
            {
                var currentLine = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var product = currentLine[1];
                var quantity = int.Parse(currentLine[2]);

                if (!stockProducts.ContainsKey(product))
                {
                    stockProducts[product] = 0;
                }

                stockProducts[product] += quantity;

                input = Console.ReadLine();
            }
        }
    }
}
