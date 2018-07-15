using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HarvestingFields
{
    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type harvestingFieldsType = typeof(HarvestingFields);
            FieldInfo[] harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            Dictionary<string, Func<FieldInfo[]>> accModFilters = new Dictionary<string, Func<FieldInfo[]>>()
            {
                { "public", () => harvestingFields.Where(f => f.IsPublic).ToArray() },
                { "private", () => harvestingFields.Where(f => f.IsPrivate).ToArray() },
                { "protected", () => harvestingFields.Where(f => f.IsFamily).ToArray() },
                { "all", () => harvestingFields }
            }; 

            FieldInfo[] gatheredFields;
            string requestedAccMod;
            while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
            {
                accModFilters[requestedAccMod]()
                    .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}").ToArray()
                    .ToList()
                    .ForEach(r => Console.WriteLine(r.Replace("family", "protected")));
            }
        }
    }
}
