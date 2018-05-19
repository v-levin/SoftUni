using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;
using System.Linq;

namespace InfernoInfinity.Models.Weapons
{
    public class Weapon : IWeapon
    {
        public Weapon(string name, int minDamage, int maxDamage, WeaponRarity rarity, int numOfSockets)
        {
            this.Name = name;
            this.MinDamage = minDamage;
            this.MaxDamage = maxDamage;
            this.Rarity = rarity;
            this.GemSockets = new IGem[numOfSockets];
        }

        public string Name { get; }

        public int MinDamage { get; private set; }

        public int MaxDamage { get; private set; }

        public IGem[] GemSockets { get; private set; }

        public WeaponRarity Rarity { get; private set; }

        public void AddGem(IGem gem, int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.GemSockets.Length)
            {
                return;
            }

            this.GemSockets[socketIndex] = gem;
        }

        public void RemoveGem(int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.GemSockets.Length)
            {
                return;
            }

            this.GemSockets[socketIndex] = null;
        }

        public override string ToString()
        {
            var strength = this.GemSockets.Where(g => g != null).Select(g => g.StrengthBonus + (int)g.Clarity).Sum();
            var agility = this.GemSockets.Where(g => g != null).Select(g => g.AgilityBonus + (int)g.Clarity).Sum();
            var vitality = this.GemSockets.Where(g => g != null).Select(g => g.VitalityBonus + (int)g.Clarity).Sum();

            var minDamage = (this.MinDamage * (int)this.Rarity) + (strength * 2) + agility;
            var maxDamage = (this.MaxDamage * (int)this.Rarity) + (strength * 3) + (agility * 4);

            return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{strength} Strength, +{agility} Agility, +{vitality} Vitality";
        }
    }
}
