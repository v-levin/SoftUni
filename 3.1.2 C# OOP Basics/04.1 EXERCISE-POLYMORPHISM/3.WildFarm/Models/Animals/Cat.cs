namespace WildFarm.Models.Animals
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string animalName, string animalType, double AnimalWeight, string livingRegion, string breed) 
            : base(animalName, animalType, AnimalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        protected string Breed { get => this.breed; private set => this.breed = value; }

        public override string MakeSound()
        {
            return "Meowwww";
        }


        public override string ToString()
        {
            return $"{this.GetType().Name}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
