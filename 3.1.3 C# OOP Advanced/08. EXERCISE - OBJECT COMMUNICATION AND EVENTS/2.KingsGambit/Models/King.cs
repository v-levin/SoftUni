using System;

namespace _2.KingsGambit.Models
{
    public class King
    {
        public event EventHandler UnderAttack;

        public King(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void OnUnderAttack()
        {
            Console.WriteLine($"King {Name} is under attack!");
            UnderAttack?.Invoke(this, new EventArgs());
        }
    }
}
