using InfernoInfinity.Enums;

namespace InfernoInfinity.Models.Weapons
{
    public class Knife : Weapon
    {
        private new const int MinDamage = 3;
        private new const int MaxDamage = 4;
        private new const int GemSockets = 2;

        public Knife(string name, WeaponRarity rarity)
            : base(name, MinDamage, MaxDamage, rarity, GemSockets)
        {
        }
    }
}
