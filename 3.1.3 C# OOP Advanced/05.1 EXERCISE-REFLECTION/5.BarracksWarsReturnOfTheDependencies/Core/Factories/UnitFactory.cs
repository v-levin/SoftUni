namespace BarracksWarsReturnOfTheDependencies.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        private const string UnitNameSpace = "BarracksWarsReturnOfTheDependencies.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type typeUnit = Type.GetType(UnitNameSpace + unitType);
            IUnit unitInstance = (IUnit)Activator.CreateInstance(typeUnit);
            return unitInstance;
        }
    }
}
