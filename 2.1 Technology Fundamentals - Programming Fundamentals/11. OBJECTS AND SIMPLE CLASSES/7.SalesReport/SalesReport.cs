using System;
using System.Collections.Generic;

namespace _7.SalesReport
{
    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public static Sale Parse(string saleAsString)
        {
            var saleParams = saleAsString.Split();

            return new Sale
            {
                Town = saleParams[0],
                Product = saleParams[1],
                Price = decimal.Parse(saleParams[2]),
                Quantity = decimal.Parse(saleParams[3])
            };
        }
    }

    public class SalesReport
    {
        public static void Main()
        {
            var totalSales = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < totalSales; i++)
            {
                var currentSaleAsString = Console.ReadLine();
                var currentSale = Sale.Parse(currentSaleAsString);

                if (!result.ContainsKey(currentSale.Town))
                {
                    result[currentSale.Town] = 0;
                }

                result[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var kvp in result)
            {
                var town = kvp.Key;
                var totalSale = kvp.Value;

                Console.WriteLine($"{town} -> {totalSale:F2}");
            }
        }
    }
}
