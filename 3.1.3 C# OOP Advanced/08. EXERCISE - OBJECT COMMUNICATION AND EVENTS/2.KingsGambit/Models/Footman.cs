using System;

namespace _2.KingsGambit.Models
{
    public class Footman : Soldier
    {
        public Footman(string name) : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {Name} is panicking!");
        }
    }
}
