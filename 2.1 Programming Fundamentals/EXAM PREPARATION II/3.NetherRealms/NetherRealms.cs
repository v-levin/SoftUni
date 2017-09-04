using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3.NetherRealms
{
    public class NetherRealms
    {

        public class Demon
        {
            public int Health { get; set; }

            public double Damage { get; set; }
        }

        public static void Main()
        {
            var demonsData = new SortedDictionary<string, Demon>();

            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            
            foreach (var demon in demons)
            {
                var health = GetHealth(demon);
                var damage = GetDamage(demon);

                demonsData.Add(demon, new Demon
                {
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var demonData in demonsData)
            {
                var demonName = demonData.Key;
                var demon = demonData.Value;

                Console.WriteLine($"{demonName} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }

        private static double GetDamage(string demon)
        {
            var regex = new Regex(@"-?\d+\.?\d*");

            var matches = regex.Matches(demon);

            var damage = 0.0;

            foreach (Match match in matches)
            {
                var currentNumber = double.Parse(match.Value);

                damage += currentNumber;
            }

            var modifiers = demon.Where(s => s == '/' || s == '*');

            foreach (var modifier in modifiers)
            {
                if (modifier == '*')
                {
                    damage *= 2;
                }
                else if (modifier == '/')
                {
                    damage /= 2;
                }
            }

            return damage;
        }

        private static int GetHealth(string demon)
        {
            var healthSymbols = demon.Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.');

            var health = 0;

            foreach (var healthSymbol in healthSymbols)
            {
                health += healthSymbol;
            }

            return health;
        }
    }
}
