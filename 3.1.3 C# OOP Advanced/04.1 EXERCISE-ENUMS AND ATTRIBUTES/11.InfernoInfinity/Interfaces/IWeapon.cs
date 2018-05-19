using InfernoInfinity.Enums;

namespace InfernoInfinity.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; }

        int MaxDamage { get; }

        IGem[] GemSockets { get; }

        WeaponRarity Rarity { get; }

        void AddGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}
