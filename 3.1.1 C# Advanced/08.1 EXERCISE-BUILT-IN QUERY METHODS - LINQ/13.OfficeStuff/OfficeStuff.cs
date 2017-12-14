using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.OfficeStuff
{
    public class OfficeStuff
    {
        public static void Main()
        {
            var numberOfOrders = int.Parse(Console.ReadLine());
            var officeStuff = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfOrders; i++)
            {
                var inputArgs = Console.ReadLine()
                    .Trim('|')
                    .Split(new[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var company = inputArgs[0];
                var amount = int.Parse(inputArgs[1]);
                var product = inputArgs[2];

                if (!officeStuff.ContainsKey(company))
                {
                    officeStuff.Add(company, new Dictionary<string, int>());
                }

                if (!officeStuff[company].ContainsKey(product))
                {
                    officeStuff[company].Add(product, 0);
                }

                officeStuff[company][product] += amount;
            }

            var orderedCompanyStuff = officeStuff.OrderBy(c => c.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var company in orderedCompanyStuff)
            {
                Console.Write($"{company.Key}: ");

                var sb = new StringBuilder();
                foreach (var stuff in company.Value)
                {
                    sb.Append($"{stuff.Key}-{stuff.Value}, ");
                }

                // remove last comma(, )
                sb.Remove(sb.Length - 2, 1);

                Console.WriteLine(sb);
            }
        }
    }
}
