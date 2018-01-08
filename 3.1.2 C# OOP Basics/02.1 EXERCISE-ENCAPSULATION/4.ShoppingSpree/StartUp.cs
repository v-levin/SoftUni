﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var products = new List<Product>();

            var allPeople = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var allProducts = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var pair in allPeople)
                {
                    var personInfo = pair.Split('=');
                    var personName = personInfo[0];
                    var personMoney = decimal.Parse(personInfo[1]);

                    var person = new Person(personName, personMoney);
                    people.Add(person);
                }

                foreach (var pair in allProducts)
                {
                    var productInfo = pair.Split('=');
                    var productName = productInfo[0];
                    var productCost = decimal.Parse(productInfo[1]);

                    var product = new Product(productName, productCost);
                    products.Add(product);
                }

                string purchase;
                while ((purchase = Console.ReadLine()) != "END")
                {
                    var purchaseInfo = purchase.Split();
                    var buyerName = purchaseInfo[0];
                    var productName = purchaseInfo[1];

                    var buyer = people.FirstOrDefault(b => b.Name == buyerName);
                    var productToBuy = products.FirstOrDefault(p => p.Name == productName);

                    try
                    {
                        buyer.BuyProduct(productToBuy);
                        Console.WriteLine($"{buyer.Name} bought {productName}");
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                foreach (var person in people)
                {
                    var boughtProducts = person.GetProducts();
                    var result = boughtProducts.Any() ? string.Join(", ", boughtProducts.Select(p => p.Name).ToList()) : "Nothing bought";

                    Console.WriteLine($"{person.Name} - {result}");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
