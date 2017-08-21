using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Products
{
    public class Products
    {
        public class Product
        {
            public string Type { get; set; }

            public string Name { get; set; }

            public decimal Price { get; set; }

            public int Quantity { get; set; }
        }

        public static string stockedProducts = "../../stocked_products.txt";

        public static void Main()
        {
            var products = new List<Product>();
            var sales = new Dictionary<string, decimal>();
            
            // Read pfoducts_db file
            if (File.Exists(stockedProducts))
            {
                var productsDB = File.ReadAllLines(stockedProducts);

                foreach (var data in productsDB)
                {
                    AddProduct(products, data);
                }
            }

            var inputLine = Console.ReadLine();

            File.Create("../../output.txt").Close();

            while (inputLine != "exit")
            {
                switch (inputLine)
                {
                    case "analyze":
                        Analyze(products);
                        break;
                    case "sales":
                        Sales(products, sales);
                        break;
                    case "stock":
                        Stock(products);
                        break;
                    default:
                        var inputParams = inputLine.Split();
                        var productName = inputParams[0];
                        var productType = inputParams[1];
                        var price = decimal.Parse(inputParams[2]);
                        var quantity = int.Parse(inputParams[3]);

                        var productExist = false;

                        foreach (var product in products)
                        {
                            if (product.Name == productName && product.Type == productType)
                            {
                                product.Price = price;
                                product.Quantity = quantity;

                                productExist = true;
                                break;
                            }
                        }

                        if (!productExist)
                        {
                            AddProduct(products, inputLine);
                        }
                        break;
                }


                inputLine = Console.ReadLine();
            }
        }

        private static void Sales(List<Product> products, Dictionary<string, decimal> sales)
        {
            foreach (var product in products)
            {
                var type = product.Type;
                var sum = product.Price * product.Quantity;

                if (!sales.ContainsKey(type))
                {
                    sales[type] = 0;
                }

                sales[type] += sum;
            }

            foreach (var sale in sales.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("../../output.txt", $"{sale.Key}: ${sale.Value:F2}{Environment.NewLine}");
            }

            sales.Clear();
        }

        private static void Analyze(List<Product> products)
        {
            if (!File.Exists(stockedProducts))
            {
                File.Create(stockedProducts).Close();
            }

            if (File.ReadAllLines(stockedProducts).Length > 0)
            {
                foreach (var prod in products.OrderBy(x => x.Type))
                {
                    var name = prod.Name;
                    var type = prod.Type;
                    var price = prod.Price;
                    var quantity = prod.Quantity;

                    File.AppendAllText("../../output.txt", $"{type}, Product: {name}{Environment.NewLine}");
                    File.AppendAllText("../../output.txt", $"Price: ${price}, Amount Left: {quantity}{Environment.NewLine}");
                }
            }
            else
            {
                File.AppendAllText("../../output.txt", $"No products stocked{Environment.NewLine}");
            }
        }

        private static void Stock(List<Product> products)
        {
            foreach (var product in products)
            {
                File.AppendAllText(stockedProducts, $"{product.Name} {product.Type} {product.Price} {product.Quantity}{Environment.NewLine}");
            }
        }

        private static void AddProduct(List<Product> products, string data)
        {
            var dataParams = data.Split();
            var name = dataParams[0];
            var type = dataParams[1];
            var price = decimal.Parse(dataParams[2]);
            var quantity = int.Parse(dataParams[3]);

            var product = new Product()
            {
                Type = type,
                Name = name,
                Price = price,
                Quantity = quantity
            };

            products.Add(product);
        }
    }
}
