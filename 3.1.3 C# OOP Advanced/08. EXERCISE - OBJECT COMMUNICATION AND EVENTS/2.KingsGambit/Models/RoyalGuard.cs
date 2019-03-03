using System;

namespace _2.KingsGambit.Models
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name) : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {Name} is defending!");
        }
    }
}
