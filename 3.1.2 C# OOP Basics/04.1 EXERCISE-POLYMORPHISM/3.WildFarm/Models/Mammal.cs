namespace WildFarm.Models
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        protected Mammal(string animalName, string animalType, double AnimalWeight, string livingRegion) 
            : base(animalName, animalType, AnimalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        protected string LivingRegion { get => this.livingRegion; private set => this.livingRegion = value; }


        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
