using InfernoInfinity.Enums;

namespace InfernoInfinity.Models.Weapons
{
    public class Axe : Weapon
    {
        private new const int MinDamage = 5;
        private new const int MaxDamage = 10;
        private new const int GemSockets = 4;

        public Axe(string name, WeaponRarity rarity)
            : base(name, MinDamage, MaxDamage, rarity, GemSockets)
        {
        }
    }
}
