using CreateCustomClassAttribute.Attributes;
using CreateCustomClassAttribute.Models;
using System;
using System.Linq;

namespace CreateCustomClassAttribute
{
    public class StartUp
    {
        public static void Main()
        {
            var attr = (InfoAttribute)typeof(Weapon).GetCustomAttributes(true).First();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                attr.PrintInfo(input);
            }
        }
    }
}
