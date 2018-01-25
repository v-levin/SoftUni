namespace WildFarm.Models
{
    public abstract class Felime : Mammal
    {
        protected Felime(string animalName, string animalType, double AnimalWeight, string livingRegion) 
            : base(animalName, animalType, AnimalWeight, livingRegion)
        {
        }
    }
}
