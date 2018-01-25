namespace WildFarm.Models
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.AnimalWeight = animalWeight;
        }

        protected string AnimalName { get => this.animalName; private set => this.animalName = value; }

        protected string AnimalType { get => this.animalType; private set => this.animalType = value; }

        protected double AnimalWeight { get => this.animalWeight; private set => this.animalWeight = value; }

        protected int FoodEaten { get => this.foodEaten; private set => this.foodEaten = value; }


        public abstract string MakeSound();

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
    }
}
