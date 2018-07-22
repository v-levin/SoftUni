namespace BarracksWarsReturnOfTheDependencies.Contracts
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
