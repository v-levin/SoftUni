using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.MostValuedCustomer
{
    public class MostValuedCustomer
    {
        static Dictionary<string, double> productsPriceDict = new Dictionary<string, double>();
        static Dictionary<string, Dictionary<string, double>> customerSpendings = new Dictionary<string, Dictionary<string, double>>();
        static Dictionary<string, Dictionary<string, int>> customerProductsQuantity = new Dictionary<string, Dictionary<string, int>>();

        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var customerName = string.Empty;

            while (inputLine != "Shop is open")
            {
                GetProductsAndPrices(inputLine);

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "Print")
            {
                if (inputLine != "Discount")
                {
                    var inputParams = inputLine.Split(new[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = inputParams[0];
                    var products = inputParams.Skip(1).ToList();

                    GetCustomerSpendings(name, products);

                    GetCustomerProductsQuantity(name, products);
                }
                else
                {
                    GetDiscount();
                }

                inputLine = Console.ReadLine();
            }

            PrintResult();
        }

        static void PrintResult()
        {
            var biggestSpender = customerSpendings.OrderByDescending(x => x.Value.Values.Max()).Select(x => x.Key).First().ToString();

            Console.WriteLine($"Biggest spender: {biggestSpender}");
            Console.WriteLine("^Products bought:");

            var shoppedProducts = customerSpendings[biggestSpender].OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            var total = 0.0;

            foreach (var product in productsPriceDict.OrderByDescending(x => x.Value))
            {
                foreach (var shoppedProduct in shoppedProducts)
                {
                    if (product.Key == shoppedProduct)
                    {
                        Console.WriteLine($"^^^{shoppedProduct}: {productsPriceDict[shoppedProduct]:F2}");
                        total += productsPriceDict[shoppedProduct] * customerProductsQuantity[biggestSpender][shoppedProduct];
                        break;
                    }
                }
            }

            Console.WriteLine($"Total: {total:F2}");
        }

        static void GetDiscount()
        {
            var discountedProducts = productsPriceDict.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToList();

            foreach (var disProd in discountedProducts)
            {
                productsPriceDict[disProd] *= 0.9;
            }
        }

        static void GetCustomerSpendings(string name, List<string> products)
        {
            customerSpendings[name] = new Dictionary<string, double>();

            foreach (var product in products)
            {
                if (productsPriceDict.ContainsKey(product))
                {
                    if (!customerSpendings[name].ContainsKey(product))
                    {
                        customerSpendings[name][product] = 0.0;
                    }

                    customerSpendings[name][product] += productsPriceDict[product];
                }
            }
        }

        static void GetCustomerProductsQuantity(string name, List<string> products)
        {
            customerProductsQuantity[name] = new Dictionary<string, int>();

            foreach (var product in products)
            {
                if (productsPriceDict.ContainsKey(product))
                {
                    if (!customerProductsQuantity[name].ContainsKey(product))
                    {
                        customerProductsQuantity[name][product] = 0;
                    }

                    customerProductsQuantity[name][product]++;
                }
            }
        }

        static void GetProductsAndPrices(string inputLine)
        {
            var inputParams = inputLine.Split();
            var product = inputParams[0];
            var price = double.Parse(inputParams[1]);

            productsPriceDict[product] = price;
        }
    }
}
