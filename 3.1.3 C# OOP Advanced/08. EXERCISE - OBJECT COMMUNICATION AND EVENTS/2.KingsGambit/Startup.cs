using _2.KingsGambit.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.KingsGambit
{
    public class Startup
    {
        public static void Main()
        {
            var army = new List<Soldier>();

            var kingName = Console.ReadLine();
            var king = new King(kingName);

            var royalGuards = Console.ReadLine().Split();
            foreach (var royalGuardName in royalGuards)
            {
                var guard = new RoyalGuard(royalGuardName);
                army.Add(guard);
                king.UnderAttack += guard.KingUnderAttack;
            }

            var footmen = Console.ReadLine().Split();
            foreach (var footmanName in footmen)
            {
                var footman = new Footman(footmanName);
                army.Add(footman);
                king.UnderAttack += footman.KingUnderAttack;
            }

            var command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Attack":
                        king.OnUnderAttack();
                        break;
                    case "Kill":
                        var soldier = army.First(s => s.Name == command[1]);
                        army.Remove(soldier);
                        king.UnderAttack -= soldier.KingUnderAttack;
                        break;
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
