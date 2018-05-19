using InfernoInfinity.Enums;

namespace InfernoInfinity.Models.Weapons
{
    public class Sword : Weapon
    {
        private new const int MinDamage = 4;
        private new const int MaxDamage = 6;
        private new const int GemSockets = 3;

        public Sword(string name, WeaponRarity rarity)
            : base(name, MinDamage, MaxDamage, rarity, GemSockets)
        {
        }
    }
}
