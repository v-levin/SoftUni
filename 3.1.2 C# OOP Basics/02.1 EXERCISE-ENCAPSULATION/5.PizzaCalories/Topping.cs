using System;

namespace PizzaCalories
{
    public class Topping
    {
        private const double baseCaloriesPerGram = 2;

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get { return this.type; }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public int Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double modifier = baseCaloriesPerGram;
            switch (this.Type.ToLower())
            {
                case "meat":
                    modifier *= 1.2;
                    break;
                case "veggies":
                    modifier *= 0.8;
                    break;
                case "cheese":
                    modifier *= 1.1;
                    break;
                case "sauce":
                    modifier *= 0.9;
                    break;
            }

            return modifier * this.Weight;
        }
    }
}
