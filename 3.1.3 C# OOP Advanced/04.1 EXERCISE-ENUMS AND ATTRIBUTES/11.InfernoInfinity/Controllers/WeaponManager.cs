using InfernoInfinity.Factories;
using InfernoInfinity.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace InfernoInfinity.Controllers
{
    public class WeaponManager
    {
        private IList<IWeapon> weapons;
        private WeaponFactory weaponFactory;

        public WeaponManager()
        {
            this.weapons = new List<IWeapon>();
            this.weaponFactory = new WeaponFactory();
        }

        internal void CreateWeapon(string weaponName, string weaponType, string weaponRarity)
        {
            var weapon = this.weaponFactory.CreateWeapon(weaponName, weaponType, weaponRarity);

            if (weapon != null)
            {
                this.weapons.Add(weapon);
            }
        }

        internal void AddGemToWeapon(string weaponName, int socketIndex, IGem gem)
        {
            this.GetWeapon(weaponName)?.AddGem(gem, socketIndex);
        }

        internal void RemoveGemFromWeapon(string weaponName, int socketIndex)
        {
            this.GetWeapon(weaponName)?.RemoveGem(socketIndex);
        }

        public IWeapon GetWeapon(string weaponName)
        {
            return this.weapons.FirstOrDefault(w => w.Name == weaponName);
        }
    }
}
