using System;

namespace _2.KingsGambit.Models
{
    public abstract class Soldier
    {
        public Soldier(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void KingUnderAttack(object sender, EventArgs args);
    }
}
