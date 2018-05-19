using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Models.Weapons;
using System;

namespace InfernoInfinity.Factories
{
    public class WeaponFactory
    {
        internal IWeapon CreateWeapon(string weaponName, string weaponType, string weaponRarity)
        {
            WeaponRarity rarity;
            var isRarityValid = Enum.TryParse(weaponRarity, out rarity);

            if (!isRarityValid)
            {
                return null;
            }

            switch (weaponType)
            {
                case "Axe":
                    return new Axe(weaponName, rarity);
                case "Sword":
                    return new Sword(weaponName, rarity);
                case "Knife":
                    return new Knife(weaponName, rarity);
                default:
                    return null;
            }
        }
    }
}
